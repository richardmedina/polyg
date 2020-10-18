using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Contract.Services.Language
{
    public class LanguageDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CultureName { get; set; }
    }
}
