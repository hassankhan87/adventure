using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class ChoiceForCreationDto
    {
        public string Title { get; set; } = string.Empty;
        public QuestionForCreationDto? NextQuestion { get; set; }
    }
}
