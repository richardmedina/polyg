using AutoMapper;
using Polyg.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Domain.Repositories
{
    public class GenericAbstractRepository<TEntity, TDestType> : AbstractRepository
        where TEntity : class
        where TDestType : class
    {
        private readonly IMapper _mapper;
        public GenericAbstractRepository(PolygDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<TDestType> AddAsync (TDestType destType)
        {
            var entity = _mapper.Map<TEntity>(destType);

            var addedEntity = await base.AddAsync(entity);

            return _mapper.Map<TDestType>(addedEntity);
        }
    }
}
