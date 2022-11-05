using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    internal sealed class AdventureRepository : IAdventureRepository
    {
        private readonly RepositoryDbContext _dbContext;
        public AdventureRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;
        public async Task<Adventure?> GetByIdAsync(Guid adventureId)
        {
            return await _dbContext.Adventures
                .Include(x => x.Questions)
                    .ThenInclude(x => x.Choices)
                .FirstOrDefaultAsync(x => x.Id == adventureId);
        }

        public void Insert(Adventure adventure)
        {
            _dbContext.Adventures.Add(adventure);
            foreach (var entityEntry in _dbContext.ChangeTracker.Entries<Question>())
            {
                if (entityEntry.State == EntityState.Added && entityEntry.Entity.AdventureId == Guid.Empty)
                {
                    entityEntry.Entity.AdventureId = adventure.Id;
                    entityEntry.Entity.Adventure = adventure;
                    Console.WriteLine($"Found {entityEntry.Metadata.Name} entity with ID {entityEntry.Property("AdventureId").CurrentValue}");
                }
            }
        }
    }
}
