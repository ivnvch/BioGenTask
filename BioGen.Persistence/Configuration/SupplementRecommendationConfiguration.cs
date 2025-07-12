using BioGen.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BioGen.Persistence.Configuration
{
    public class SupplementRecommendationConfiguration: IEntityTypeConfiguration<SupplementRecommendation>
    {
        public void Configure(EntityTypeBuilder<SupplementRecommendation> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            
            builder.Property(x => x.Name).HasColumnName("name")
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Description)
                .HasMaxLength(500);
            
            builder.HasMany(r => r.Components)
                .WithOne(c => c.SupplementRecommendation)
                .HasForeignKey(c => c.SupplementRecommendationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}