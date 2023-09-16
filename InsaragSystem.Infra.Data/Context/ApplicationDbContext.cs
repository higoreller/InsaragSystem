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

        public DbSet<Earthquake> Earthquakes { get; set; }
        public DbSet<Flood> Floods { get; set; }
        public DbSet<Wildfire> Wildfires { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
        public DbSet<Subfield> Subfields { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

    }
}
