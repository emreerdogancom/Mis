using Mis.Core.Repositories.Base;
using Mis.Core.ViewModel.Base;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;

namespace Mis.Core.Repositories
{
    public interface ILaptopRepository : IEntityRepository<Laptop>, IViewModelRepository<LaptopViewModel>
    {

    }
}
