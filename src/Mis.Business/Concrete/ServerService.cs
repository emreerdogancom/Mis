﻿using Mis.Business.Abstract;
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
    public class ServerService : Service<Server>, IServerService
    {
        private IServerRepository _serverRepository;

        public ServerService(IServerRepository rep) : base(rep)
        {
            _serverRepository = rep;
        }

        /*
            Use override methods if you need to custom business codes
        */

        public IEnumerable<ServerViewModel> GetAllViewModel(Expression<Func<ServerViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _serverRepository.GetAllViewModel();
        }

        public Task<IEnumerable<ServerViewModel>> GetAllViewModelAsync(Expression<Func<ServerViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _serverRepository.GetAllViewModelAsync();
        }

        public ServerViewModel GetByIdViewModel(Expression<Func<ServerViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _serverRepository.GetByIdViewModel();
        }

        public Task<ServerViewModel> GetByIdViewModelAsync(Expression<Func<ServerViewModel, bool>> filter = null)
        {
            /* Business Codes Here */
            return _serverRepository.GetByIdViewModelAsync();
        }
    }
}
