using Mis.Core.Repositories.Entity.Base;
using Mis.Entities.Abstract;

namespace Mis.Business.Abstract.Base
{

    public interface IService<T> : IEntityRepository<T> where T : class, IEntity, new()
    {
       
    }

    //public interface IService<T> where T: class
    //{
    //    Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null);
    //    Task<T> GetById(Expression<Func<T, bool>> filter);
    //    Task Insert(T entity);
    //    void Update(T entity);
    //    void Delete(T entity);
    //}
}
