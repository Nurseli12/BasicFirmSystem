using Core.Domain.Entities;
using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories
{
    public interface IBaseRepository<T> : IQuery<T> where T: Entity
    {
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IPaginate<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                        Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                        int index = 0, int size = 10, bool enableTracking = true,
                                        CancellationToken cancellationToken = default);

        Task<IPaginate<T>> GetListByDynamicAsync(Dynamic.Dynamic dynamic,
                                                 Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                                 int index = 0, int size = 10, bool enableTracking = true,
                                                 CancellationToken cancellationToken = default);

        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);


        ////////////////
        ///
        Task<IEnumerable<T>> GetList(Expression<Func<T, bool>> filter = null);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> match); //Bu saçma
        Task<TResult> MaxAsync<TResult>(Expression<Func<T, TResult>> selector, Expression<Func<T, bool>> predicate = null);
        Task<double?> SumAsync(Expression<Func<T, double?>> selector, Expression<Func<T, bool>> predicate = null);
        Task<T> FindOneAsync(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<ICollection<TEntity>> SelectAllAsync<TEntity>(Expression<Func<T, bool>> match, Expression<Func<T, TEntity>> selector) where TEntity : class;
        Task<TEntity> SelectOneAsync<TEntity>(Expression<Func<T, bool>> match, Expression<Func<T, TEntity>> selector) where TEntity : class;
        IQueryable<T> ToIQueryable();
        Task<T> GetAsync(int id);
        Task<T> UpdateAsync(T t, object key);
        ICollection<TEntity> SelectAll<TEntity>(Expression<Func<T, bool>> match, Expression<Func<T, TEntity>> selector) where TEntity : class;
        Task<bool> DeleteByIDAsync(int id);
    }
}
