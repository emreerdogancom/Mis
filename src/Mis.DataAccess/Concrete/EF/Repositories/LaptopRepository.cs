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
    public class LaptopRepository : EntityRepository<Laptop, MisDbContext>, ILaptopRepository
    {
        public IEnumerable<LaptopViewModel> GetAllViewModel(Func<LaptopViewModel, bool> filter = null)
        {
            IEnumerable<LaptopViewModel> result = null;

            using (var context = new MisDbContext())
            {
                result = (
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
                        ).ToList();
            }


            return filter == null ?
                   result :
                   result.Where(filter);

        }

        public Task<IEnumerable<LaptopViewModel>> GetAllViewModelAsync(Func<LaptopViewModel, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public LaptopViewModel GetByIdViewModel(Func<LaptopViewModel, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<LaptopViewModel> GetByIdViewModelAsync(Func<LaptopViewModel, bool> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
