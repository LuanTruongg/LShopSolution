using LShopSolution.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LShopSolution.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(x => new { x.OrderId, x.ProductId});
            builder.HasOne(t => t.Order).WithMany(t => t.OrderDetails).HasForeignKey(t => t.OrderId);
            builder.HasOne(t => t.Product).WithMany(t => t.OrderDetails).HasForeignKey(t => t.ProductId);
        }
    }
}
