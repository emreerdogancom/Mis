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
    public class TabletManager : ITabletService
    {
        private ITabletRepository _ITabletRepository;

        public TabletManager(ITabletRepository TabletRepository)
        {
            _ITabletRepository = TabletRepository;
        }


        #region Model

        public async Task<IEnumerable<Tablet>> GetAllAsync(Expression<Func<Tablet, bool>> filter = null)
        {
            return await _ITabletRepository.GetAllAsync(filter);
        }

        public IEnumerable<Tablet> GetAll(Expression<Func<Tablet, bool>> filter = null)
        {
            return _ITabletRepository.GetAll(filter);
        }



        public async Task<Tablet> GetByIdAsync(Expression<Func<Tablet, bool>> filter)
        {
            return await _ITabletRepository.GetByIdAsync(filter);
        }

        public Tablet GetById(Expression<Func<Tablet, bool>> filter)
        {
            return _ITabletRepository.GetById(filter);
        }



        public async Task InsertAsync(Tablet entity)
        {
            /* Validation Codes */

            await _ITabletRepository.InsertAsync(entity);
        }

        public void Insert(Tablet entity)
        {
            _ITabletRepository.Insert(entity);
        }



        public void Update(Tablet entity)
        {
            _ITabletRepository.Update(entity);
        }

        public void Delete(Tablet entity)
        {
            _ITabletRepository.Delete(entity);
        }

        #endregion

        #region ViewModel

        public IEnumerable<TabletViewModel> GetAllViewModel(Func<TabletViewModel, bool> filter = null)
        {
           return _ITabletRepository.GetAllViewModel();
        }

        public Task<IEnumerable<TabletViewModel>> GetAllViewModelAsync(Func<TabletViewModel, bool> filter = null)
        {
            return _ITabletRepository.GetAllViewModelAsync();
        }

        public TabletViewModel GetByIdViewModel(Func<TabletViewModel, bool> filter = null)
        {
            return _ITabletRepository.GetByIdViewModel();
        }

        public Task<TabletViewModel> GetByIdViewModelAsync(Func<TabletViewModel, bool> filter = null)
        {
            return _ITabletRepository.GetByIdViewModelAsync();
        }

        #endregion
    }
}
