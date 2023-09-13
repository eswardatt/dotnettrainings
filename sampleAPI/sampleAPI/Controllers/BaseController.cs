using sampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace sampleAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [Authentication]
    [ExceptionFilter]
    [Logging]
    public class BaseController : ApiController
    {
       
        public BaseController()
        {
            
        }
        // GET: Base
      
    }
}