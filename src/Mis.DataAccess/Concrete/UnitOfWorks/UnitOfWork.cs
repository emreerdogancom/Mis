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

        private BrandRepository _BrandRepository;
        public IBrandRepository Brands => _BrandRepository ??= new BrandRepository();


        private ComputerRepository _ComputerRepository;
        public IComputerRepository Computers => _ComputerRepository ??= new ComputerRepository();


        private DesktopRepository _DesktopRepository;
        public IDesktopRepository Desktops => _DesktopRepository ??= new DesktopRepository();


        private FromFactorRepository _FromFactorRepository;
        public IFromFactorRepository FromFactors => _FromFactorRepository ??= new FromFactorRepository();


        private LaptopRepository _LaptopRepository;
        public ILaptopRepository Laptops => _LaptopRepository ??= new LaptopRepository();


        private PCBasedProductRepository _IPCBasedProductRepository;
        public IPCBasedProductRepository PCBasedProducs => _IPCBasedProductRepository ??= new PCBasedProductRepository();


        private ProcessorRepository _ProcessorRepository;
        public IProcessorRepository Processors => _ProcessorRepository ??= new ProcessorRepository();


        private ProductRepository _ProductRepository;
        public IProductRepository Products => _ProductRepository ??= new ProductRepository();


        private ServerRepository _ServerRepository;
        public IServerRepository Servers => _ServerRepository ??= new ServerRepository();


        private TabletRepository _TabletRepository;
        public ITabletRepository Tablets => _TabletRepository ??= new TabletRepository();




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
