using Microsoft.EntityFrameworkCore;
using Mis.Core.Repositories.Base;
using Mis.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mis.DataAccess.Concrete.EF.Repositories.Base
{
    /// <summary>
    /// "There are functions with sync/async."
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TContext"></typeparam>
    public class EntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public EntityRepository()
        {

        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ?
                    await context.Set<TEntity>().ToListAsync() :
                    await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }
        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }


        public virtual async Task<TEntity> GetByIdAsync(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
               return await context.Set<TEntity>().SingleOrDefaultAsync(filter);
            }
        }
        public virtual TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }


        public virtual async Task InsertAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                await context.AddAsync(entity);
                context.SaveChanges();
            }
        }
        public virtual void Insert(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.AddAsync(entity);
                context.SaveChanges();
            }
        }


        public virtual void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }

        public virtual void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }
    }
}
