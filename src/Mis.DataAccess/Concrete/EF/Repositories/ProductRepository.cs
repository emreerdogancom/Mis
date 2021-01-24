using Mis.Core.Repositories;
using Mis.DataAccess.Concrete.EF.Contexts;
using Mis.DataAccess.Concrete.EF.Repositories.Base;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.EF.Repositories
{
    public class ProductRepository : EntityRepository<Product, MisDbContext>, IProductRepository
    {
        
    }
}
