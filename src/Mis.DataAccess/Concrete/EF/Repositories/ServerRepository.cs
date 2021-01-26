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
    public class ServerRepository : EntityRepository<Server, MisDbContext>, IServerRepository
    {
        public IEnumerable<ServerViewModel> GetAllViewModel(Expression<Func<ServerViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return
                 filter == null ?
                 preQ(context).ToList() :
                 preQ(context).Where(filter).ToList();
        }

        public async Task<IEnumerable<ServerViewModel>> GetAllViewModelAsync(Expression<Func<ServerViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return
                  filter == null ?
            await preQ(context).ToListAsync() :
            await preQ(context).Where(filter).ToListAsync();
        }


        public ServerViewModel GetByIdViewModel(Expression<Func<ServerViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return
                   filter == null ?
                   preQ(context).SingleOrDefault() :
                   preQ(context).Where(filter).SingleOrDefault();
        }

        public async Task<ServerViewModel> GetByIdViewModelAsync(Expression<Func<ServerViewModel, bool>> filter = null)
        {
            using var context = new MisDbContext();

            return
                  filter == null ?
            await preQ(context).SingleOrDefaultAsync() :
            await preQ(context).Where(filter).SingleOrDefaultAsync();
        }


        IQueryable<ServerViewModel> preQ(DbContext context)
        {
            return (
                    from d in context.Set<Server>()
                    select new ServerViewModel
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
