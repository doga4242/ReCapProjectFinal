using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.Abstract
{
   public interface IEfRepository<TEntity>
        where TEntity:class,IEntity,new()
       

    {
        List<TEntity> Getall(Expression<Func<TEntity, bool>> filter = null);
        TEntity GetById(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetByColorId(Expression<Func<TEntity,bool>>filter);
        List<TEntity> GetByBrandId(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetByCategoryId(Expression<Func<TEntity, bool>> filter);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);


        
    }
}
