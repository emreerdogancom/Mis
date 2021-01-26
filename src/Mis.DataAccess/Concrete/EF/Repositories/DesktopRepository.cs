using Microsoft.EntityFrameworkCore;
using Mis.Core.Repositories.Entity;
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
            using var context = new MisDbContext();

            return 
                   filter == null ?
                   preQ(context).ToList() :
                   preQ(context).Where(filter).ToList();
        }

        public async Task<IEnumerable<DesktopViewModel>> GetAllViewModelAsync(Expression<Func<DesktopViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return 
                  filter == null ?
            await preQ(context).ToListAsync() :
            await preQ(context).Where(filter).ToListAsync();
        }


        public DesktopViewModel GetByIdViewModel(Expression<Func<DesktopViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return 
                   filter == null ?
                   preQ(context).SingleOrDefault() :
                   preQ(context).Where(filter).SingleOrDefault();
        }

        public async Task<DesktopViewModel> GetByIdViewModelAsync(Expression<Func<DesktopViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return 
                  filter == null ?
            await preQ(context).SingleOrDefaultAsync() :
            await preQ(context).Where(filter).SingleOrDefaultAsync();
        }


        IQueryable<DesktopViewModel> preQ(DbContext context)
        {
            return (
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
        }
    }
}
