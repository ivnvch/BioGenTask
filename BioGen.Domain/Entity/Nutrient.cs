namespace BioGen.Domain.Entity
{
    public class Nutrient // Питательное вещество
    {
        public long Id { get; set; } // Уникальный идентификатор
        public string Name { get; set; } // Название вещества, например "Витамин C"
        public string UnitOfMeasurement { get; set; } // Единица измерения, например "мг" или "мкг"
        public double RecommendedDailyIntake { get; set; } // Рекомендуемая суточная норма
    }
}