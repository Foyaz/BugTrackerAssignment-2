using BugTrackerAssignment_2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTrackerAssignment_2.Models.Action_Filter
{
    public class CrawlerDetectingActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var crawlerAction = new CrawlerDetectingActionFilter();
            var controller = filterContext.Controller as HomeController;
            if (controller.Request.Browser.Crawler)
            {
                var viewName = "Crawler" + filterContext.ActionDescriptor.ActionName;
                filterContext.Result = controller.Index(viewName);
            }
            else
            {
            base.OnActionExecuted(filterContext);
            }
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
    }
}