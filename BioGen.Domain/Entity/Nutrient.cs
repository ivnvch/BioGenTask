namespace BioGen.Domain.Entity
{
    public class Nutrient // Питательное вещество
    {
        public long Id { get; init; } // Уникальный идентификатор
        public string Name { get; init; } // Название вещества, например "Витамин C"
        public string UnitOfMeasurement { get; init; } // Единица измерения, например "мг" или "мкг"
        public double RecommendedDailyIntake { get; init; } // Рекомендуемая суточная норма
    }
}