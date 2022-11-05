using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class UserAdventureForCreationDto
    {
        public DateTime Session { get; set; }
        public Guid AdventureId { get; set; }
        public Guid UserId { get; set; }
        public ICollection<UserChoiceForCreationDto>? UserChoices { get; set; }
    }

    public class UserChoiceForCreationDto
    {
        public Guid ChoiceId { get; set; }
    }
}
