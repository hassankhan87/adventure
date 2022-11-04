using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class AdventureForCreationDto
    {
        public string Name { get; set; } = string.Empty;
        public Guid CreatorId { get; set; }
        public ICollection<QuestionForCreationDto>? Questions { get; set; }
    }
}
