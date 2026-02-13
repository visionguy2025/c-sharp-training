using Core.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DAL.Repositories.Concrete.EntityFrameworkCore
{
    public class EFBaseRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext
    {
        private readonly TContext _context;
        public EFBaseRepository(TContext context)
        {
            _context = context;
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, params string[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            query = GetQuery(includes);
            return await query.FirstOrDefaultAsync(filter);
        }
        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null, params string[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            query = GetQuery(includes);

            return filter == null
                ? await query.ToListAsync()
                : await query.Where(filter).ToListAsync();
        }
        public async Task<List<TEntity>> GetAllPaginatedAsync(int page, int size, Expression<Func<TEntity, bool>> filter = null, params string[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            query = GetQuery(includes);

            return filter == null
                ? await query.Skip((page - 1) * size).Take(size).ToListAsync()
                : await query.Skip((page - 1) * size).Take(size).Where(filter).ToListAsync();
        }
        public Task<bool> IsExistsEntity(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().AnyAsync(filter);
        }
        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }
        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
        public IQueryable<TEntity> GetQuery(string[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            foreach(var include in includes)
            {
                query = query.Include(include);
            }

            return query;
        }
    }
}
