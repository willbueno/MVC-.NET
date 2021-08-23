using RepositoryProjeto.Connection;
using RepositoryProjeto.Entities;
using RepositoryProjeto.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryProjeto.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ConexaoDB _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public RepositoryBase(ConexaoDB context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public virtual TEntity Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public virtual void Delete(Func<TEntity, bool> predicate)
        {
            _dbSet.Where(predicate).ToList()
                  .ForEach(del => _dbSet.Remove(del));

            _dbContext.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var entity = _dbSet.Find(id);

            _dbSet.Remove(entity);

            _dbContext.SaveChanges();
        }

        public virtual IQueryable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return _dbSet.Where(predicate).AsQueryable().AsNoTracking();
        }

        public virtual IQueryable<TEntity> FindQuery()
        {
            return _dbSet.AsQueryable().AsNoTracking();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public virtual void Update<T>(T entity) where T : Entity
        {
            //_dbSet.Update(entity).State = EntityState.Modified;
            var _entity = _dbSet.Find(entity.Id);
            
            if (_entity == null)
            {
                return;
            }

            _dbContext.Entry(_entity).CurrentValues.SetValues(entity);
            _dbContext.SaveChanges();
        }
    }
}
