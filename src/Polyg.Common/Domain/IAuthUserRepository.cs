using Polyg.Contract.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Common.Domain
{
    public interface IAuthUserRepository
    {
        Task<AuthUser> GetByIdAsync(long id);
        Task<AuthUser> GetByUserNameAsync(string userName);
        Task<AuthUser> Add(AuthUser authUser);
    }
}
