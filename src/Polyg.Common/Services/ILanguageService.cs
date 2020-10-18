using Polyg.Contract.Domain;
using Polyg.Contract.Services;
using Polyg.Contract.Services.Language;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Common.Services
{
    public interface ILanguageService
    {
        Task<ServiceResult<IEnumerable<LanguageDto>>> GetAllAsync();
        Task<ServiceResult<LanguageDto>> GetByIdAsync(long id);
        Task<ServiceResult<LanguageDto>> GetByCultureNameAsync(string cultureName);
    }
}
