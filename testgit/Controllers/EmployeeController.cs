using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testgit.Models;

namespace testgit.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        List<Employee> people = new List<Employee>()
        {
            new Employee{Id= 1, Name= "reut"},
             new Employee{Id= 2, Name= "shulamit"}
        };
        public ActionResult Index()
        {
            return View();
        }
    }
}