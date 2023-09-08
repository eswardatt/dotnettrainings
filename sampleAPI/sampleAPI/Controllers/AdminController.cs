using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using sampleAPI.Models;

namespace sampleAPI.Controllers
{
    public class AdminController : BaseController
    {
        private ApplicationContext applicationContext;

        public AdminController()
        {
            this.applicationContext = new ApplicationContext();
        }
        [HttpGet]
        public IHttpActionResult GetAdmins()
        {
            List<Admin> admins = new List<Admin>();
            admins = applicationContext.Admins.AsQueryable().ToList();
            return Ok(admins);
        }

        [HttpPost]
        public IHttpActionResult AddAdmin(Admin admin)
        {
            if (admin != null)
            {
                admin.createdAt = DateTime.Now;
                applicationContext.Admins.Add(admin);
                applicationContext.SaveChanges();
            }
            return Created("admin", admin);
        }

        [HttpPost]
        public IHttpActionResult updateAdmin(int id,Admin admin)
        {
            var existingItem = applicationContext.Admins.Where(x => x.Id == id).First();
            if (existingItem != null)
            {
                existingItem.Name = admin.Name;
                applicationContext.SaveChanges();
                return Created("admin", admin);
            }
            else
            {
                var responseMessage = new HttpResponseMessage(HttpStatusCode.NotFound);
                responseMessage.Content = new StringContent("Item not found.");
                return Created("admin", responseMessage.ReasonPhrase);
            }


        }
    }
}
