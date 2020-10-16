using Polyg.Common.Domain;
using Polyg.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<int> SaveChangesAsync()
        {
            return await Context.SaveChangesAsync();
        }
    }
}
