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
    public class DesktopRepository : EntityRepository<Desktop, MisDbContext>, IDesktopRepository
    {
        public IEnumerable<DesktopViewModel> GetAllViewModel(Func<DesktopViewModel, bool> filter = null)
        {
            IEnumerable<DesktopViewModel> result = null;

            using (var context = new MisDbContext())
            {
                result = (
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
                        ).ToList();
            }

            return filter == null ? 
                   result : 
                   result.Where(filter);

        }

        public Task<IEnumerable<DesktopViewModel>> GetAllViewModelAsync(Func<DesktopViewModel, bool> filter = null)
        {
            throw new NotImplementedException();
        }


        public DesktopViewModel GetByIdViewModel(Func<DesktopViewModel, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<DesktopViewModel> GetByIdViewModelAsync(Func<DesktopViewModel, bool> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
