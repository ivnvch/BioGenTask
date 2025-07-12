using System;
using System.Collections.Generic;

namespace BioGen.Application.DTO
{
    public record NutritionReportDto(DateTime CreatedAt,
        List<DailyIntakeDto> DailyIntakes,
        List<FinalDailyIntakeDto> FinalDailyIntakes,
        List<SupplementRecommendationDto> SupplementRecommendations);
}