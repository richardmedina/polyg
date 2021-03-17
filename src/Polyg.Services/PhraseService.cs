using AutoMapper;
using Polyg.Common.Domain;
using Polyg.Common.Services;
using Polyg.Contract.Domain;
using Polyg.Contract.Services;
using Polyg.Contract.Services.Phrase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Services
{
    public class PhraseService : AbstractService, IPhraseService
    {
        private readonly IMapper _mapper;
        public PhraseService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResult<PhraseDto>> CreatePhraseAsync(PhraseDto phrase)
        {
            if (string.IsNullOrWhiteSpace(phrase.FromText) || phrase.LanguageFromId < 1 || phrase.LanguageToId < 1)
            {
                return ResultFromValidationError<PhraseDto>("Please verify phrase data");
            }

            var addedPhrase = await UnitOfWork
                .PhraseRepository
                    .AddAsync(_mapper.Map<Phrase>(phrase));

            return ResultFromSuccess(_mapper.Map<PhraseDto>(addedPhrase));
        }

        public async Task<ServiceResult<IEnumerable<PhraseDto>>> GetPhrasesAsync(long userId, long languageId)
        {
            if (userId < 1 || languageId < 1)
            {
                return ResultFromValidationError<IEnumerable<PhraseDto>>("Invalid Parameters");
            }

            var phrases = await UnitOfWork
                .PhraseRepository
                .GetPhrasesAsync(userId, languageId);

            return ResultFromSuccess(_mapper.Map<IEnumerable<PhraseDto>>(phrases));
        }
    }
}
