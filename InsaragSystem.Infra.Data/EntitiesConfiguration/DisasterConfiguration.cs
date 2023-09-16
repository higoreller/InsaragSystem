using InsaragSystem.Domain.Entities.Disaster;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.Data.EntitiesConfiguration
{
    public class DisasterConfiguration : IEntityTypeConfiguration<DisasterBase>
    {
        public void Configure(EntityTypeBuilder<DisasterBase> builder)
        {
            builder.HasKey(t => t.DisasterId);

            // Basic properties
            builder.Property(t => t.Name).IsRequired().HasMaxLength(250);
            builder.Property(t => t.Description).HasMaxLength(2000);
            builder.Property(t => t.InitiatingEvent).HasMaxLength(250);
            builder.Property(t => t.IsActive);
            builder.Property(t => t.ImpactLevel).HasConversion<string>();
            builder.Property(t => t.DateStarted);
            builder.Property(t => t.DateEnded);
            builder.Property(t => t.EstimatedAffectedPopulation);
            builder.Property(t => t.EstimatedCasualties);
            builder.Property(t => t.EstimatedDisplacedPersons);
            builder.Property(t => t.EstimatedEconomicLoss);

            // Propriedade de valor Epicenter
            builder.OwnsOne(t => t.Epicenter);

            // Listas de string
            // Precisamos criar entidades separadas para elas, pois o EF Core não suporta diretamente List<string>
            builder.OwnsMany(t => t.AffectedAreas, a =>
            {
                a.WithOwner().HasForeignKey("DisasterId");
                a.Property<string>("Area").IsRequired();
                a.HasKey("DisasterId", "Area");
            });

            builder.OwnsMany(t => t.ReliefResources, rr =>
            {
                rr.WithOwner().HasForeignKey("DisasterId");
                rr.Property<string>("Resource").IsRequired();
                rr.HasKey("DisasterId", "Resource");
            });

            builder.OwnsMany(t => t.ImmediateNeeds, rr =>
            {
                rr.WithOwner().HasForeignKey("DisasterId");
                rr.Property<string>("Need").IsRequired();
                rr.HasKey("DisasterId", "Need");
            });

            // Relações
            builder.HasMany(t => t.Teams).WithOne().HasForeignKey(t => t.DisasterId);
            builder.HasMany(t => t.Sectors).WithOne().HasForeignKey(s => s.DisasterId);

            // Configuração para TPH
            builder.HasDiscriminator<DisasterType>("Type")
                .HasValue<Earthquake>(DisasterType.Earthquake)
                .HasValue<Flood>(DisasterType.Flood)
                .HasValue<Wildfire>(DisasterType.Wildfire);
        }
    }
}
