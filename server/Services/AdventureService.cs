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
    internal sealed class AdventureService: IAdventureService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public AdventureService(IRepositoryManager repositoryManager, IUtilityManager utilityManager)
        {
            _repositoryManager = repositoryManager;
            _mapper = utilityManager.Mapper;
        }

        public async Task<AdventureDto> CreateAsync(AdventureForCreationDto adventureForCreationDto)
        {
            var adventure = _mapper.Map<Adventure>(adventureForCreationDto);
            _repositoryManager.AdventureRepository.Insert(adventure);
            
            await _repositoryManager.UnitOfWork.SaveChangesAsync();
            return _mapper.Map<AdventureDto>(adventure);
        }

        public async Task<AdventureDto> GetByIdAsync(Guid adventureId)
        {
            var adventure = await _repositoryManager.AdventureRepository.GetByIdAsync(adventureId);
            if (adventure is null)
            {
                throw new AdventureNotFoundException(adventureId);
            }
            var adventureDto = _mapper.Map<AdventureDto>(adventure);
            return adventureDto;
        }
    }
}
