using Microsoft.EntityFrameworkCore;
using Mis.Core.Repositories;
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
            using var context = new MisDbContext();

            return
                 filter == null ?
                 preQ(context).ToList() :
                 preQ(context).Where(filter).ToList();
        }

        public async Task<IEnumerable<TabletViewModel>> GetAllViewModelAsync(Expression<Func<TabletViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return
                  filter == null ?
            await preQ(context).ToListAsync() :
            await preQ(context).Where(filter).ToListAsync();
        }

        public TabletViewModel GetByIdViewModel(Expression<Func<TabletViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return
                   filter == null ?
                   preQ(context).SingleOrDefault() :
                   preQ(context).Where(filter).SingleOrDefault();
        }

        public async Task<TabletViewModel> GetByIdViewModelAsync(Expression<Func<TabletViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return
                  filter == null ?
            await preQ(context).SingleOrDefaultAsync() :
            await preQ(context).Where(filter).SingleOrDefaultAsync();
        }


        IQueryable<TabletViewModel> preQ(DbContext context)
        {
            return (
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
        }
    }
}
