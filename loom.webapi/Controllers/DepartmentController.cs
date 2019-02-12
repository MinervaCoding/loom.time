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
    public class DepartmentController : ApiController
    {
        static LoomDB _db = new LoomDB(ConfigurationManager.AppSettings["LoomConnectionString"]);
        
        public IEnumerable<Department> GetAllDepartments()
        {
            return _db.Department;
        }

        public Department GetDepartment(long id)
        {

            var department = (from q in _db.Department
                           where q.DepartmentID == id
                           select q).FirstOrDefault();
            if (department == null)
            {
                throw new HttpResponseException(
                    Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return department;
        }
    }
}