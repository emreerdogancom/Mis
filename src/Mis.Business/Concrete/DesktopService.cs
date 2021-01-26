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
    public class DesktopService : Service<Desktop>, IDesktopService
    {
        private readonly IDesktopRepository _IDesktopRepository;

        public DesktopService(IDesktopRepository rep) : base(rep)
        {
            _IDesktopRepository = rep;
        }

        /*
            Use override methods if you need to custom business codes
        */

        public IEnumerable<DesktopViewModel> GetAllViewModel(Expression<Func<DesktopViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _IDesktopRepository.GetAllViewModel();
        }

        public Task<IEnumerable<DesktopViewModel>> GetAllViewModelAsync(Expression<Func<DesktopViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _IDesktopRepository.GetAllViewModelAsync();
        }


        public DesktopViewModel GetByIdViewModel(Expression<Func<DesktopViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _IDesktopRepository.GetByIdViewModel();
        }

        public Task<DesktopViewModel> GetByIdViewModelAsync(Expression<Func<DesktopViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _IDesktopRepository.GetByIdViewModelAsync();
        }

    }
}
