using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class UserChoiceDto
    {
        public int Id { get; set; }
        public Guid UserAdventureId { get; set; }
        public UserAdventureDto UserAdventure { get; set; } = null!;
        public Guid ChoiceId { get; set; }
        public ChoiceDto Choice { get; set; } = null!;
    }
}
