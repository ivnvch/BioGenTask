using System.Linq;
using System.Threading.Tasks;
using BioGen.Application.Abstractions.Repositories;
using BioGen.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BioGen.Persistence.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;

        protected BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
           await _context.Set<TEntity>().AddAsync(entity);
           return entity;
        }

        public IQueryable<TEntity> GetAsync()
        {
            return  _context.Set<TEntity>().AsNoTracking();
        }
    }
}