using System.Collections.Generic;

namespace BioGen.Domain.Entity
{
    public class SupplementRecommendation // Рекомендованный БАД
    {
        public long Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public List<SupplementComponent> SupplementComponents { get; init; }
        public long NutritionReportId { get; init; }
        public NutritionReport NutritionReport { get; init; }
    }
}