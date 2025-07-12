using System.Threading.Tasks;
using BioGen.Application.Interfaces.Repositories;
using BioGen.Persistence;

namespace BioGen.Infrastructure.Repositories
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Nutrients = new NutrientRepository(context);
            Supplements = new SupplementRepository(context);
            NutritionReports = new NutritionReportRepository(context);
        }

        public INutrientRepository Nutrients { get; }
        public ISupplementRepository Supplements { get; }
        public INutritionReportRepository NutritionReports { get; }

        public Task<int> SaveAsync() => _context.SaveChangesAsync();
    }
}