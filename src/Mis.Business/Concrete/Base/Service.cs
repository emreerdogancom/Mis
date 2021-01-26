using Mis.Core.Repositories.Entity.Base;
using Mis.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mis.Business.Concrete.Base
{
    public class Service<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IEntityRepository<TEntity> _repository;
        public Service(IEntityRepository<TEntity> repository)
        {
            _repository = repository;
        }



        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return await _repository.GetAllAsync(filter);
        }

        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return _repository.GetAll(filter);
        }



        public virtual async Task<TEntity> GetByIdAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _repository.GetByIdAsync(filter);
        }

        public virtual TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            return _repository.GetById(filter);
        }



        public virtual async Task InsertAsync(TEntity entity)
        {
            await _repository.InsertAsync(entity);
        }

        public virtual void Insert(TEntity entity)
        {
            _repository.Insert(entity);
        }



        public virtual void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

    }
}
