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
        private readonly IAuthUserRepository _authUserRepository;
        public UnitOfWork(PolygDbContext context, IAuthUserRepository authUserRepository)
        {
            Context = context;
            _authUserRepository = authUserRepository;
        }

        public IAuthUserRepository GetAuthUserRepository()
        {
            return _authUserRepository;
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }
    }
}
