using BioGen.Application.Abstractions.Services;
using BioGen.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BioGen.Application.Extensions
{
    public static class RegisterApplicationExtensions
    {
        public static void AddApplicationExtensions(this IServiceCollection services)
        {
            ConfigurationServices(services);
        }

        private static void ConfigurationServices(this IServiceCollection services)
        {
            services.AddScoped<INutritionReportService, NutritionReportService>();
        }
    }
}