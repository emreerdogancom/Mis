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
    public class LaptopRepository : EntityRepository<Laptop, MisDbContext>, ILaptopRepository
    {
        public IEnumerable<LaptopViewModel> GetAllViewModel(Expression<Func<LaptopViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return
                 filter == null ?
                 preQ(context).ToList() :
                 preQ(context).Where(filter).ToList();
        }

        public async Task<IEnumerable<LaptopViewModel>> GetAllViewModelAsync(Expression<Func<LaptopViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return
                  filter == null ?
            await preQ(context).ToListAsync() :
            await preQ(context).Where(filter).ToListAsync();
        }


        public LaptopViewModel GetByIdViewModel(Expression<Func<LaptopViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return
                   filter == null ?
                   preQ(context).SingleOrDefault() :
                   preQ(context).Where(filter).SingleOrDefault();
        }

        public async Task<LaptopViewModel> GetByIdViewModelAsync(Expression<Func<LaptopViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return
                  filter == null ?
            await preQ(context).SingleOrDefaultAsync() :
            await preQ(context).Where(filter).SingleOrDefaultAsync();
        }


        IQueryable<LaptopViewModel> preQ(DbContext context)
        {
            return (
                    from d in context.Set<Laptop>()
                    select new LaptopViewModel
                    {
                        Id = d.Id,
                        ScreenSize = d.ScreenSize,
                        UsbPorts = d.UsbPorts,

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
