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
    public class ServerManager : IServerService
    {
        private IServerRepository _IServerRepository;

        public ServerManager(IServerRepository ServerRepository)
        {
            _IServerRepository = ServerRepository;
        }


        #region Model

        public async Task<IEnumerable<Server>> GetAllAsync(Expression<Func<Server, bool>> filter = null)
        {
            return await _IServerRepository.GetAllAsync(filter);
        }

        public IEnumerable<Server> GetAll(Expression<Func<Server, bool>> filter = null)
        {
            return _IServerRepository.GetAll(filter);
        }



        public async Task<Server> GetByIdAsync(Expression<Func<Server, bool>> filter)
        {
            return await _IServerRepository.GetByIdAsync(filter);
        }

        public Server GetById(Expression<Func<Server, bool>> filter)
        {
            return _IServerRepository.GetById(filter);
        }



        public async Task InsertAsync(Server entity)
        {
            /* Validation Codes */

            await _IServerRepository.InsertAsync(entity);
        }

        public void Insert(Server entity)
        {
            _IServerRepository.Insert(entity);
        }



        public void Update(Server entity)
        {
            _IServerRepository.Update(entity);
        }

        public void Delete(Server entity)
        {
            _IServerRepository.Delete(entity);
        }

        #endregion


        #region ViewModel

        public IEnumerable<ServerViewModel> GetAllViewModel(Func<ServerViewModel, bool> filter = null)
        {
            return _IServerRepository.GetAllViewModel();
        }

        public Task<IEnumerable<ServerViewModel>> GetAllViewModelAsync(Func<ServerViewModel, bool> filter = null)
        {
            return _IServerRepository.GetAllViewModelAsync();
        }

        public ServerViewModel GetByIdViewModel(Func<ServerViewModel, bool> filter = null)
        {
            return _IServerRepository.GetByIdViewModel();
        }

        public Task<ServerViewModel> GetByIdViewModelAsync(Func<ServerViewModel, bool> filter = null)
        {
            return _IServerRepository.GetByIdViewModelAsync();
        }

        #endregion
    }
}
