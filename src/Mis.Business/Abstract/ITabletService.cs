using Mis.Core.Services;
using Mis.Core.ViewModel.Base;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;

namespace Mis.Business.Abstract
{
    public interface ITabletService : IService<Tablet>, IViewModelRepository<TabletViewModel>
    {

    }
}
