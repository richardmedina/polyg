using Polyg.Contract.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Abstract.Domain
{
    public interface IAuthUserRepository
    {
        AuthUser GetById(long id);
        AuthUser GetByUserName(string userName);
    }
}
