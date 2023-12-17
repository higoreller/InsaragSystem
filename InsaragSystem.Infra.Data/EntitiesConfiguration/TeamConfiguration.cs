using InsaragSystem.Domain.Entities.Disaster;
using InsaragSystem.Domain.Entities.Sector;
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

            builder.OwnsOne(t => t.ContactDetails);

            builder.OwnsOne(t => t.SupportRequirements);

            builder.OwnsOne(t => t.TeamDetails);

            
            builder.HasOne<DisasterBase>() 
                .WithMany()
                .HasForeignKey(t => t.DisasterId);

            builder.HasOne<Sector>()
                .WithMany()
                .HasForeignKey(t => t.AssignedSectorId)
                .IsRequired(false);

        }
    }
}
