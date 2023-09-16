using InsaragSystem.Domain.Entities.Disaster;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.Data.EntitiesConfiguration.DisasterConfigurations
{
    public class DisasterConfiguration : IEntityTypeConfiguration<DisasterBase>
    {
        public void Configure(EntityTypeBuilder<DisasterBase> builder)
        {
            builder.HasKey(t => t.DisasterId);

            // Basic properties
            builder.Property(p => p.Name).IsRequired().HasMaxLength(250);
            builder.Property(p => p.Description).HasMaxLength(2000);
            builder.Property(p => p.InitiatingEvent).HasMaxLength(250);
            builder.Property(p => p.IsActive);
            builder.Property(p => p.ImpactLevel).HasConversion<string>();
            builder.Property(p => p.DateStarted);
            builder.Property(p => p.DateEnded);
            builder.Property(p => p.EstimatedAffectedPopulation);
            builder.Property(p => p.EstimatedCasualties);
            builder.Property(p => p.EstimatedDisplacedPersons);
            builder.Property(p => p.EstimatedEconomicLoss);
                      

            // Relations
            builder.HasMany(e => e.Teams).WithOne().HasForeignKey(e => e.DisasterId);
            builder.HasMany(e => e.Sectors).WithOne().HasForeignKey(e => e.DisasterId);
        }
    }
}
