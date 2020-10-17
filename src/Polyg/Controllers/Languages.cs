using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polyg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Languages : ControllerBase
    {
        
        public async Task<IActionResult> GetAll()
        {
            await Task.Yield();

            return Ok();
        }
    }
}
