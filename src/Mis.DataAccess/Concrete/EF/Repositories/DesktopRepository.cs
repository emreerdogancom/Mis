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
    public class DesktopRepository : EntityRepository<Desktop, MisDbContext>, IDesktopRepository
    {
        public IEnumerable<DesktopViewModel> GetAllViewModel(Expression<Func<DesktopViewModel, bool>> filter = null)
        {
            var context = new MisDbContext();

            var result = (
                            from d in context.Set<Desktop>()

                            select new DesktopViewModel
                            {
                                Id = d.Id,
                                RamSlots = d.Computer.RamSlots,
                                UsbPorts = d.Computer.UsbPorts,

                                FromFactorId = d.Computer.FromFactorId,
                                FromFactorName = d.Computer.FromFactor.FromFactorName,

                                ProcessorId = d.Computer.PCBasedProduct.ProcessorId,
                                ProcessorName = d.Computer.PCBasedProduct.Processor.ProcessorName,

                                BrandId = d.Computer.PCBasedProduct.Product.BrandId,
                                BrandName = d.Computer.PCBasedProduct.Product.Brand.BrandName,

                                Quantity = d.Computer.PCBasedProduct.Product.Quantity
                            }
                        );

            return filter == null ? 
                result.ToList() : 
                result.Where(filter).ToList();

        }

        public Task<IEnumerable<DesktopViewModel>> GetAllViewModelAsync(Expression<Func<DesktopViewModel, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
