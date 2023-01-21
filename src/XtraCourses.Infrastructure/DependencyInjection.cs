using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using XtraCourses.Infrastructure.Persistence;
using XtraCourses.Infrastructure.services;

namespace XtraCourses.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<XtraDataClient>();

            //EF
            services.AddHostedService<DatabaseInitializer>();
            services.AddDbContext<DataContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("SqliteConnection")));

            return services;
        }
    }
}
