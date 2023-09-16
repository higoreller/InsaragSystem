﻿using InsaragSystem.Domain.Entities.Sector;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.Data.EntitiesConfiguration
{
    public class SectorConfiguration : IEntityTypeConfiguration<Sector>
    {
        public void Configure(EntityTypeBuilder<Sector> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Code).IsRequired();

            builder.HasMany(s => s.Subdivisions)
                   .WithOne(sd => sd.Sector)
                   .HasForeignKey(sd => sd.SectorId);

            builder.HasMany(s => s.AssignedTeams)
                   .WithOne(t => t.AssignedSector)
                   .HasForeignKey(t => t.AssignedSectorId);
            
            builder.HasOne(t => t.Disaster)
                .WithMany(d => d.Sectors)
                .HasForeignKey(t => t.DisasterId);
        }
    }

}
