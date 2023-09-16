using InsaragSystem.Domain.Interfaces;
using InsaragSystem.Domain.Interfaces.DisasterInterfaces;
using InsaragSystem.Domain.Interfaces.SectorInterfaces;
using InsaragSystem.Infra.Data.Context;
using InsaragSystem.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            services.AddScoped<IEarthquakeRepository, EarthquakeRepository>();
            services.AddScoped<IFloodRepository, FloodRepository>();
            services.AddScoped<IWildfireRepository, WildfireRepository>();
            services.AddScoped<ISectorRepository, SectorRepository>();
            services.AddScoped<ISubdivisionRepository, SubdivisionRepository>();
            services.AddScoped<ISubfieldRepository, SubfieldRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();

            return services;
        }
    }
}
