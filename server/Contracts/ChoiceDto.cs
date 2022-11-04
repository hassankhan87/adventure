using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class ChoiceDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Guid QuestionId { get; set; }
        public QuestionDto Question { get; set; } = null!;
        public Guid? NextQuestionId { get; set; }
        public QuestionDto? NextQuestion { get; set; }
    }
}
