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
    public class EarthquakeConfiguration : IEntityTypeConfiguration<Earthquake>
    {
        public void Configure(EntityTypeBuilder<Earthquake> builder)
        {
            builder.Property(e => e.Magnitude).IsRequired();
            builder.Property(e => e.Depth).IsRequired();
        }
    }
}
