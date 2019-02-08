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
    public class StaffController : ApiController
    {
        static LoomDB _db = new LoomDB(ConfigurationManager.AppSettings["LoomConnectionString"]);

        public Staff GetStaff(long StafftID)
        {

            var staff = (from q in _db.Staff
                              where q.StaffID == StafftID
                              select q).FirstOrDefault();
            if (staff == null)
            {
                throw new HttpResponseException(
                    Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return staff;
        }
    }
}