using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BioGen.Application.Abstractions.Repositories;
using BioGen.Application.Abstractions.Services;
using BioGen.Application.DTO;
using BioGen.Application.Validations;
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

        public async Task<NutritionReportDto> GetLatestAsync()
        {
            try
            {
                var report = await _wrapperRepository.NutritionReportRepository.GetLatestAsync();

                if (report is null)
                    return null;

                var finalDailyIntakeDto = report.FinalDailyIntakes?.Select(x =>
                        new FinalDailyIntakeDto(x.NutrientId, x.FromFood, x.FromSupplements))
                    .ToList() ?? new();

                var dailyIntakeDto = report.DailyIntakes?.Select(x => new DailyIntakeDto(x.NutrientId, x.CurrentIntake))
                    .ToList() ?? new();

                var supplementRecommendationDto = report.SupplementRecommendations?
                    .Select(x => new SupplementRecommendationDto(
                        x.Name,
                        x.Description,
                        x.SupplementComponents?
                            .Select(sc => new SupplementComponentDto(sc.NutrientId, sc.Amount))
                            .ToList() ?? new()
                    )).ToList() ?? new();
                
                var nutritionReportDto = new NutritionReportDto(
                    CreatedAt: report.CreatedAt,
                    DailyIntakes: dailyIntakeDto,
                    FinalDailyIntakes: finalDailyIntakeDto,
                    SupplementRecommendations: supplementRecommendationDto);

                return nutritionReportDto;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении отчёта: {ex.Message}");
                throw new ApplicationException("Ошибка при получении последнего отчёта.", ex);
            }
        }

        public async Task<NutritionReportDto> CreateReportAsync(NutritionReportDto nutritionReportDto)
        {
            try
            {
                var validator = new NutritionReportDtoValidator();
                var result = await validator.ValidateAsync(nutritionReportDto);
                
                if(!result.IsValid)
                    throw new ValidationException(result.Errors.ToString());
                
                var dailyIntakes = nutritionReportDto.DailyIntakes?
                    .Select(x => new DailyIntake(x.NutrientId, x.CurrentIntake))
                    .ToList() ?? new();

                var finalDailyIntakes = nutritionReportDto.FinalDailyIntakes?.Select(x => new FinalDailyIntake
                {
                    NutrientId = x.NutrientId,
                    FromFood = x.FromFood,
                    FromSupplements = x.FromSupplement
                }).ToList() ?? new();

                var supplementRecommendations = nutritionReportDto.SupplementRecommendations?.Select(x =>
                    new SupplementRecommendation
                    {
                        Name = x.Name,
                        Description = x.Description,
                        SupplementComponents = x.SupplementComponents?.Select(sc => new SupplementComponent
                        {
                            NutrientId = sc.NutrientId,
                            Amount = sc.Amount
                        }).ToList() ?? new()
                    }).ToList() ?? new();
                var nutritionReport = new NutritionReport()
                {
                    DailyIntakes = dailyIntakes,
                    FinalDailyIntakes = finalDailyIntakes,

                    SupplementRecommendations = supplementRecommendations,
                };
                
                await _wrapperRepository.NutritionReportRepository.CreateAsync(nutritionReport);
                await _unitOfWork.SaveChangesAsync();
                
                return nutritionReportDto;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении отчёта: {ex.Message}");
                throw new ApplicationException("Ошибка при получении последнего отчёта.", ex);
            }
        }
    }
}