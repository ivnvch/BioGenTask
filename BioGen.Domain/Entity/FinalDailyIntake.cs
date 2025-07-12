namespace BioGen.Domain.Entity
{
    public class FinalDailyIntake//Итоговое потребление с учётом добавок
    {
        public long Id { get; set; }

        public long NutrientId { get; set; }
        public Nutrient Nutrient { get; set; }

        public double FromFood { get; set; }
        public double FromSupplements { get; set; }

        public double Total => FromFood + FromSupplements;
    }
}