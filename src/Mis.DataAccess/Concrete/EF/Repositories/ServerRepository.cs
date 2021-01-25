using Mis.Core.Repositories;
using Mis.DataAccess.Concrete.EF.Contexts;
using Mis.DataAccess.Concrete.EF.Repositories.Base;
using Mis.Entities.Concrete;
using Mis.Entities.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mis.DataAccess.Concrete.EF.Repositories
{
    public class ServerRepository : EntityRepository<Server, MisDbContext>, IServerRepository
    {
        public IEnumerable<ServerViewModel> GetAllViewModel(Func<ServerViewModel, bool> filter = null)
        {
            IEnumerable<ServerViewModel> result = null;

            using (var context = new MisDbContext())
            {
                result = (
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
                        ).ToList();
            }

            return filter == null ?
                   result :
                   result.Where(filter);

        }

        public Task<IEnumerable<ServerViewModel>> GetAllViewModelAsync(Func<ServerViewModel, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public ServerViewModel GetByIdViewModel(Func<ServerViewModel, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<ServerViewModel> GetByIdViewModelAsync(Func<ServerViewModel, bool> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
