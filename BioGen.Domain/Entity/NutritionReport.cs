using System;
using System.Collections.Generic;

namespace BioGen.Domain.Entity
{
    public class NutritionReport
    {
        public long Id { get; init; }
        public DateTime CreatedAt { get; init; }

        public List<DailyIntake> DailyIntakes { get; init; } = new();
        public List<FinalDailyIntake> FinalDailyIntakes { get; init; } = new();
        public List<SupplementRecommendation> SupplementRecommendations { get; init; } = new();
    }
}