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

        public UnitOfWork(PolygDbContext context, IAuthUserRepository authUserRepository, ILanguageRepository languageRepository)
        {
            Context = context;
            AuthUserRepository = authUserRepository;
            LanguageRepository = languageRepository;
        }

        public IAuthUserRepository AuthUserRepository { get; }
        public ILanguageRepository LanguageRepository { get; }

        public async Task<int> SaveChangesAsync()
        {
            return await Context.SaveChangesAsync();
        }
    }
}
