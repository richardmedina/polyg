using Polyg.Contract.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Common.Domain
{
    public interface ILanguageRepository
    {
        Task<IEnumerable<Language>> GetLanguages();
        Task<Language> GetById(long id);
        Task<Language> GetByCultureName(string cultureName);
    }
}
