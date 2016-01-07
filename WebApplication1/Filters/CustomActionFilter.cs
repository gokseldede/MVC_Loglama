using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Filters
{
    public class CustomActionFilter : ActionFilterAttribute, IActionFilter

    {
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            TestLogEntities _logdb = new TestLogEntities();
            ActionLog log = new ActionLog()
            {

                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName,
                IP = filterContext.HttpContext.Request.UserHostName,
                DateTime = filterContext.HttpContext.Timestamp,
                User=filterContext.HttpContext.User.Identity.Name
            };


            _logdb.ActionLogs.Add(log);
            _logdb.SaveChanges();
            this.OnActionExecuting(filterContext);

        }
    }
}