using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Contract.Services.AuthUser
{
    public class AuthUserDto
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
