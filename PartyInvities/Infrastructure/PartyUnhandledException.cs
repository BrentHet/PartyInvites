using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PartyInvities.Infrastructure
{
    public class PartyUnhandledException : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                //filterContext.Result = new RedirectResult("Content/PrettyError.html");
                //filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary
                //{
                //    {"controller", "PrettyError"},
                //    {"action", "Index"},
                //    {"area", ""}
                //});

                filterContext.Result = new ViewResult
                {
                    ViewName = "PrettyError",
                    ViewData = new ViewDataDictionary<Exception>(filterContext.Exception)
                };

                filterContext.ExceptionHandled = true;
            }
        }
    }
}