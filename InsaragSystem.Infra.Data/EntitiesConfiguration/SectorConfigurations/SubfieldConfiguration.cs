using InsaragSystem.Domain.Entities.Sector;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.Data.EntitiesConfiguration.SectorConfigurations
{
    public class SubfieldConfiguration : IEntityTypeConfiguration<Subfield>
    {
        public void Configure(EntityTypeBuilder<Subfield> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Code)
                   .IsRequired()
                   .HasColumnType("char(1)");

            builder.HasOne(s => s.Subdivision)
                   .WithMany(sd => sd.Subfields)
                   .HasForeignKey(s => s.SubdivisionId);
        }
    }
}
