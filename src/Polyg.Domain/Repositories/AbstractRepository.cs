using Polyg.Contract.Domain;
using Polyg.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Polyg.Domain.Repositories
{
    public abstract class AbstractRepository
    {
        public PolygDbContext Context { get; set; }
        public AbstractRepository(PolygDbContext context)
        {
            Context = context;
        }

        public async Task<TEntity> AddAsync<TEntity>(TEntity entity) where TEntity : class
        {
            var dbSet = Context.Set<TEntity>();
            var entry = await dbSet.AddAsync(entity);

            return entry.Entity;
        }

    }
}
