using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Polyg.Infrastructure.Domain.Entities
{
    [Table("AuthUser", Schema = "Security")]
    public class AuthUserEntity
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
