using System;

namespace BioGen.Domain.Entity
{
    public class DailyIntake//Текущее суточное потребление
    {
        public long Id { get; set; }
        
        public long NutrientId { get; set; }
        public Nutrient Nutrient { get; set; }

        private double _currentIntake;
        public double CurrentIntake => _currentIntake;// Текущее потребление
        
        private DailyIntake() { }

        public DailyIntake(long nutrientId, double intake)
        {
            if (intake < 0)
                throw new ArgumentOutOfRangeException(nameof(intake), "Потребление не может быть отрицательным");
            NutrientId = nutrientId;
            _currentIntake = intake;
        }
        
        public void UpdateIntake(double newIntake)
        {
            if (newIntake < 0)
                throw new ArgumentOutOfRangeException(nameof(newIntake), "Потребление не может быть отрицательным");

            _currentIntake = newIntake;
        }
        
        public bool IsDeficient()
        {
            if (Nutrient == null)
                throw new InvalidOperationException("Nutrient должен быть загружен для определения дефицита.");

            return _currentIntake < Nutrient.RecommendedDailyIntake;
        }
    }
}