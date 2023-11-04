using Microsoft.EntityFrameworkCore;
using PruebaQualit.Core.Entities;

namespace PruebaQualit.Infrastructure.Data
{
    public partial class PruebaQualitContext : DbContext
    {
        public PruebaQualitContext()
        {
        }

        public PruebaQualitContext(DbContextOptions<PruebaQualitContext> options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Product");

                entity.Property(e => e.Id);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price);

                entity.Property(e => e.ProductType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

            });
        }
    }
}
