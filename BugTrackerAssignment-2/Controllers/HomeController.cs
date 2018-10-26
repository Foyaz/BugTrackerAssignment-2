using BugTrackerAssignment_2.Models.Action_Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTrackerAssignment_2.Controllers
{
    public class HomeController : Controller
    {
        [CrawlerDetectingActionFilter]
        public ActionResult Index(string viewName)
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}