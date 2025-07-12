using BioGen.Application.Abstractions.Repositories;
using BioGen.Application.Abstractions.Services;
using BioGen.Application.Interfaces.Repositories;

namespace BioGen.Persistence.Repositories
{
    public class WrapperRepository :IWrapperRepository
    {
        private ApplicationDbContext _context;
        private INutritionReportRepository _nutritionReportRepository;

        public INutritionReportRepository NutritionReportRepository
        {
            get
            {
                if (_nutritionReportRepository == null)
                {
                    _nutritionReportRepository = new NutritionReportRepository(_context);
                }
                return _nutritionReportRepository;
            }
        }
        

        public WrapperRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
    }
}