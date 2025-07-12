using System.Threading.Tasks;

namespace BioGen.Application.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        INutrientRepository Nutrients { get; }
        ISupplementRepository Supplements { get; }
        INutritionReportRepository NutritionReports { get; }
        Task<int> SaveAsync();
    }
}