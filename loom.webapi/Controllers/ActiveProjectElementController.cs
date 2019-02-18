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
    public class ActiveProjectElementController : ApiController
    {
        static LoomDB _db = new LoomDB(ConfigurationManager.AppSettings["LoomConnectionString"]);

        public IEnumerable<ProjectElement> GetActiveProjectElements(long id)
        {

            var startedprjelements = from prj in _db.ProjectElement
                                     from act in prj.Activity
                                     join prz in _db.ProcessElement on act.ProcessElement equals prz.ProcessElementID
                                     where prz.ProcessElementType == 1 && prz.Department == id
                                     select prj;

            var endedprjelements = from prj in _db.ProjectElement
                                   from act in prj.Activity
                                   join prz in _db.ProcessElement on act.ProcessElement equals prz.ProcessElementID
                                   where prz.ProcessElementType == 3 && prz.Department == id
                                   select prj;

            return startedprjelements.Except(endedprjelements);

        }
    }
}