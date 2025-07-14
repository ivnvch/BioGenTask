namespace BioGen.Domain.Entity
{
    public class Nutrient // Питательное вещество
    {
        public long Id { get; init; }
        public string Name { get; init; } 
        public string UnitOfMeasurement { get; init; }
        public double RecommendedDailyIntake { get; init; }
    }
}