using Contracts;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/adventure")]
    public class AdventureController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public AdventureController(IServiceManager serviceManager) => _serviceManager = serviceManager;
        [HttpGet("{adventureId:guid}")]
        public async Task<IActionResult> GetAdventureById(Guid adventureId)
        {
            var adventure = await _serviceManager.AdventureService.GetByIdAsync(adventureId);
            return Ok(adventure);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdventure([FromBody] AdventureForCreationDto adventureForCreationDto)
        {
            var adventureDto = await _serviceManager.AdventureService.CreateAsync(adventureForCreationDto);
            return CreatedAtAction(nameof(GetAdventureById), new { adventureId = adventureDto.Id }, adventureDto);
        }
    }
}
