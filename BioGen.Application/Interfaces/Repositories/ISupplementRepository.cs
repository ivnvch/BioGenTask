using System.Collections.Generic;
using System.Threading.Tasks;
using BioGen.Domain.Entity;

namespace BioGen.Application.Interfaces.Repositories
{
    public interface ISupplementRepository
    {
        Task<List<SupplementRecommendation>> GetRecommendationsAsync();
        Task<SupplementRecommendation> GetByIdAsync(int id);
    }
}