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
    public class TabletRepository : EntityRepository<Tablet, MisDbContext>, ITabletRepository
    {
        public IEnumerable<TabletViewModel> GetAllViewModel(Func<TabletViewModel, bool> filter = null)
        {
            IEnumerable<TabletViewModel> result = null;

            using (var context = new MisDbContext())
            {
                result = (
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
                        ).ToList();
            }

            return filter == null ?
                   result :
                   result.Where(filter);

        }

        public Task<IEnumerable<TabletViewModel>> GetAllViewModelAsync(Func<TabletViewModel, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public TabletViewModel GetByIdViewModel(Func<TabletViewModel, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<TabletViewModel> GetByIdViewModelAsync(Func<TabletViewModel, bool> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
