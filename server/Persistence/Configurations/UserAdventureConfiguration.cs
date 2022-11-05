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
    internal class UserAdventureConfiguration : IEntityTypeConfiguration<UserAdventure>
    {
        public void Configure(EntityTypeBuilder<UserAdventure> builder)
        {
            // No need for now
        }
    }
}
