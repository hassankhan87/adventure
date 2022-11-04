using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Choice
    {
        public Choice()
        {
            
        }
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Guid QuestionId { get; set; }
        public Question Question { get; set; } = null!;
        public Guid? NextQuestionId { get; set; }
        public Question? NextQuestion { get; set; }

        //public void ChoiceNextQuestionExtension(this Choice choice)
        //{
        //    if (choice.NextQuestion is not null)
        //    {
        //        choice.NextQuestion.Adventure = choice.Question.Adventure;
        //        choice.NextQuestion.AdventureId = choice.Question.AdventureId;
        //    }
        //}
    }
}
