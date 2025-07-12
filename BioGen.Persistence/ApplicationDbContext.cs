using System.Reflection;
using BioGen.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BioGen.Persistence
{
    public class ApplicationDbContext:DbContext
    {
        private readonly IConfiguration _configuration;
        
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<DailyIntake> DailyIntakes { get; set; }
        public DbSet<SupplementRecommendation> SupplementRecommendations { get; set; }
        public DbSet<SupplementComponent> SupplementComponents { get; set; }
        public DbSet<FinalDailyIntake> FinalDailyIntakes { get; set; }

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;

            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}