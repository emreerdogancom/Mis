using Mis.Core.Repositories.Entity;
using Mis.DataAccess.Concrete.EF.Contexts;
using Mis.DataAccess.Concrete.EF.Repositories.Base;
using Mis.Entities.Concrete;

namespace Mis.DataAccess.Concrete.EF.Repositories
{
    public class ProcessorRepository : EntityRepository<Processor, MisDbContext>, IProcessorRepository
    {
        
    }
}
