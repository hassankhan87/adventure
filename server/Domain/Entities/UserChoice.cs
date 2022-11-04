using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserChoice
    {
        public int Id { get; set; }
        public Guid UserAdventureId { get; set; }
        public UserAdventure UserAdventure { get; set; } = null!;
        public Guid ChoiceId { get; set; }
        public Choice Choice { get; set; } = null!;
    }
}
