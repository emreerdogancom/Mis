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
    public class LaptopService : Service<Laptop>, ILaptopService
    {
        private ILaptopRepository _ILaptopRepository;

        public LaptopService(ILaptopRepository rep) : base(rep)
        {
            _ILaptopRepository = rep;
        }

        /*
            Use override methods if you need to custom business codes
        */

        public IEnumerable<LaptopViewModel> GetAllViewModel(Expression<Func<LaptopViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _ILaptopRepository.GetAllViewModel();
        }

        public Task<IEnumerable<LaptopViewModel>> GetAllViewModelAsync(Expression<Func<LaptopViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _ILaptopRepository.GetAllViewModelAsync();
        }

        public LaptopViewModel GetByIdViewModel(Expression<Func<LaptopViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _ILaptopRepository.GetByIdViewModel();
        }

        public Task<LaptopViewModel> GetByIdViewModelAsync(Expression<Func<LaptopViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _ILaptopRepository.GetByIdViewModelAsync();
        }
    }
}
