using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdventureController : ControllerBase
    {
        public AdventureController()
        {

        }
        [HttpGet(Name = "Get")]
        public async Task<IActionResult> Get()
        {
            var creator = new User { Name = "Hassan", Id = Guid.NewGuid() };
            var adventure = new Adventure()
            {
                Id = Guid.NewGuid(),
                Creator = creator,
                CreatorId = creator.Id,
                Name = "Test",
                Questions = new List<Question>()
                {
                    new Question() {
                        Id = Guid.NewGuid(),
                        Title = "DO I WANT A DOUGHUNT",
                        Choices = new List<Choice>()
                        {
                            new Choice() {
                                Id = Guid.NewGuid(),
                                Title = "NO",
                                NextQuestion = new Question()
                                {
                                    Id = Guid.NewGuid(),
                                    Title = "May be you want an apple?",
                                }
                            },
                            new Choice() {
                                Id = Guid.NewGuid(),
                                Title = "YES",
                                NextQuestion = new Question() 
                                {
                                    Id = Guid.NewGuid(),
                                    Title = "Do I deserve it?",
                                    Choices = new List<Choice>()
                                    {
                                        new Choice() {
                                            Id = Guid.NewGuid(),
                                            Title = "YES",
                                            NextQuestion = new Question()
                                            {
                                                Id = Guid.NewGuid(),
                                                Title = "Are you sure?",
                                                Choices = new List<Choice>()
                                                {
                                                    new Choice()
                                                    {
                                                        Id = Guid.NewGuid(),
                                                        Title = "Yes",
                                                        NextQuestion= new Question()
                                                        {
                                                            Title = "Get it."
                                                        }
                                                    },
                                                    new Choice()
                                                    {
                                                        Id = Guid.NewGuid(),
                                                        Title = "NO",
                                                        NextQuestion= new Question()
                                                        {
                                                            Title = "Do jumping jacks first."
                                                        }
                                                    }
                                                }
                                            }
                                        },
                                        new Choice() {
                                            Id = Guid.NewGuid(),
                                            Title = "NO",
                                            NextQuestion = new Question()
                                            {
                                                Id = Guid.NewGuid(),
                                                Title = "Is it a good doughunt?",
                                                Choices = new List<Choice>()
                                                {
                                                    new Choice()
                                                    {
                                                        Id = Guid.NewGuid(),
                                                        Title = "Yes",
                                                        NextQuestion= new Question()
                                                        {
                                                            Title = "What are you waiting for? Grab it now."
                                                        }
                                                    },
                                                    new Choice()
                                                    {
                                                        Id = Guid.NewGuid(),
                                                        Title = "NO",
                                                        NextQuestion= new Question()
                                                        {
                                                            Title = "Wait til you find a sinful, unforgettable doughunt."
                                                        }
                                                    }
                                                }
                                            }
                                        },
                                    }
                                }
                            }
                        }
                    }
                }
            };
            return Ok(await Task.FromResult(adventure));
        }
    }
}
