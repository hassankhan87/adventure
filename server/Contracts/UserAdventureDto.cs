using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class UserAdventureDto
    {
        public Guid Id { get; set; }
        public DateTime Session { get; set; }
        public Guid AdventureId { get; set; }
        public AdventureDto Adventure { get; set; } = null!;
        public Guid UserId { get; set; }
        public UserDto User { get; set; } = null!;
    }
}
