using BioGen.Application.Abstractions.Services;
using BioGen.Application.Interfaces.Repositories;

namespace BioGen.Application.Abstractions.Repositories
{
    public interface IWrapperRepository
    {
        INutritionReportRepository NutritionReportRepository { get; }
    }
}