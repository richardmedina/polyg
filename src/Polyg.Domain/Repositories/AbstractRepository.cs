using Polyg.Contract.Domain;
using Polyg.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Domain.Repositories
{
    public abstract class AbstractRepository
    {
        public PolygDbContext Context { get; set; }
        public AbstractRepository(PolygDbContext context)
        {
            Context = context;
        }

        
    }
}
