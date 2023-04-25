using BusinessLayer.Services;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.DependencyInjection
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdventureWorks2019Context>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("AdventureWorks2019"));
            });

            services.AddScoped<IPeopleService, PeopleService>();

            return services;
        }
    }
}
