using BioGen.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BioGen.Persistence.Configuration
{
    public class FinalDailyIntakeConfiguration:IEntityTypeConfiguration<FinalDailyIntake>
    {
        public void Configure(EntityTypeBuilder<FinalDailyIntake> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            
            builder.Property(x => x.FromFood)
                .IsRequired();
            
            builder.Property(x => x.FromSupplements)
                .IsRequired();
            
            builder.HasOne(x => x.Nutrient)
                .WithMany()
                .HasForeignKey(x => x.NutrientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}