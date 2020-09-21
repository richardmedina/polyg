using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Common.Domain
{
    public interface IUnitOfWork
    {
        IAuthUserRepository AuthUserRepository { get; }
        int SaveChanges();
    }
}
