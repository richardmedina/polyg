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
    public class PhraseRepository : GenericAbstractRepository<PhraseEntity, Phrase>, IPhraseRepository
    {
        public PhraseRepository(PolygDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<IEnumerable<Phrase>> GetPhrasesAsync(long userId, long languageId)
        {
            var phrases = await Context.Phrases
                .Where(phrase => phrase.UserId == userId && phrase.LanguageFromId == languageId)
                .ToListAsync();

            return Mapper.Map<IEnumerable<Phrase>>(phrases);
        }
    }
}
