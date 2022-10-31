using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Choice
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Guid QuestionId { get; set; }
        public Question Question { get; set; } = null!;
        public Guid? NextQuestionId { get; set; }
        public Question? NextQuestion { get; set; }
    }
}
