using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Polyg.Common.Domain;
using Polyg.Contract.Domain;
using Polyg.Infrastructure.Domain;
using Polyg.Infrastructure.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Domain.Repositories
{
    public class LanguageRepository : AbstractRepository, ILanguageRepository
    {
        private readonly IMapper _mapper;

        public LanguageRepository(PolygDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<Language> GetByCultureName(string cultureName)
        {
            return _mapper.Map<Language>(
                await Context.Languages.SingleOrDefaultAsync(language => language.CultureName == cultureName)
            );
        }

        public async Task<Language> GetById(long id)
        {
            return _mapper.Map<Language>(
                await Context.Languages.SingleOrDefaultAsync(language => language.Id == id)
            );
        }

        public async Task<IEnumerable<Language>> GetLanguages()
        {
            return _mapper
                .Map<IEnumerable<Language>>(await Context.Languages.ToListAsync());
        }
    }
}
