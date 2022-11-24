using Core.Domain.Entities;
using Core.Persistence.Dynamic;
using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories
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
            var findId = await Context.Set<TEntity>().FirstOrDefaultAsync(x => x.ID == id);
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

        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var query = Context.Set<TEntity>().AsNoTracking();
            return await query?.FirstOrDefaultAsync(predicate);
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await Context.Set<TEntity>().FindAsync(id);


        }

        public async Task<IPaginate<TEntity>> GetListAsync(Expression<Func<TEntity,
            bool>>? predicate = null, Func<IQueryable<TEntity>,
                IOrderedQueryable<TEntity>>? orderBy = null, 
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity,
                object>>? include = null, int index = 0,
            int size = 10, bool enableTracking = true,
            CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include != null) queryable = include(queryable);
            if (predicate != null) queryable = queryable.Where(predicate);
            if (orderBy != null)
                return await orderBy(queryable).ToPaginateAsync(index, size, 0, cancellationToken);
            return await queryable.ToPaginateAsync(index, size, 0, cancellationToken);
        }

        public async Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? Context.Set<TEntity>().ToList()
                : Context.Set<TEntity>().Where(filter);
        }

        public async Task<IPaginate<TEntity>> GetListByDynamicAsync(Dynamic.Dynamic dynamic,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity,
                object>>? include = null, int index = 0, int size = 10,
            bool enableTracking = true, 
            CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query().AsQueryable().ToDynamic(dynamic);
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include != null) queryable = include(queryable);
            return await queryable.ToPaginateAsync(index, size, 0, cancellationToken);
        }

        public async Task<TResult> MaxAsync<TResult>(Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, bool>> predicate = null)
        {
            IQueryable<TEntity> query = Context.Set<TEntity>().AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate);

            }
            return await query.MaxAsync(selector);


        }

        public IQueryable<TEntity> Query()
        {
            return Context.Set<TEntity>();
        }

        public  ICollection<TEntity1> SelectAll<TEntity1>(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, TEntity1>> selector) where TEntity1 : class
        {
            IQueryable<TEntity> query =  Context.Set<TEntity>().AsNoTracking();
            if (match != null)
            {
                query = query.Where(match);
            }
            return  query.Select(selector).ToList();
        }

        public async Task<ICollection<TEntity1>> SelectAllAsync<TEntity1>(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, TEntity1>> selector) where TEntity1 : class
        {
            IQueryable<TEntity> query = Context.Set<TEntity>().AsNoTracking();
            if (match != null)
            {
                query = query.Where(match);
            }
            return await query.Select(selector).ToListAsync();
        }

        public async Task<TEntity1> SelectOneAsync<TEntity1>(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, TEntity1>> selector) where TEntity1 : class
        {
            IQueryable<TEntity> query = Context.Set<TEntity>().AsNoTracking();
            if (match != null)
            {
                query = query.Where(match);
            }
            return await query.Select(selector).FirstOrDefaultAsync();
        }

        public async Task<double?> SumAsync(Expression<Func<TEntity, double?>> selector, Expression<Func<TEntity, bool>> predicate = null)
        {
            IQueryable<TEntity> query = Context.Set<TEntity>().AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return await query.SumAsync(selector);
        }

        public IQueryable<TEntity> ToIQueryable()
        {
            return Context.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity t, object key)
        {
            if (t == null)
            {
                return null;
            }

            TEntity exist = await Context.Set<TEntity>().FindAsync(key);

            if (exist != null)
            {
                Context.Entry(exist).CurrentValues.SetValues(t);
                await Context.SaveChangesAsync();
            }
            return exist;
        }
    }
}
