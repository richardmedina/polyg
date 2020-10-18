using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata;
using Polyg.Common.Domain;
using Polyg.Common.Services;
using Polyg.Contract.Services;
using Polyg.Contract.Services.Language;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Services
{
    public class LanguageService : AbstractService, ILanguageService
    {
        private readonly IMapper _mapper;
        public LanguageService(IUnitOfWork unitOfWork, IMapper mapper) :base(unitOfWork)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResult<IEnumerable<LanguageDto>>> GetAllAsync()
        {
            var result = _mapper.Map<IEnumerable<LanguageDto>>(
                await UnitOfWork.LanguageRepository.GetLanguages()
            );

            return ResultFromSuccess(result);
        }

        public async Task<ServiceResult<LanguageDto>> GetByCultureNameAsync(string cultureName)
        {
            if (string.IsNullOrWhiteSpace(cultureName))
            {
                return ResultFromValidationError<LanguageDto>("Culture Name is invalid");
            }

            var result = _mapper.Map<LanguageDto>(await UnitOfWork.LanguageRepository.GetByCultureName(cultureName));

            return result == null
                ? ResultFromError("Culture name not found", result)
                : ResultFromSuccess(result);
        }

        public async Task<ServiceResult<LanguageDto>> GetByIdAsync(long id)
        {
            if (id <= 0)
            {
                return ResultFromValidationError<LanguageDto>("Culture Id is invalid");
            }

            var result = _mapper.Map<LanguageDto>(await UnitOfWork.LanguageRepository.GetById(id));

            return result == null
                ? ResultFromError("Culture name not found", result)
                : ResultFromSuccess(result);
        }
    }
}
