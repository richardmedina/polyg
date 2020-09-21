using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Contract.Services.AuthUser
{
    public class AuthToken
    {
        public string Token { get; set; }
        public long Expiration { get; set; }
    }
}
