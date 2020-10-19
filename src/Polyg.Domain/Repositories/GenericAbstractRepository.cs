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
        protected IMapper Mapper { get; }
        public GenericAbstractRepository(PolygDbContext context, IMapper mapper) : base(context)
        {
            Mapper = mapper;
        }

        public async Task<TDestType> AddAsync(TDestType destType)
        {
            var entity = Mapper.Map<TEntity>(destType);

            var dbSet = Context.Set<TEntity>();
            var entry = await dbSet.AddAsync(entity);

            return Mapper.Map<TDestType>(entry.Entity);
        }
    }
}
