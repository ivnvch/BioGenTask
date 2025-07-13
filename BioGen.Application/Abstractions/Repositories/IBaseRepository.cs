using System.Linq;
using System.Threading.Tasks;

namespace BioGen.Application.Abstractions.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        IQueryable<TEntity> GetAsync();
    }
}