namespace BioGen.Domain.Entity
{
    public class FinalDailyIntake//Итоговое потребление с учётом добавок
    {
        public long Id { get; init; }

        public long NutrientId { get; init; }
        public Nutrient Nutrient { get; init; }
        
        public long NutritionReportId { get; init; }
        public NutritionReport NutritionReport { get; init; }

        public double FromFood { get; init; }
        public double FromSupplements { get; init; }

        public double Total => FromFood + FromSupplements;
    }
}