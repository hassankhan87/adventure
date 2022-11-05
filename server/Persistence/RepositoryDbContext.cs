using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class RepositoryDbContext: DbContext
    {
        public RepositoryDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Adventure> Adventures { get; set; } = null!;
        public DbSet<UserAdventure> UserAdventures { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RepositoryDbContext).Assembly);
        }
    }
}
