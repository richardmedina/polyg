using Microsoft.EntityFrameworkCore;
using Polyg.Contract.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Infrastructure.Domain
{
    public class PolygDbContext : DbContext
    {
        public DbSet<AuthUser> AuthUsers { get; set; }

        public PolygDbContext(DbContextOptions<PolygDbContext> options) : base(options)
        {
        }
    }
}
