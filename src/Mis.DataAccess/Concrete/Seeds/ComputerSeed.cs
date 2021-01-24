using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.Seeds
{
    public class ComputerSeed : IEntityTypeConfiguration<Computer>
    {
        public ComputerSeed()
        {

        }

        public void Configure(EntityTypeBuilder<Computer> builder)
        {
            /* Dummy Data */
            builder.HasData(
                new Computer() { Id = 1, FromFactorId = 1, RamSlots = 2, UsbPorts = 5 },
                new Computer() { Id = 2, FromFactorId = 1, RamSlots = 2, UsbPorts = 10 },
                new Computer() { Id = 3, FromFactorId = 1, RamSlots = 15, UsbPorts = 0 }
            );
        }
    }
}
