using ITBeep.Data;
using ITBeep.Data.Services;
using ITBeep.Models;
using ITBeep.Models.HomeIndex.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ITBeep.Controllers.api
{
    public class ServicesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Route("api/GetServices")]
        [HttpGet]
        public async Task<IHttpActionResult> GetServices()
        {   
            return Ok(new {code="200", result=await db.Services.ToListAsync() });
        }

        [Route("api/SendEmail")]
        [HttpPost]
        public IHttpActionResult SendEmail([FromBody] EmailContentDto model )
        {
            Shared.SendEmailMsg(model);
            return Ok(new { code = "200", result = "email has been sent." });
        }



    }
}
