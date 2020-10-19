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

        public UnitOfWork(PolygDbContext context,
            IAuthUserRepository authUserRepository,
            ILanguageRepository languageRepository,
            IPhraseRepository phraseRepository)
        {
            Context = context;
            AuthUserRepository = authUserRepository;
            LanguageRepository = languageRepository;
            PhraseRepository = phraseRepository;
        }

        public IAuthUserRepository AuthUserRepository { get; }
        public ILanguageRepository LanguageRepository { get; }
        public IPhraseRepository PhraseRepository { get; }

        public async Task<int> SaveChangesAsync()
        {
            return await Context.SaveChangesAsync();
        }
    }
}
