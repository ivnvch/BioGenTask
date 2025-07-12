using System;

namespace BioGen.Domain.Entity
{
    public class DailyIntake//Текущее суточное потребление
    {
        public long Id { get; init; }
        
        public long NutrientId { get; init; }
        public Nutrient Nutrient { get; init; }
        
        public double CurrentIntake { get; private set; }
        
        private DailyIntake() { }

        public DailyIntake(long nutrientId, double intake)
        {
            if (intake < 0)
                throw new ArgumentOutOfRangeException(nameof(intake), "Потребление не может быть отрицательным");
            NutrientId = nutrientId;
            CurrentIntake = intake;
        }
        
        public void UpdateIntake(double newIntake)
        {
            if (newIntake < 0)
                throw new ArgumentOutOfRangeException(nameof(newIntake), "Потребление не может быть отрицательным");

            CurrentIntake = newIntake;
        }
        
        public bool IsDeficient()
        {
            if (Nutrient == null)
                throw new InvalidOperationException("Nutrient должен быть загружен для определения дефицита.");

            return CurrentIntake < Nutrient.RecommendedDailyIntake;
        }
    }
}