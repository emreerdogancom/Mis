using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.Seeds
{
    public class LaptopSeed : IEntityTypeConfiguration<Laptop>
    {
        public LaptopSeed()
        {

        }

        public void Configure(EntityTypeBuilder<Laptop> builder)
        {
            /* Dummy Data */
            builder.HasData(
                new Laptop() { Id = 4, UsbPorts = 2 },
                new Laptop() { Id = 5, UsbPorts = 0 }
            );
        }
    }
}
