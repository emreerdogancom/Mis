﻿using Mis.Core.Repositories.Entity.Base;
using Mis.Core.Repositories.ViewModel;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;

namespace Mis.Core.Repositories.Entity
{
    public interface ITabletRepository : IEntityRepository<Tablet>, IViewModelRepository<TabletViewModel>
    {

    }
}
