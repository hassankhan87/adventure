using Domain.Entities;
using Domain.Repositories;
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

        public Task<User> GetByIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
