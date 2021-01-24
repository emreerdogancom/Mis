using Mis.Core.Repositories;
using Mis.Core.ViewModel;
using System.Threading.Tasks;

namespace Mis.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        //IBrandRepository Brands { get; }
        //IComputerRepository Computers { get; }
        //IDesktopRepository Desktops { get; }
        //IFromFactorRepository FromFactors { get; }
        //ILaptopRepository Laptops { get; }
        //IPCBasedProductRepository PCBasedProducs { get; }
        //IProcessorRepository Processors { get; }
        //IProductRepository Products { get; }
        //IServerRepository Servers { get; }
        //ITabletRepository Tablets { get; }

        Task Commit();
    }
}
