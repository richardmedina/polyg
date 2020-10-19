using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Common.Domain
{
    public interface IUnitOfWork
    {
        IAuthUserRepository AuthUserRepository { get; }
        ILanguageRepository LanguageRepository { get; }
        IPhraseRepository PhraseRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
