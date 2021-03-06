﻿using Mis.Entities.Abstract.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mis.Core.Repositories.ViewModel
{
    public interface IViewModelRepository<TViewModel>
        where TViewModel : class, IViewModel, new()
    {
        IEnumerable<TViewModel> GetAllViewModel(Expression<Func<TViewModel, bool>> filter = null);

        Task<IEnumerable<TViewModel>> GetAllViewModelAsync(Expression<Func<TViewModel, bool>> filter = null);



        TViewModel GetByIdViewModel(Expression<Func<TViewModel, bool>> filter = null);

        Task<TViewModel> GetByIdViewModelAsync(Expression<Func<TViewModel, bool>> filter = null);

    }
}
