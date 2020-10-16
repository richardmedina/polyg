using Microsoft.EntityFrameworkCore;
using Polyg.Infrastructure.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Infrastructure.Domain
{
    public class PolygDbContext : DbContext
    {
        public DbSet<AuthUserEntity> AuthUsers { get; set; }
        public DbSet<LanguageEntity> Languages { get; set; }

        public PolygDbContext(DbContextOptions<PolygDbContext> options) : base(options)
        {
        }
    }
}
