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
    internal sealed class UserRepository: IUserRepository
    {
        private readonly RepositoryDbContext _dbContext;
        public UserRepository(RepositoryDbContext dbContext) => _dbContext = dbContext;

        public void AddUserAdventure(UserAdventure userAdventure)
        {
            _dbContext.UserAdventures.Add(userAdventure);
        }

        public async Task<User?> GetByIdAsync(Guid userId)
        {
            return await _dbContext.Users.FindAsync(userId);
        }

        public async Task<UserAdventure?> GetUserAdventureByIdAsync(Guid userAdventureId)
        {
            return await _dbContext.UserAdventures
                .Include(x => x.UserChoices)
                .FirstOrDefaultAsync(x=> x.Id== userAdventureId);
        }

        public void Insert(User user)
        {
            _dbContext.Users.Add(user);            
        }
    }
}
