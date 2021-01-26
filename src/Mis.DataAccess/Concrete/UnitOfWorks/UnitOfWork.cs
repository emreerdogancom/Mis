using Mis.Core.Repositories.Entity;
using Mis.Core.UnitOfWorks;
using Mis.DataAccess.Concrete.EF.Contexts;
using Mis.DataAccess.Concrete.EF.Repositories;
using System.Threading.Tasks;

namespace Mis.DataAccess.Concrete.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MisDbContext _context;

        public UnitOfWork(MisDbContext Context)
        {
            /*
                Not sure that we need Unit Of Work. If needs, context object should send to repository
             */
            _context = Context;
        }

        private BrandRepository _brandRepository;
        public IBrandRepository Brands => _brandRepository ??= new BrandRepository();


        private ComputerRepository _computerRepository;
        public IComputerRepository Computers => _computerRepository ??= new ComputerRepository();


        private DesktopRepository _desktopRepository;
        public IDesktopRepository Desktops => _desktopRepository ??= new DesktopRepository();


        private FromFactorRepository _fromFactorRepository;
        public IFromFactorRepository FromFactors => _fromFactorRepository ??= new FromFactorRepository();


        private LaptopRepository _laptopRepository;
        public ILaptopRepository Laptops => _laptopRepository ??= new LaptopRepository();


        private PCBasedProductRepository _pcBasedProductRepository;
        public IPCBasedProductRepository PCBasedProducs => _pcBasedProductRepository ??= new PCBasedProductRepository();


        private ProcessorRepository _processorRepository;
        public IProcessorRepository Processors => _processorRepository ??= new ProcessorRepository();


        private ProductRepository _productRepository;
        public IProductRepository Products => _productRepository ??= new ProductRepository();


        private ServerRepository _serverRepository;
        public IServerRepository Servers => _serverRepository ??= new ServerRepository();


        private TabletRepository _tabletRepository;
        public ITabletRepository Tablets => _tabletRepository ??= new TabletRepository();




        public void Commit()
        {
            //_context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            //await _context.SaveChangesAsync();
        }
    }
}
