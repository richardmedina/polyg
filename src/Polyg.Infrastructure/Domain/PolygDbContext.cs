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

            base.OnModelCreating(modelBuilder);
        }
    }
}
