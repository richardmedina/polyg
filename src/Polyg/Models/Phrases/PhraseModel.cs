using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polyg.Models.Phrases
{
    public class PhraseModel
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public IEnumerable<PhraseTranslationModel> Translations { get; set; }
    }
}
