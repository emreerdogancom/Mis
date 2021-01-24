using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.Seeds
{
    public class PCBasedProductSeed : IEntityTypeConfiguration<PCBasedProduct>
    {
        public PCBasedProductSeed()
        {

        }

        public void Configure(EntityTypeBuilder<PCBasedProduct> builder)
        {
            /* Dummy Data */
            builder.HasData(
                new PCBasedProduct() { Id = 1, ProcessorId = 2 },
                new PCBasedProduct() { Id = 2, ProcessorId = 3 },
                new PCBasedProduct() { Id = 3, ProcessorId = 6 },
                new PCBasedProduct() { Id = 4, ProcessorId = 4 },
                new PCBasedProduct() { Id = 5, ProcessorId = 1 }
            );
        }
    }
}
