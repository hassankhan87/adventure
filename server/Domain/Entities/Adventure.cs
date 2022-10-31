using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Adventure
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid CreatorId { get; set; }
        public User Creator { get; set; } = null!;
        public ICollection<Question>? Questions { get; set; }
    }
}
