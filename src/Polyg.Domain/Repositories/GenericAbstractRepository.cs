using Polyg.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Domain.Repositories
{
    public class GenericAbstractRepository<TEntity> : AbstractRepository where TEntity : class
    {
        public GenericAbstractRepository(PolygDbContext context) : base(context)
        {
        }

        public void Add (TEntity entity)
        {
            var dbSet = Context.Set<TEntity>();
            dbSet.Add(entity);
        }
    }
}
