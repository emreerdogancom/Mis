using Microsoft.EntityFrameworkCore;
using Mis.DataAccess.Concrete.Seeds;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.EF.Contexts
{
    public class MisDbContext : DbContext
    {
        /* Master Data Tables */
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Processor> Processors { get; set; }
        public DbSet<FromFactor> FromFactors { get; set; }

        /* Tables */
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Desktop> Desktops { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<PCBasedProduct> PCBasedProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<Tablet> Tablets { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseInMemoryDatabase("memory");
                optionsBuilder.UseSqlServer("Server=.; Database=Mis; Trusted_Connection=True; MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /* Dummy Master Data */
            builder.ApplyConfiguration(new BrandSeed());
            builder.ApplyConfiguration(new ProcessorSeed());
            builder.ApplyConfiguration(new FromFactorSeed());

            /* Dummy Main Data */
            builder.ApplyConfiguration(new DesktopSeed());
            builder.ApplyConfiguration(new ServerSeed());


            builder.ApplyConfiguration(new ComputerSeed());
            builder.ApplyConfiguration(new LaptopSeed());
            builder.ApplyConfiguration(new TabletSeed());


            builder.ApplyConfiguration(new PCBasedProductSeed());
            builder.ApplyConfiguration(new ProductSeed());

        }
    }
}
