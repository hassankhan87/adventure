using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IUserService
    {
        Task<UserDto> GetByIdAsync(Guid userId);
        Task<UserDto> CreateAsync(UserForCreationDto userForCreationDto);
        Task<UserAdventureDto> CreateUserAdventureAsync(UserAdventureForCreationDto userAdventureForCreationDto);
        Task<AdventureAndUserAdventureDto> GetUserAdventureByIdAsync(Guid userAdventureId);
    }
}
