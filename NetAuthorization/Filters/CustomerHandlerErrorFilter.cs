using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetAuthorization.Filters
{
    public class CustomerHandlerErrorFilter: HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            filterContext.HttpContext.Response.StatusCode = 500;
            filterContext.HttpContext.Response.Write("Server Error");
            filterContext.HttpContext.Response.End();
            filterContext.ExceptionHandled = true;
            return;
            //base.OnException(filterContext);
        }
    }
}