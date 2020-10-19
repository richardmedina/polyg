using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Contract.Domain
{
    public class Phrase
    {
        public long Id { get; set; }
        public string FromText { get; set; }
        public string ToText { get; set; }

        public long UserId { get; set; }
        public long LanguageFromId { get; set; }
        public long LanguageToId { get; set; }
    }
}
