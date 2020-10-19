using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Polyg.Infrastructure.Domain.Entities
{
    [Table("Phrases", Schema = "Business")]
    public class PhraseEntity
    {
        public long Id { get; set; }
        public string FromText { get; set; }
        public string ToText { get; set; }

        /* Navigation properties */
        public long? UserId { get; set; }
        public AuthUserEntity User { get; set; }
        public long? LanguageFromId { get; set; }
        public LanguageEntity LanguageFrom { get; set; }
        public long? LanguageToId { get; set; }
        public LanguageEntity LanguageTo { get; set; }
    }
}
