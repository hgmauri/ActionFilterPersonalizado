using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sistema.Web.Models
{
    public class BaseController : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            RegistraLog("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            RegistraLog("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            RegistraLog("OnResultExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            RegistraLog("OnResultExecuted", filterContext.RouteData);
        }


        private void RegistraLog(string nomeMetodo, RouteData routeData)
        {
            var nomeController = routeData.Values["controller"]; 
            var nomeAction = routeData.Values["action"];

            //Registra informações no banco ou no ELMAH
        }
    }
}
