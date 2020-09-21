using Polyg.Contract.Services.AuthUser;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Common.Services
{
    public interface IAuthUserService
    {
        AuthUserDto AuthenticateUser(string useName, string password);
    }
}
