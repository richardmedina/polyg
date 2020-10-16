using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Polyg.Infrastructure.Domain.Entities
{
    [Table("Languages", Schema = "Business")]
    public class LanguageEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CultureName { get; set; }
    }
}
