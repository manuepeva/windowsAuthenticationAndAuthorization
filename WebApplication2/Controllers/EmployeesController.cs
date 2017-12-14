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
            using(myDBConnection entities = new myDBConnection())
=======
<<<<<<< HEAD
            using(myDbConnections entities = new myDbConnections())
=======
            using(mydbEntities1 entities = new mydbEntities1())
>>>>>>> 83a879b99cf47beb07d35186f8cf43d7a832fdcb
>>>>>>> 52b3dad01cd8589ea8343652c6e9a937cc9314d5
            {
                return entities.EMPLOYEESTABLE.ToArray();
            }
        }
    }
}
