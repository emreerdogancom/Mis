using Mis.Core.Services;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Mis.Business.Abstract
{
    public interface IServerService : IService<Server>
    {
        IEnumerable<ServerViewModel> GetAllViewModel(Expression<Func<ServerViewModel, bool>> filter = null);

        //Task<IEnumerable<IDesktopViewModel>> GetAllViewModelAsync();
    }
}
