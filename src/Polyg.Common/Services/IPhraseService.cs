using Polyg.Contract.Services;
using Polyg.Contract.Services.Phrase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Common.Services
{
    public interface IPhraseService
    {
        Task<ServiceResult<IEnumerable<PhraseDto>>> GetPhrases(int userId, int languageId);
        Task<ServiceResult<PhraseDto>> CreatePhrase(PhraseDto phrase);
    }
}
