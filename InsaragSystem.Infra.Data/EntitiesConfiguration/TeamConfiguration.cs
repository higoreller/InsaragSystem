using InsaragSystem.Domain.Entities.Team;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.Data.EntitiesConfiguration
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(t => t.Id);
            
            builder.HasOne(t => t.ContactDetails)
                .WithOne()
                .HasForeignKey<Team>("ContactDetailsId");

            builder.HasOne(t => t.SupportRequirements)
                .WithOne()
                .HasForeignKey<Team>("SupportRequirementsId");

            builder.HasOne(t => t.TeamDetails)
                .WithOne()
                .HasForeignKey<Team>("TeamDetailsId");

            builder.HasOne(t => t.Disaster)
                .WithMany(d => d.Teams)
                .HasForeignKey(t => t.DisasterId);

            builder.HasOne(t => t.AssignedSector)
                .WithMany()
                .HasForeignKey(t => t.AssignedSectorId)
                .IsRequired(false);
        }
    }
}
