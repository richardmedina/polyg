using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Polyg.Abstract.Services;
using Polyg.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Polyg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthUserService _authUserService;

        public AuthController(IAuthUserService authUserService)
        {
            _authUserService = authUserService;
        }

        [HttpPost]
        public IActionResult Auth([FromBody] AuthUserModel authUser)
        {
            var user = _authUserService.AuthenticateUser(authUser.UserName, authUser.Password);

            return user == null
                ? StatusCode(StatusCodes.Status401Unauthorized, null)
                : StatusCode(StatusCodes.Status200OK, user);
        }
    }
}
