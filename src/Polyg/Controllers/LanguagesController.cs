using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Polyg.Common.Services;
using Polyg.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polyg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguagesController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _languageService.GetAllAsync();

            return result.StatusCode == ServiceStatusCode.Success
                ? StatusCode(StatusCodes.Status200OK, result.Result)
                : StatusCode(StatusCodes.Status500InternalServerError, null);
        }

        [HttpGet("{id:long}")]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await _languageService.GetByIdAsync(id);

            return result.StatusCode == ServiceStatusCode.Success
                ? StatusCode(StatusCodes.Status200OK, result.Result)
                : StatusCode(StatusCodes.Status500InternalServerError, null);
        }
    }
}
