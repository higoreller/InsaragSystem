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
    public class WildfireConfiguration : IEntityTypeConfiguration<Wildfire>
    {
        public void Configure(EntityTypeBuilder<Wildfire> builder)
        {
            builder.Property(w => w.BurnedArea).IsRequired();
        }
    }
}
