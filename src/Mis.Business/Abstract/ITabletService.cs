using Mis.Core.Services;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Mis.Business.Abstract
{
    public interface ITabletService : IService<Tablet>
    {
        IEnumerable<TabletViewModel> GetAllViewModel(Expression<Func<TabletViewModel, bool>> filter = null);
    }
}
