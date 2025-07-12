using System.Threading.Tasks;
using BioGen.Application.DTO;
using BioGen.Domain.Entity;

namespace BioGen.Application.Abstractions.Services
{
    public interface INutritionReportService
    {
        Task<NutritionReport> GetLatestAsync();
        Task<NutritionReportDto> CreateAsync(NutritionReportDto  nutritionReportDto);
    }
}