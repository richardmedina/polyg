using Polyg.Contract.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Common.Domain
{
    public interface IPhraseRepository
    {
        Task<IEnumerable<Phrase>> GetPhrasesAsync(long userId, long languageId);
        Task<Phrase> AddAsync(Phrase phrase);
    }
}
