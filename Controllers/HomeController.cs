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
            ViewBag.Message = @Resources.Global.Index_Message;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = @Resources.Global.About_Message;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = @Resources.Global.Contact_Message;

            return View();
        }

        public ActionResult Cases()
        {
            ViewBag.Message = @Resources.Global.Cases_Message;

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = @Resources.Global.Services_Message;

            return View();
        }
    }
}
