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
    public class LaptopRepository : EntityRepository<Laptop, MisDbContext>, ILaptopRepository
    {
        public IEnumerable<LaptopViewModel> GetAllViewModel(Expression<Func<LaptopViewModel, bool>> filter = null)
        {
            var context = new MisDbContext();

            var result = (
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

            return filter == null ?
                result.ToList() :
                result.Where(filter).ToList();

        }

        public Task<IEnumerable<LaptopViewModel>> GetAllViewModelAsync(Expression<Func<LaptopViewModel, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
