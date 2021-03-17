using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Polyg.Contract.Services;
using Polyg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace Polyg.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        public IActionResult GetResponse<TResult>(object request, TResult result, ServiceStatusCode statusCode, string message)
        {
            var response = new ResponseModel
            {
                Request = request,
                Result = result,
                Message = message
            };

            return StatusCode(GetStatusCode(statusCode), response);
        }

        private int GetStatusCode (ServiceStatusCode code)
        {
            switch(code)
            {
                case ServiceStatusCode.Error:
                    return StatusCodes.Status500InternalServerError;
                case ServiceStatusCode.ValidationError:
                    return StatusCodes.Status400BadRequest;
                case ServiceStatusCode.Success:
                    return StatusCodes.Status200OK;
                default:
                    return StatusCodes.Status500InternalServerError;
            }
        }
        
    }
}
