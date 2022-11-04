using Domain.Repositories;
using Domain.Utilities;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAdventureService> _lazyAdventureService;
        private readonly Lazy<IUserService> _lazyUserService;
        public ServiceManager(IRepositoryManager repositoryManager, IUtilityManager utilityManager)
        {
            _lazyAdventureService = new Lazy<IAdventureService>(() => new AdventureService(repositoryManager, utilityManager));
            _lazyUserService = new Lazy<IUserService>(() => new UserService(repositoryManager, utilityManager));
        }
        public IAdventureService AdventureService => _lazyAdventureService.Value;

        public IUserService UserService => _lazyUserService.Value;
    }
}
