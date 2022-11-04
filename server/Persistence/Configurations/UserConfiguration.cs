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
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(256);
            builder.HasData(new User { Id=Guid.Parse("37d741e2-eeb8-4f9c-983b-69b80c9078cd"), Name="Creator" });
        }
    }
}
