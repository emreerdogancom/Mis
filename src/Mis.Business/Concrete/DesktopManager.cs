using Mis.Business.Abstract;
using Mis.Core.Repositories;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mis.Business.Concrete
{
    public class DesktopManager : IDesktopService
    {
        private IDesktopRepository _IDesktopRepository;

        public DesktopManager(IDesktopRepository DesktopRepository)
        {
            _IDesktopRepository = DesktopRepository;
        }



        public async Task<IEnumerable<Desktop>> GetAllAsync(Expression<Func<Desktop, bool>> filter = null)
        {


            return await _IDesktopRepository.GetAllAsync(filter);
        }

        public IEnumerable<Desktop> GetAll(Expression<Func<Desktop, bool>> filter = null)
        {
            return _IDesktopRepository.GetAll(filter);
        }



        public async Task<Desktop> GetByIdAsync(Expression<Func<Desktop, bool>> filter)
        {


            return await _IDesktopRepository.GetByIdAsync(filter);
        }

        public Desktop GetById(Expression<Func<Desktop, bool>> filter)
        {
            return _IDesktopRepository.GetById(filter);
        }



        public async Task InsertAsync(Desktop entity)
        {
            /* Validation Codes */

            await _IDesktopRepository.InsertAsync(entity);
        }

        public void Insert(Desktop entity)
        {
            _IDesktopRepository.Insert(entity);
        }



        public void Update(Desktop entity)
        {
            _IDesktopRepository.Update(entity);
        }

        public void Delete(Desktop entity)
        {
            _IDesktopRepository.Delete(entity);
        }


        public IEnumerable<DesktopViewModel> GetAllViewModel(Expression<Func<DesktopViewModel, bool>> filter = null)
        {

           return _IDesktopRepository.GetAllViewModel();
        }

        //public async Task<IEnumerable<IDesktopViewModel>> GetAllViewModelAsync()
        //{
        //    return await _IDesktopRepository.GetAllViewModelAsync();
        //}
    }
}
