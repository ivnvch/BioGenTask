using System;
using System.Threading.Tasks;
using BioGen.Application.Abstractions.Repositories;
using BioGen.Application.Abstractions.Services;
using BioGen.Application.DTO;
using BioGen.Application.Interfaces.Repositories;
using BioGen.Domain.Entity;

namespace BioGen.Application.Services
{
    public class NutritionReportService: INutritionReportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWrapperRepository _wrapperRepository;

        public NutritionReportService(IWrapperRepository wrapperRepository, IUnitOfWork unitOfWork)
        {
            _wrapperRepository = wrapperRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<NutritionReport> GetLatestAsync()
        {
            try
            {
                var report = await _wrapperRepository.NutritionReportRepository.GetLatestAsync();

                if (report is null)
                    return null;
                
                return report;
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении отчёта: {ex.Message}");
                throw new ApplicationException("Ошибка при получении последнего отчёта.", ex);
            }
        }

        public Task<NutritionReportDto> CreateAsync(NutritionReportDto nutritionReportDto)
        {
            throw new NotImplementedException();
        }
    }
}