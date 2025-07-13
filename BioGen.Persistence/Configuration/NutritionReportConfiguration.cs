using BioGen.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BioGen.Persistence.Configuration
{
    public class NutritionReportConfiguration:IEntityTypeConfiguration<NutritionReport>
    {
        public void Configure(EntityTypeBuilder<NutritionReport> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedAt).IsRequired();
            
            builder.HasMany(x => x.SupplementRecommendations)
                .WithOne(x => x.NutritionReport)
                .HasForeignKey(x => x.NutritionReportId)
                .HasPrincipalKey(x => x.Id);
            
            builder.HasMany(x => x.FinalDailyIntakes)
                .WithOne(x => x.NutritionReport)
                .HasForeignKey(x => x.NutritionReportId)
                .HasPrincipalKey(x => x.Id);
            
            builder.HasMany(x => x.DailyIntakes)
                .WithOne(x => x.NutritionReport)
                .HasForeignKey(x => x.NutritionReportId)
                .HasPrincipalKey(x => x.Id);
        }
    }
}