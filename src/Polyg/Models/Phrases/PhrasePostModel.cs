using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polyg.Models.Phrases
{
    public class PhrasePostModel
    {
        public string UserId { get; set; }
        public string LangaugeIdFrom { get; set; }
        public string LanguageIdTo { get; set; }
        public string TextFrom { get; set; }
        public string TextTo { get; set; }
    }
}
