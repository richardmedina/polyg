using Polyg.Abstract.Domain;
using Polyg.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Domain
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PolygDbContext Context;

        public UnitOfWork(PolygDbContext context, IAuthUserRepository authUserRepository)
        {
            Context = context;
            AuthUserRepository = authUserRepository;
        }

        public IAuthUserRepository AuthUserRepository { get; }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }
    }
}
