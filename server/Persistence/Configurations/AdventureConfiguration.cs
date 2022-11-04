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
    public class AdventureConfiguration : IEntityTypeConfiguration<Adventure>
    {
        public void Configure(EntityTypeBuilder<Adventure> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(256);            
        }
    }
}
