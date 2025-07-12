using BioGen.Application.Abstractions.Repositories;
using BioGen.Application.Interfaces.Repositories;
using BioGen.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BioGen.Persistence.Extensions
{
    public static class RegisterDbExtensions
    {
        public static void AddDalExtensions(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();
            services.RegisterRepository();
        }


        private static void RegisterRepository(this IServiceCollection services)
        {
            services.AddScoped<INutritionReportRepository, NutritionReportRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}