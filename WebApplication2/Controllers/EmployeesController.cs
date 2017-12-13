using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<EMPLOYEESTABLE> Get()
        {
<<<<<<< HEAD
            using(myDbConnections entities = new myDbConnections())
=======
            using(mydbEntities1 entities = new mydbEntities1())
>>>>>>> 83a879b99cf47beb07d35186f8cf43d7a832fdcb
            {
                return entities.EMPLOYEESTABLE.ToList();
            }
        }
    }
}
