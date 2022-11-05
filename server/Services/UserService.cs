using AutoMapper;
using Contracts;
using Domain.Entities;
using Domain.Exceptions;
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

        public async Task<UserDto> CreateAsync(UserForCreationDto userForCreationDto)
        {
            var user = _mapper.Map<User>(userForCreationDto);
            _repositoryManager.UserRepository.Insert(user);

            await _repositoryManager.UnitOfWork.SaveChangesAsync();
            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> GetByIdAsync(Guid userId)
        {
            var user = await _repositoryManager.UserRepository.GetByIdAsync(userId);
            if (user is null)
            {
                throw new UserNotFoundException(userId);
            }
            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
