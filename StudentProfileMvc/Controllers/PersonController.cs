using StudentProfileMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentProfileMvc.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Registration1(Person P)
        {
            return View("About", P);
        }
       

    }
}