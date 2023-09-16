using InsaragSystem.Domain.Entities.Sector;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.Data.EntitiesConfiguration.SectorConfigurations
{
    public class SubdivisionConfiguration : IEntityTypeConfiguration<Subdivision>
    {
        public void Configure(EntityTypeBuilder<Subdivision> builder)
        {
            builder.HasKey(sd => sd.Id);

            builder.Property(sd => sd.Number).IsRequired();

            builder.HasMany(sd => sd.Subfields)
                   .WithOne(s => s.Subdivision)
                   .HasForeignKey(s => s.SubdivisionId);

        }
    }
}
