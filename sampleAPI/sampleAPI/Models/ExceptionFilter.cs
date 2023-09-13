using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace sampleAPI.Models
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        ILog log;
        public ExceptionFilter()
        {
            log = Log.GetInstance;
        }

        public override void OnException(HttpActionExecutedContext context)
        {
            log.LogException(context.Exception.ToString());
            // Handle the exception and customize the response
            context.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent("An error occurred."),
                ReasonPhrase = "Internal Server Error"
            };
        }
    }
}