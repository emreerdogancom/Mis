using Mis.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mis.Core.Repositories.Base
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null);


        Task<T> GetByIdAsync(Expression<Func<T, bool>> filter);
        T GetById(Expression<Func<T, bool>> filter);


        Task InsertAsync(T entity);
        void Insert(T entity);


        void Update(T entity);
        void Delete(T entity);
    }
}
