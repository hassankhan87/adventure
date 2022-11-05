using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(Guid userId);
        void Insert(User user);
        void AddUserAdventure(UserAdventure userAdventure);
        Task<UserAdventure?> GetUserAdventureByIdAsync(Guid userAdventureId);
    }
}
