using sampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace sampleAPI.Controllers
{
    [Authentication]
    public class BaseController : ApiController
    {
        ILog log;
        public BaseController()
        {
            
        }
        // GET: Base

        
        
    }
}