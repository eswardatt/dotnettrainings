using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace sampleAPI.Models
{
    public class Logging : ActionFilterAttribute
    {
        ILog log;
        public Logging()
        {
            log = Log.GetInstance;
        }
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            // Log request details
            var request = actionContext.Request;
            var controllerName = actionContext.ControllerContext.ControllerDescriptor.ControllerName;
            var actionName = actionContext.ActionDescriptor.ActionName;
            var logMessage = $"Request to {controllerName}/{actionName} at {DateTime.Now}";
            log.LogException(logMessage);
        }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            // Log response details
            var response = actionExecutedContext.Response;
            if (response != null)
            {
                var controllerName = actionExecutedContext.ActionContext.ControllerContext.ControllerDescriptor.ControllerName;
                var actionName = actionExecutedContext.ActionContext.ActionDescriptor.ActionName;
                var logMessage = $"Response from {controllerName}/{actionName} at {DateTime.Now}";
                log.LogException(logMessage);
            }
        }
    }
}