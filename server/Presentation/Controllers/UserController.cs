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
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public UserController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpGet("{userId:guid}")]
        public async Task<IActionResult> GetUserById(Guid userId)
        {
            var adventure = await _serviceManager.UserService.GetByIdAsync(userId);
            return Ok(adventure);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserForCreationDto userForCreationDto)
        {
            var userDto = await _serviceManager.UserService.CreateAsync(userForCreationDto);
            return CreatedAtAction(nameof(GetUserById), new { userId = userDto.Id }, userDto);
        }

        [HttpGet("get/adventure/{userAdventureId:guid}")]
        public async Task<IActionResult> GetUserAdventureById(Guid userAdventureId)
        {
            var userAdventure = await _serviceManager.UserService.GetUserAdventureByIdAsync(userAdventureId);
            return Ok(userAdventure);
        }
        [HttpPost("create/adventure")]
        public async Task<IActionResult> CreateAdventure([FromBody] UserAdventureForCreationDto userAdventureForCreationDto)
        {
            var userAdventureDto = await _serviceManager.UserService.CreateUserAdventureAsync(userAdventureForCreationDto);
            return CreatedAtAction(nameof(GetUserAdventureById), new { userAdventureId = userAdventureDto.Id }, userAdventureDto);
        }
    }
}
