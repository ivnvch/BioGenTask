namespace BioGen.Domain.Entity
{
    public class SupplementComponent //Состав БАД
    {
        public long Id { get; init; }

        public long SupplementRecommendationId { get; init; }
        public SupplementRecommendation SupplementRecommendation { get; init; }

        public long NutrientId { get; init; }
        public Nutrient Nutrient { get; init; }

        public double Amount { get; init; } // Кол-во нутриента в одной дозе
    }
}