using Mis.Core.Services;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Mis.Business.Abstract
{
    public interface ILaptopService : IService<Laptop>
    {
        IEnumerable<LaptopViewModel> GetAllViewModel(Expression<Func<LaptopViewModel, bool>> filter = null);
    }
}
