using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.Seeds
{
    public class FromFactorSeed : IEntityTypeConfiguration<FromFactor>
    {
        public FromFactorSeed()
        {
            
        }

        public void Configure(EntityTypeBuilder<FromFactor> builder)
        {
            /* Dummy Data */
            builder.HasData(
                new FromFactor { Id = 1, FromFactorName = "Tower" },
                new FromFactor { Id = 2, FromFactorName = "Mid-Tower" }
            );
        }
    }
}
