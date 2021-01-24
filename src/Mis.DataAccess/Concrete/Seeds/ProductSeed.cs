using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public ProductSeed()
        {

        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            /* Dummy Data */
            builder.HasData(
                new Product() { Id = 1, BrandId = 1, Quantity = 10 },
                new Product() { Id = 2, BrandId = 1, Quantity = 100 },
                new Product() { Id = 3, BrandId = 2, Quantity = 1000 },
                new Product() { Id = 4, BrandId = 2, Quantity = 10000 },
                new Product() { Id = 5, BrandId = 3, Quantity = 100000 }
            );
        }
    }
}
