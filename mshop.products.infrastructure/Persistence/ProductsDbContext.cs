using Microsoft.EntityFrameworkCore;
using mshop.products.domain.Entities;

namespace mshop.products.infrastructure.Persistence
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext()
        {
        }

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Products;Username=root;Password=password;");

        public DbSet<Product> Products {  get; set; }
        public DbSet<Category> Categories {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Products");

                entity.Property(p => p.Id)
                    .IsRequired();

                entity.Property(p => p.Name)
                    .IsRequired();

                entity.Property(p => p.Description);

                entity.Property(p => p.ImageUrl);

                entity.Property(p => p.Price)
                    .IsRequired();

                entity.HasOne(p => p.Category)
                    .WithMany(c => c.Products)
                    .HasForeignKey(p => p.CategoryId)
                    .IsRequired();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Categories");

                entity.Property(c => c.Id)
                    .IsRequired();

                entity.Property(c => c.Name)
                    .IsRequired();
            });
        }
    }
}
