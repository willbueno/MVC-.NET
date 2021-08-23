using RepositoryProjeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryProjeto.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        void Delete(Func<TEntity, bool> predicate);
        void Delete(int id);
        IQueryable<TEntity> Find(Func<TEntity, bool> predicate);
        IQueryable<TEntity> FindQuery();
        IEnumerable<TEntity> GetAll();
        void Update<T>(T entity) where T : Entity;
    }
}
