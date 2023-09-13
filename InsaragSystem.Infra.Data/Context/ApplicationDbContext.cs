using InsaragSystem.Domain.Entities.Disaster;
using InsaragSystem.Domain.Entities.Sector;
using InsaragSystem.Domain.Entities.Team;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<DisasterBase> Disasters { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
        public DbSet<Subfield> Subfields { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<DisasterBase>()
                .HasDiscriminator<DisasterType>("Type")
                .HasValue<Wildfire>(DisasterType.Wildfire)
                .HasValue<Earthquake>(DisasterType.Earthquake)
                .HasValue<Flood>(DisasterType.Flood);

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

    }
}
