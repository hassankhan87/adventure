using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
    internal class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.Property(p => p.Title).HasMaxLength(256);

            
            // No navigation property in Question for Choices pointing
            // to this as NextQuestion.
            // It would also be possible to define such a property and mention it
            // in HasMany
            builder.HasMany<Choice>()
                .WithOne(x => x.NextQuestion)
                .HasForeignKey(x => x.NextQuestionId)
                // If next question is deleted, only disconnect referencing Choices
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
