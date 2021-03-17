using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Polyg.Common.Services;
using Polyg.Models.Phrases;
using Polyg.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Polyg.Controllers
{
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [Route("[controller]")]
    [ApiController]
    public class PhrasesController : BaseController
    {
        private readonly IEnumerable<PhraseModel> phrases = Enumerable.Range(1, 20)
            .Select(n => new PhraseModel
            {
                Id = n,
                Text = $"Text {n}",
                Translations = new List<PhraseTranslationModel> {
                    new PhraseTranslationModel
                    {
                        CultureName = "en-US",
                        Text = $"English: Text {n}"
                    }
                }
            });
        private IAuthUserService _authUserService;
        private readonly IPhraseService _phraseService;

        public PhrasesController(IAuthUserService authUserService, IPhraseService phraseService)
        {
            _authUserService = authUserService;
            _phraseService = phraseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string userName, [FromQuery] long languageId)
        {
            var result = await _authUserService.GetByUserName(userName);
            
            var phrases = await _phraseService.GetPhrasesAsync(result.Result.Id, languageId);

            return GetResponse(null, phrases.Result, phrases.StatusCode, phrases.ErrorMessage);
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            await Task.CompletedTask;

            return Ok();
            
        }

    }
}
