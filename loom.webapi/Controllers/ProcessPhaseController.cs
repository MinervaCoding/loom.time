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
    public class ProcessPhaseController : ApiController
    {
        static LoomDB _db = new LoomDB(ConfigurationManager.AppSettings["LoomConnectionString"]);
        
        public IEnumerable<ProcessPhase> GetAllProcessPhases()
        {
            return _db.ProcessPhase;
        }      
    }
}