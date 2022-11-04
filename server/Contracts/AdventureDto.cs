using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class AdventureDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid CreatorId { get; set; }
        public UserDto Creator { get; set; } = null!;
        public IEnumerable<QuestionDto>? Questions { get; set; }
    }
}
