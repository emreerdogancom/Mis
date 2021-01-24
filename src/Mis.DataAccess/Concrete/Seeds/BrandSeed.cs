using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.Seeds
{
    public class BrandSeed : IEntityTypeConfiguration<Brand>
    {
        public BrandSeed()
        {
            
        }

        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            /* Dummy Data */
            builder.HasData(
                new Brand { Id = 1, BrandName = "DELL" },
                new Brand { Id = 2, BrandName = "HP" },
                new Brand { Id = 3, BrandName = "Apple" }
            );
        }
    }
}
