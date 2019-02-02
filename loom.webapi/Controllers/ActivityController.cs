using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using loom.webapi.models;

namespace loom.webapi.Controllers
{
    public class ActivityController : ApiController
    {
        static LoomDB _db = new LoomDB("Server=localhost;Database=Loom_DB;User Id=loom_user;Password=Peri_123;");
        
        public IEnumerable<Activity> GetAllActivities()
        {
            return _db.Activity;
        }      
    }
}