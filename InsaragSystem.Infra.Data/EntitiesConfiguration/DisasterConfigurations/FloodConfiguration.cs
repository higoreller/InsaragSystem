using InsaragSystem.Domain.Entities.Disaster;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.Data.EntitiesConfiguration.DisasterConfigurations
{
    public class FloodConfiguration : IEntityTypeConfiguration<Flood>
    {
        public void Configure(EntityTypeBuilder<Flood> builder)
        {
            builder.Property(f => f.FloodedArea).IsRequired();
        }
    }
}
