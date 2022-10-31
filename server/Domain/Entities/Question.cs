using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public ICollection<Choice>? Choices { get; set; }
        public Adventure Adventure { get; set; }
    }
}
