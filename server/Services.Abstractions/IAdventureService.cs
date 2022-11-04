using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IAdventureService
    {
        Task<AdventureDto> GetByIdAsync(Guid adventureId);
        Task<AdventureDto> CreateAsync(AdventureForCreationDto adventureForCreationDto);
    }
}
