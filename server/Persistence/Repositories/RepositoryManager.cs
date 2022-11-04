using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IAdventureRepository> _lazyAdventureRepository;
        private readonly Lazy<IUserRepository> _lazyUserRepository;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

        public RepositoryManager(RepositoryDbContext dbContext)
        {
            _lazyAdventureRepository = new Lazy<IAdventureRepository>(() => new AdventureRepository(dbContext));
            _lazyUserRepository = new Lazy<IUserRepository>(() => new UserRepository(dbContext));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
        }

        
        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;

        public IAdventureRepository AdventureRepository => _lazyAdventureRepository.Value;

        public IUserRepository UserRepository => _lazyUserRepository.Value;
    }
}
