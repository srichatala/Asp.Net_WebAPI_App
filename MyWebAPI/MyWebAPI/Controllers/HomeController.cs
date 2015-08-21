using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Student()
        {
            ViewBag.Title = "Student Profile";
            return View();
        }

        public ActionResult Faculty()
        {
            ViewBag.Title = "Faculty Profile";
            return View();
        }
    }
}
