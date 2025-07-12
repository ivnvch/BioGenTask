using System.Collections.Generic;
using System.Threading.Tasks;
using BioGen.Domain.Entity;

namespace BioGen.Application.Interfaces.Repositories
{
    public interface INutrientRepository
    {
        Task<List<Nutrient>> GetAllAsync();
        Task<Nutrient> GetByIdAsync(int id);
    }
}