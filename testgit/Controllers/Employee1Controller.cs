using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testgit.Models;

namespace testgit.Controllers
{
    public class Employee1Controller : Controller
    {
        // GET: Default1
        List<employee> people = new List<employee>()
        {
            new employee{ID= 1}
        };
    }
}