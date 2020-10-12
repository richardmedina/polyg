using AutoMapper;
using Polyg.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Text;

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

        public TDestType Add (TDestType destType)
        {
            var entity = _mapper.Map<TEntity>(destType);

            var dbSet = Context.Set<TEntity>();
            var entry = dbSet.Add(entity);

            return _mapper.Map<TDestType>(entry.Entity);
        }
    }
}
