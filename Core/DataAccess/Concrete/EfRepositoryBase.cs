using Core.DataAccess.Abstract;
using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.Concrete
{
    public class EfRepositoryBase<TEntity, TContext> : IEfRepository<TEntity>
         where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
       
        

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntry = context.Entry(entity);
                addedEntry.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
           using(TContext context = new TContext())
            {
                var deletedEntry = context.Entry(entity);
                deletedEntry.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> Getall(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public List<TEntity> GetByBrandId(Expression<Func<TEntity, bool>> filter)
        {
            using(TContext context= new TContext())
            {
                return context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public List<TEntity> GetByCategoryId(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public List<TEntity> GetByColorId(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetById(Expression<Func<TEntity,bool>>filter)
        {
           using(TContext context= new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Update(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                var updatedEntry = context.Entry(entity);
                updatedEntry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
