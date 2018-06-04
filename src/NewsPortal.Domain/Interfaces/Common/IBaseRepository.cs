
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NewsPortal.Domain.Common.Interface
{
  
    public interface IBaseRepository<TId, TEntity> where TEntity : IEntity<TId>
    {
        TEntity Get(TId id);
        int Add(TEntity entity);
        void Update(TEntity entity); 
        void Delete(TEntity entity);
        IPagedList<TEntity> FetchPaged(Func<IQueryable<TEntity>, IQueryable<TEntity>> query, int pageIndex, int pageSize);
        IQueryable<TEntity> Query();
        TEntity Find(Expression<Func<TEntity, bool>> match);
        List<TEntity> FindAll(Expression<Func<TEntity, bool>> match);
        List<TEntity> FindAll();
        bool Any(Expression<Func<TEntity, bool>> match);

        #region Async

        Task<TEntity> GetAsync(TId id);
        Task<int> AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);

        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match);
        Task<List<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> match);

        #endregion
    }

    public interface IBaseRepository<TEntity> : IBaseRepository<int, TEntity> where TEntity : IEntity<int>
    {

    }



}
