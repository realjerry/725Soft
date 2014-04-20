using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _725Soft.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "You can get any IT support from 725Soft.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your best IT service provider.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Always welcome your contact.";

            return View();
        }

        public ActionResult Cases()
        {
            ViewBag.Message = "Successful cases of Solutions we made.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "All kind of services we provide.";

            return View();
        }
    }
}
