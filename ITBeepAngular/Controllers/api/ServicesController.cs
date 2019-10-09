using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITBeepAngular.Models.Services;
using ITBeepAngular.Models.Services.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITBeepAngular.Controllers.api
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        public readonly IServices _services;

        public ServicesController(IServices services)
        {
            _services = services;
        }


        [Route("api/GetAllServices")]
        [HttpGet]
        // Commented for testing.
        //[Authorize]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok(new { result = await _services.GetServices() });
        }

        [Route("api/ReciveContent")]
        [HttpPost]
        public  IActionResult SendEmail([FromBody] EmailDto model)
        {
            return Ok(new { code = "200", result = "email has been sent" });
        }
    }
}