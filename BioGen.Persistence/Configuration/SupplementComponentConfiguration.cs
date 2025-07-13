using BioGen.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BioGen.Persistence.Configuration
{
    public class SupplementComponentConfiguration:IEntityTypeConfiguration<SupplementComponent>
    {
        public void Configure(EntityTypeBuilder<SupplementComponent> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            
            builder.Property(x => x.Amount)
                .IsRequired();
            
            builder.HasOne(c => c.Nutrient)
                .WithMany()
                .HasForeignKey("NutrientId")
                .OnDelete(DeleteBehavior.Restrict); // нельзя удалять Nutrient, если он используется
            
            builder.HasOne(c => c.SupplementRecommendation)
                .WithMany(r => r.SupplementComponents)
                .HasForeignKey("SupplementRecommendationId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}