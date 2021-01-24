using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.Seeds
{
    public class ProcessorSeed : IEntityTypeConfiguration<Processor>
    {
        public ProcessorSeed()
        {
            
        }

        public void Configure(EntityTypeBuilder<Processor> builder)
        {
            /* Dummy Data */
            builder.HasData(
                new Processor { Id = 1, ProcessorName = "Atom" },
                new Processor { Id = 2, ProcessorName = "I3" },
                new Processor { Id = 3, ProcessorName = "I5" },
                new Processor { Id = 4, ProcessorName = "I7" },
                new Processor { Id = 5, ProcessorName = "I9" },
                new Processor { Id = 6, ProcessorName = "Xeon" }
            );
        }
    }
}
