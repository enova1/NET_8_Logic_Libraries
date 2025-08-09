using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleLibrary
{
    /// <summary>
    /// Provides extension methods for configuring services related to the ExampleLibrary.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddExampleLibrary(
            this IServiceCollection services,
            string? connectionString)
        {
            // Register the DAL here 
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(connectionString));

            // Dependency Injection here
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            services.AddScoped<IEmployee, Employee>();

            // Add logic layer services here too if you have them

            return services;
        }
    }
}