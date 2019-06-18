using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testgit.Models;

namespace testgit.Controllers
{
    public class PersonController : Controller
    {
        List<Person> people = new List<Person>()
        {
            new Person{Code= 1, Name= "faigy"}
        };
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public Person Get(int id)
        {
            return people.FirstOrDefault(s => s.Code == id);
        }

        public void delete(int id)
        {
            
        }
    }
}