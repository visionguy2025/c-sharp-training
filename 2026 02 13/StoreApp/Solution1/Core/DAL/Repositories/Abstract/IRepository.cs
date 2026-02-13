using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DAL.Repositories.Abstract
{
    public interface IRepository<TEntity>
        where TEntity : class, new()
    {
        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, params string[] includes);
        public Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null, params string[] includes);
        public Task<List<TEntity>> GetAllPaginatedAsync(int page, int size, Expression<Func<TEntity, bool>> filter = null, params string[] includes);
        public Task<bool> IsExistsEntity(Expression<Func<TEntity, bool>> filter);
        public Task AddAsync(TEntity entity);
        public void Update(TEntity entity);
        public void Remove(TEntity entity);
        public IQueryable<TEntity> GetQuery(string[] includes);
    }
}
