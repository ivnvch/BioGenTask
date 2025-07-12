using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BioGen.Domain.Entity;

namespace BioGen.Application.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        IQueryable<TEntity> GetAllAsync();
    }
}