using Microsoft.AspNetCore.Mvc;
using Polyg.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Polyg.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("test")]
        public async Task<IActionResult> GetTestResponse()
        {
            await Task.Yield();

            return Ok(new TestResponse
            {
                HostName = Dns.GetHostName(),
                Date = DateTime.Now
            });
        }
    }
}
