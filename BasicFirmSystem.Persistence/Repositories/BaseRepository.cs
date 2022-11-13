using BasicFirmSystem.Domain.Entities;
using BasicFirmSystem.Persistence.Paging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Persistence.Repositories
{
    public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : Entity
        where TContext : DbContext
    {
        public BaseRepository(TContext context)
        {
            Context=context;
        }

        protected TContext Context { get; }
        
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await Context.Set<TEntity>().AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<int> CountAsync()
        {
            return await Context.Set<TEntity>().CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> match)
        {
            return await Context.Set<TEntity>().CountAsync(match);
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteByIDAsync(int id)
        {
            var findId = await Context.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
            if (findId != null){
                Context.Set<TEntity>().Remove(findId);
                return true;
            }
            else { return false; }
        }

        public async Task<ICollection<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> match)
        {
            var query = Context.Set<TEntity>().AsNoTracking();
            return match != null ? await query.Where(match).ToListAsync()
                : await query.ToListAsync();

        }

        public async Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> match)
        {
            var query = Context.Set<TEntity>().AsNoTracking();
            return await query?.FirstOrDefaultAsync(match);
        }

        public Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IPaginate<TEntity>> GetListAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, int index = 0, int size = 10, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<IPaginate<TEntity>> GetListByDynamicAsync(Dynamic.Dynamic dynamic, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, int index = 0, int size = 10, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> MaxAsync<TResult>(Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Query()
        {
            throw new NotImplementedException();
        }

        public ICollection<TEntity1> SelectAll<TEntity1>(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, TEntity1>> selector) where TEntity1 : class
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TEntity1>> SelectAllAsync<TEntity1>(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, TEntity1>> selector) where TEntity1 : class
        {
            throw new NotImplementedException();
        }

        public Task<TEntity1> SelectOneAsync<TEntity1>(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, TEntity1>> selector) where TEntity1 : class
        {
            throw new NotImplementedException();
        }

        public Task<double?> SumAsync(Expression<Func<TEntity, double?>> selector, Expression<Func<TEntity, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> ToIQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity t, object key)
        {
            throw new NotImplementedException();
        }
    }
}
