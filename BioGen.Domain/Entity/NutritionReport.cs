using System;
using System.Collections.Generic;

namespace BioGen.Domain.Entity
{
    public class NutritionReport
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<DailyIntake> DailyIntakes { get; set; } = new();
        public List<FinalDailyIntake> FinalDailyIntakes { get; set; } = new();
        public List<SupplementRecommendation> SupplementRecommendations { get; set; } = new();
    }
}