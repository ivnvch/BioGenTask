using System.Linq;
using System.Threading.Tasks;
using BioGen.Application.Interfaces.Repositories;
using BioGen.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace BioGen.Persistence.Repositories
{
    public class NutritionReportRepository: BaseRepository<NutritionReport>, INutritionReportRepository
    {

        public NutritionReportRepository(ApplicationDbContext context):base(context)
        {
        }

        public async Task<NutritionReport> GetLatestAsync()
        {
           return await GetAllAsync()
                .Include(x => x.DailyIntakes)
                .Include(x => x.FinalDailyIntakes)
                .Include(x => x.SupplementRecommendations)
                .ThenInclude(x => x.SupplementComponents)
                .OrderByDescending(x => x.CreatedAt)
                .FirstOrDefaultAsync();
        }

        public async Task<NutritionReport> CreateAsync(NutritionReport entity)
        {
           return await CreateAsync(entity);
        }
    }
}