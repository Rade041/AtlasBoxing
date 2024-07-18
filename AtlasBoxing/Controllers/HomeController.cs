using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtlasBoxing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Meet the Founders";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Find us at";

            return View();
        }

        public ActionResult Classes()
        {
            ViewBag.Message = "Timetables";


            return View();
        }
        public ActionResult YouthCommunityHub()
        {
            ViewBag.Message = "Youth Community Hub";

            return View();
        }
        public ActionResult Pricing()
        {
            ViewBag.Message = "Pricing";

            return View();
        }

    }
}       