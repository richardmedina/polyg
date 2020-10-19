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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthUserEntity>().HasData(
                new AuthUserEntity
                {
                    Id = 1,
                    UserName = "richard",
                    Password = "medina"
                },
                new AuthUserEntity
                {
                    Id = 2,
                    UserName = "anonymous",
                    Password = "anonymous"
                }
            );

            modelBuilder.Entity<LanguageEntity>().HasData(
                new LanguageEntity
                {
                    Id = 1,
                    CultureName = "en-US",
                    Name = "English (US)",
                    Description = "English (United States)"
                },
                new LanguageEntity
                {
                    Id = 2,
                    CultureName = "es-MX",
                    Name = "Spanish (MX)",
                    Description = "Spanish (Mexico)"
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
