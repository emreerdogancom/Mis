using Mis.Business.Abstract;
using Mis.Business.Concrete.Base;
using Mis.Core.Repositories.Entity;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mis.Business.Concrete
{
    public class TabletService : Service<Tablet>, ITabletService
    {
        private ITabletRepository _tabletRepository;

        public TabletService(ITabletRepository rep) : base(rep)
        {
            _tabletRepository = rep;
        }

        /*
            Use override methods if you need to custom business codes
        */

        public IEnumerable<TabletViewModel> GetAllViewModel(Expression<Func<TabletViewModel, bool>> filter = null)
        {
           /* Business Codes Here */
           return _tabletRepository.GetAllViewModel();
        }

        public Task<IEnumerable<TabletViewModel>> GetAllViewModelAsync(Expression<Func<TabletViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _tabletRepository.GetAllViewModelAsync();
        }

        public TabletViewModel GetByIdViewModel(Expression<Func<TabletViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _tabletRepository.GetByIdViewModel();
        }

        public Task<TabletViewModel> GetByIdViewModelAsync(Expression<Func<TabletViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _tabletRepository.GetByIdViewModelAsync();
        }
    }
}
