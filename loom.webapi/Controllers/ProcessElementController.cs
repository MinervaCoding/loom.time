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
    public class ProcessElementController : ApiController
    {
        static LoomDB _db = new LoomDB(ConfigurationManager.AppSettings["LoomConnectionString"]);
        
        public IEnumerable<ProcessElement> GetAllProcessElements(long id)
        {
            var processelements = from q in _db.ProcessElement
                                  where q.Department == id
                                  select q;
            if (processelements == null)
            {
                throw new HttpResponseException(
                    Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return processelements;
        }      
    }
}