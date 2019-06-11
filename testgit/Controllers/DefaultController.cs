using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using testgit.Models;

namespace testgit.Controllers
{
    public class DefaultController : ApiController
    {

        List<animals> a = new List<animals>()
        {
            new animals{id= 1, name= "cat"}
        };
        // GET: Person
       

        public animals Get(int id)
        {
            return a.FirstOrDefault(s => s.id == id);
        }
    }
}
