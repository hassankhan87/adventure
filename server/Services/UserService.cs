using AutoMapper;
using Contracts;
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
    internal sealed class UserService: IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public UserService(IRepositoryManager repositoryManager, IUtilityManager utilityManager)
        {
            _repositoryManager = repositoryManager;
            _mapper = utilityManager.Mapper;
        }

        public Task<UserDto> CreateAsync(UserForCreationDto userForCreationDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetByIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
