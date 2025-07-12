using BioGen.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BioGen.Persistence.Configuration
{
    public class NutrientConfiguration:IEntityTypeConfiguration<Nutrient>
    {
        public void Configure(EntityTypeBuilder<Nutrient> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.Property(x => x.Unit)
                .IsRequired()
                .HasMaxLength(10);
            
            builder.Property(x => x.RecommendedDailyIntake)
                .IsRequired();
        }
    }
}