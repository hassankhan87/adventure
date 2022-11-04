using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserAdventure
    {
        public Guid Id { get; set; }
        public DateTime Session { get; set; }
        public Guid AdventureId { get; set; }
        public Adventure Adventure { get; set; } = null!;
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
