namespace BioGen.Domain.Entity
{
    public class SupplementComponent //Состав БАД
    {
        public long Id { get; set; }

        public long SupplementRecommendationId { get; set; }
        public SupplementRecommendation SupplementRecommendation { get; set; }

        public long NutrientId { get; set; }
        public Nutrient Nutrient { get; set; }

        public double Amount { get; set; } // Кол-во нутриента в одной дозе
    }
}