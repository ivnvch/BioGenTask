using System.Threading.Tasks;

namespace BioGen.Application.Abstractions.Repositories
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}