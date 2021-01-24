using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.Seeds
{
    public class TabletSeed : IEntityTypeConfiguration<Tablet>
    {
        public TabletSeed()
        {

        }

        public void Configure(EntityTypeBuilder<Tablet> builder)
        {
            /* Dummy Data */
            //builder.HasData(
            //    new Tablet() { Id = 1 },
            //    new Tablet() { Id = 2 }
            //);
        }
    }
}
