using System;
using BioGen.Application.DTO;
using FluentValidation;

namespace BioGen.Application.Validations
{
    public class NutritionReportDtoValidator:AbstractValidator<NutritionReportDto>
    {
        public NutritionReportDtoValidator()
        {
            RuleFor(x => x.CreatedAt)
                .NotEmpty().WithMessage("Дата отчёта обязательна")
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Дата не может быть в будущем");

            RuleForEach(x => x.DailyIntakes).SetValidator(new DailyIntakeDtoValidator());
            RuleForEach(x => x.FinalDailyIntakes).SetValidator(new FinalDailyIntakeDtoValidator());
            RuleForEach(x => x.SupplementRecommendations).SetValidator(new SupplementRecommendationDtoValidator());
        }
    }
}