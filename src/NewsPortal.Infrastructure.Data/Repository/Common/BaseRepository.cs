
using Microsoft.EntityFrameworkCore;
using NewsPortal.Domain.Common.Interface;
using NewsPortal.Domain.Entities.Common;
using NewsPortal.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NewsPortal.Infrastructure.Data.Repository.Common
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity
    {
        protected readonly NewsPortalDbContext _dbContext;

        public BaseRepository(NewsPortalDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        #region CRUD

        public TEntity Get(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public int Add(TEntity entity)
        {

            var addedItem = _dbContext.Set<TEntity>().Add(entity);
            Commit();

            var idProperty = addedItem.GetType().GetProperty("Id").GetValue(entity, null);
            return (int)idProperty;
        }

        public void Update(TEntity entity)
        { 
            if(entity.Id <= 0)
            {
                _dbContext.Set<TEntity>().Add(entity);
            }
            else
            {
                _dbContext.Set<TEntity>().Update(entity);
            } 
            Commit();
        }

        public void Delete(TEntity entity)
        {

            _dbContext.Set<TEntity>().Remove(entity);
            Commit();
        }

        public IPagedList<TEntity> FetchPaged(Func<IQueryable<TEntity>, IQueryable<TEntity>> query, int pageIndex,
            int pageSize)
        {

            return FetchPagedResults(query(Query()), pageIndex, pageSize);
        }

        public IQueryable<TEntity> Query()
        {
            return _dbContext.Set<TEntity>().AsQueryable();
        }

        private IPagedList<TEntity> FetchPagedResults(IQueryable<TEntity> query, int pageIndex, int pageSize)
        {
            var futureCount = query.Count();

            var isOrdered = query.Expression.Type == typeof(IOrderedQueryable<TEntity>);
            if (!isOrdered)
                query = query.OrderBy(x => x.Id);

            return new PagedList<TEntity>(query.Skip(pageSize * pageIndex).Take(pageSize),
                pageIndex, pageSize, futureCount);
        }

        public TEntity Find(Expression<Func<TEntity, bool>> match)
        {
            return _dbContext.Set<TEntity>().SingleOrDefault(match);
        }

        public List<TEntity> FindAll(Expression<Func<TEntity, bool>> match)
        {
            return _dbContext.Set<TEntity>().Where(match).ToList();
        }

        public List<TEntity> FindAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public bool Any(Expression<Func<TEntity, bool>> match)
        {
            return _dbContext.Set<TEntity>().Any(match);
        }

        #endregion

        #region Async

        public async Task<IList<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<int> AddAsync(TEntity entity)
        {

            var addedItem = _dbContext.Set<TEntity>().Add(entity);
            await CommitAsync();

            var idProperty = addedItem.GetType().GetProperty("Id").GetValue(entity, null);
            return (int)idProperty;
        }

        public async Task UpdateAsync(TEntity entity)
        {
            if(entity.Id <=0)
            {
                _dbContext.Set<TEntity>().Add(entity);
            }
            else
            {
                _dbContext.Set<TEntity>().Update(entity);
            }
             
            await CommitAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            await CommitAsync();
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match)
        {
            return await _dbContext.Set<TEntity>().SingleOrDefaultAsync(match);
        }

        public async Task<List<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> match)
        {
            return await _dbContext.Set<TEntity>().Where(match).ToListAsync();
        }

        #endregion

        #region Commit

        private void Commit()
        {
            _dbContext.SaveChanges();
        }

        private async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        #endregion


    }
}
