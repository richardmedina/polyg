using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Polyg.Models.Phrases;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Polyg.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("[controller]")]
    [ApiController]
    public class PhrasesController : ControllerBase
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

        [HttpGet]
        public IActionResult GetAll()
        {
            return StatusCode(StatusCodes.Status200OK, phrases);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var phrase = phrases.FirstOrDefault(phrase => phrase.Id == id);

            return phrase != null
                ? StatusCode(StatusCodes.Status200OK, phrase)
                : StatusCode(StatusCodes.Status404NotFound, null);
        }

    }
}
