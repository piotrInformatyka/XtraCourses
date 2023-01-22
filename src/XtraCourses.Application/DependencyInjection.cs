using Microsoft.Extensions.DependencyInjection;
using XtraCourses.Application.Abstractions;
using XtraCourses.Application.Services;

namespace XtraCourses.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseService>();

            return services;
        }
    }
}
