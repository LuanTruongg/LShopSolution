using LShopSolution.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LShopSolution.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.ProductId });
            builder.ToTable("ProductInCategories");
            builder.HasOne(t => t.Product).WithMany(t => t.ProductInCategories).HasForeignKey(t => t.ProductId);
            builder.HasOne(t => t.Category).WithMany(t => t.ProductInCategories).HasForeignKey(t => t.CategoryId);
        }
    }
}
