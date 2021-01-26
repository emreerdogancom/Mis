using Mis.Business.Abstract.Base;
using Mis.Core.Repositories.ViewModel;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;

namespace Mis.Business.Abstract
{
    public interface ILaptopService : IService<Laptop>, IViewModelRepository<LaptopViewModel>
    {
        
    }
}
