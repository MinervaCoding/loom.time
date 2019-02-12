using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using loom.webapi.models;
using System.Configuration;

namespace loom.webapi.Controllers
{
    public class PerformanceController : ApiController
    {
        static LoomDB _db = new LoomDB(ConfigurationManager.AppSettings["LoomConnectionString"]);

        public Performance GetPerformancesByStaffID(long id)
        {
            var performance = (from p in _db.Performance
                where p.Staff == id
                select p).FirstOrDefault();
            if (performance == null)
            {
                throw new HttpResponseException(
                    Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return performance;
        }
        
        public HttpResponseMessage PostPerformance(Performance item)
        {
            
            _db.Performance.InsertOnSubmit(item);
            
            try
            {
                _db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Make some adjustments.
                // ...
                // Try again.
                _db.SubmitChanges();
            }
            
            var response = Request.CreateResponse<Performance>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.PerformanceID});
            response.Headers.Location = new Uri(uri);
            return response;
            
             
        }

        public void PutPerformance(int id, Performance item)
        {
            // Query the database for the row to be updated.
            var query = from perf in _db.Performance
                        where perf.PerformanceID == id
                        select perf;

            foreach (Performance p in query)
            {
                p.Staff = item.Staff;
                p.Activity = item.Activity;
                p.Date = item.Date;
                p.Time = item.Time;
                p.Work = item.Work;
                p.EntryDate = item.EntryDate;
            }

            try
            {
                _db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            
        }
    }
}