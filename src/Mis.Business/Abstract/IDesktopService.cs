using Mis.Core.Services;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Mis.Business.Abstract
{
    public interface IDesktopService : IService<Desktop>
    {
        IEnumerable<DesktopViewModel> GetAllViewModel(Expression<Func<DesktopViewModel, bool>> filter = null);

        //Task<IEnumerable<IDesktopViewModel>> GetAllViewModelAsync();
    }
}
