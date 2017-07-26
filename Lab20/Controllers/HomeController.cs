using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Fresh Beans. Fresh Start.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "We want to hear from you.";

            return View();
        }
        public ActionResult Registration()
        {
            ViewBag.Message = "Register Here";

            return View();
        }
        public ActionResult ValidateForm()
        {
            ViewBag.Message = "Register Here";

            return View();
        }
    }
}