using System.Collections.Generic;

namespace BioGen.Domain.Entity
{
    public class SupplementRecommendation // Рекомендованный БАД
    {
        public long Id { get; init; }
        public string Name { get; init; } // Название продукта
        public string Description { get; init; }// Краткое описание
        public List<SupplementComponent> SupplementComponents { get; init; }
        public long NutritionReportId { get; init; }
        public NutritionReport NutritionReport { get; init; }
    }
}