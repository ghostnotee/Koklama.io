using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    // generic constraint
    // class: be must Reference type
    // IEntity: this can implement IEntity
    // new(): this must write new 
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetT(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}