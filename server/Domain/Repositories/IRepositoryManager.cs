using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        IAdventureRepository AdventureRepository { get; }

        IUserRepository UserRepository { get; }

        IUnitOfWork UnitOfWork { get; }
    }
}
