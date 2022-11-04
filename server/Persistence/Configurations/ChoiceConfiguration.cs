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
    internal class ChoiceConfiguration : IEntityTypeConfiguration<Choice>
    {
        public void Configure(EntityTypeBuilder<Choice> builder)
        {
            builder.Property(p => p.Title).HasMaxLength(256);
            //builder
            //    .HasOne(p => p.NextQuestion)
            //    .WithMany(p => p.Choices)
            //    .HasForeignKey(p => p.NextQuestionId);
        }
    }
}
