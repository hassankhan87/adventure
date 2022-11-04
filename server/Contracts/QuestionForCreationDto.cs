using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class QuestionForCreationDto
    {
        public string Title { get; set; } = string.Empty;
        public ICollection<ChoiceForCreationDto>? Choices { get; set; }        
    }
}
