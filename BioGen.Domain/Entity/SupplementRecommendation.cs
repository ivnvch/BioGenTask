using System.Collections.Generic;

namespace BioGen.Domain.Entity
{
    public class SupplementRecommendation // Рекомендованный БАД
    {
        public long Id { get; set; }
        public string Name { get; set; } // Название продукта
        public string Description { get; set; }// Краткое описание
        public List<SupplementComponent> SupplementComponents { get; set; }
    }
}