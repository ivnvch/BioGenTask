using System.Threading.Tasks;

namespace BioGen.Application.Interfaces.Repositories
{
    public interface INutritionReportRepository
    {
        Task<NutritionReport?> GetLatestAsync();
        Task SaveAsync(NutritionReport report);
    }
}