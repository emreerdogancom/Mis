using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.Seeds
{
    public class ServerSeed : IEntityTypeConfiguration<Server>
    {
        public ServerSeed()
        {

        }

        public void Configure(EntityTypeBuilder<Server> builder)
        {
            /* Dummy Data */
            builder.HasData(
                new Server() { Id = 3 }
            );
        }
    }
}
