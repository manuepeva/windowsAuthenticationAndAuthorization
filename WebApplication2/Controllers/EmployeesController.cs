﻿using System;
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
            using(mydbEntities1 entities = new mydbEntities1())
            {
                return entities.EMPLOYEESTABLE.ToList();
            }
        }
    }
}
