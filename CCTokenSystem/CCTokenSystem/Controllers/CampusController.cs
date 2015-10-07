using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CCTokenSystem.Controllers
{
    public class CampusController : Controller
    {
        // GET: Campus
        public ActionResult Index()
        {
            ViewBag.Title = "Campus Page";

            return View();
        }
    }
}