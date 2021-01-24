using Mis.Core.Repositories.Base;
using Mis.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mis.Core.Services
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
