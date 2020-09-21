using Polyg.Contract.Services.AuthUser;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Common.Infrastructure.Jwt
{
    public interface IJwtHandler
    {
        AuthToken CreateToken(string userName);
    }
}
