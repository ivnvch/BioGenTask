using BioGen.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BioGen.Persistence.Configuration
{
    public class DailyIntakeConfiguration : IEntityTypeConfiguration<DailyIntake>
    {
        public void Configure(EntityTypeBuilder<DailyIntake> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            
            builder.Property(x => x.CurrentIntake)
                .IsRequired();
            
            builder.HasOne(x => x.Nutrient)
                .WithMany()
                .HasForeignKey("NutrientId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}