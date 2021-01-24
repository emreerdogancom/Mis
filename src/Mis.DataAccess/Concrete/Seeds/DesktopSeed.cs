using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.Seeds
{
    public class DesktopSeed : IEntityTypeConfiguration<Desktop>
    {
        public DesktopSeed()
        {

        }

        public void Configure(EntityTypeBuilder<Desktop> builder)
        {
            /* Dummy Data */
            builder.HasData(
                new Desktop() { Id = 1 },
                new Desktop() { Id = 2 }
            );
        }
    }
}
