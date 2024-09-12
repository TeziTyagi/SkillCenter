using Microsoft.EntityFrameworkCore;
using SkillCenter.Models; // Ensure this namespace is correct

namespace SkillCenter.DatabaseContext
{
    public class ProductDbContext : DbContext
    {
        
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }

        // DbSet for MyModel
        public DbSet<MyModel> Products { get; set; }

        // Optional: Customize the model configuration if needed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration for MyModel can be added here if needed
            // For example, configuring table names or relationships
            base.OnModelCreating(modelBuilder);
        }
    }
}
