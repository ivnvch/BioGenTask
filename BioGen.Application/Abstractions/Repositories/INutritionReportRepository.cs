using System.Threading.Tasks;
using BioGen.Application.Abstractions.Repositories;
using BioGen.Domain.Entity;

namespace BioGen.Application.Interfaces.Repositories
{
    public interface INutritionReportRepository: IBaseRepository<NutritionReport>
    {
        Task<NutritionReport> GetLatestAsync();
    }
}
