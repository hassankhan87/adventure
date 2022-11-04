using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class QuestionDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public IEnumerable<ChoiceDto>? Choices { get; set; }
        //public Guid AdventureId { get; set; }
        //public AdventureDto Adventure { get; set; } = null!;
    }
}
