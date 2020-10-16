using Polyg.Contract.Services.AuthUser;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Common.Services
{
    public interface IAuthUserService
    {
        Task<AuthToken> AuthenticateUserAsync(string useName, string password);
    }
}
