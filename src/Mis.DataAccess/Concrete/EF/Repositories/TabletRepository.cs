﻿using Mis.Core.Repositories;
using Mis.DataAccess.Concrete.EF.Contexts;
using Mis.DataAccess.Concrete.EF.Repositories.Base;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mis.DataAccess.Concrete.EF.Repositories
{
    public class TabletRepository : EntityRepository<Tablet, MisDbContext>, ITabletRepository
    {
        public IEnumerable<TabletViewModel> GetAllViewModel(Expression<Func<TabletViewModel, bool>> filter = null)
        {
            var context = new MisDbContext();

            var result = (
                            from d in context.Set<Tablet>()

                            select new TabletViewModel
                            {
                                Id = d.Id,

                                ProcessorId = d.PCBasedProduct.ProcessorId,
                                ProcessorName = d.PCBasedProduct.Processor.ProcessorName,

                                BrandId = d.PCBasedProduct.Product.BrandId,
                                BrandName = d.PCBasedProduct.Product.Brand.BrandName,

                                Quantity = d.PCBasedProduct.Product.Quantity
                            }
                        );

            return filter == null ?
                result.ToList() :
                result.Where(filter).ToList();

        }

        public Task<IEnumerable<TabletViewModel>> GetAllViewModelAsync(Expression<Func<TabletViewModel, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
