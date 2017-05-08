using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using static Dapper.SqlMapper;
using Inman.Infrastructure.Data;
using Inman.Infrastructure.Data.DapperExtensions;
using System.Data.Common;
using System.Linq.Expressions;
using Inman.Infrastructure.Data.DapperExtensions.Expressions;

namespace Inman.Platform.Data.Repository
{
    public class Repository<TEntity, TPrimaryKey> :  IRepository<TEntity, TPrimaryKey> where TEntity : BaseEntity, IEntity<TPrimaryKey>
    {
        protected IDbConnection _dbConnection;
        public Repository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IDbTransaction BeginTransaction()
        {
            return _dbConnection.BeginTransaction();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            return _dbConnection.BeginTransaction(il);
        }

        #region statistics
        public int Count(object predicate, IDbTransaction transaction = null)
        {
            return _dbConnection.Count<TEntity>(predicate, transaction);
        }

        public Task<int> CountAsync(object predicate, IDbTransaction transaction = null)
        {
            return Task.FromResult(this.Count(predicate, transaction));
        }
        #endregion

        #region query
        public TEntity Get(int id, IDbTransaction transaction = null)
        {
            return _dbConnection.Get<TEntity>(id, transaction);
        }

        public Task<TEntity> GetAsync(int id, IDbTransaction transaction = null)
        {
           return Task.FromResult( this.Get(id, transaction));
        }

        public TEntity Get(object predicate, IDbTransaction transaction = null)
        {
            return this.GetList(predicate, transaction: transaction).SingleOrDefault();
        }

        public Task<TEntity> GetAsync(object predicate, IDbTransaction transaction = null)
        {
            return Task.FromResult(this.Get(predicate, transaction: transaction));
        }

        public IEnumerable<TEntity> GetListPaged(object predicate,IList<ISort> sort, int page, int resultsPerPage, IDbTransaction transaction = null)
        {
            return _dbConnection.GetPage<TEntity>(predicate, sort, page, resultsPerPage, transaction);
        }

        public Task<IEnumerable<TEntity>> GetListPagedAsync(object predicate, IList<ISort> sort, int page, int resultsPerPage, IDbTransaction transaction = null)
        {
            return _dbConnection.GetPageAsync<TEntity>(predicate,  sort,  page,  resultsPerPage, transaction);
        }

        public IEnumerable<TEntity> GetListPaged(Expression<Func<TEntity, bool>> predicate, int page, int resultsPerPage, string sortingProperty, bool ascending = true, IDbTransaction transaction = null)
        {
            return _dbConnection.GetPage<TEntity>(
                predicate.ToPredicateGroup<TEntity, TPrimaryKey>(),
                new List<ISort> { new Sort { Ascending = ascending, PropertyName = sortingProperty } },
                page,
                resultsPerPage,
                transaction);
        }
       



        public IEnumerable<TEntity> GetList(object predicate = null, IList<ISort> sort = null, IDbTransaction transaction = null)
        {
            return _dbConnection.GetList<TEntity>(predicate, sort, transaction);
        }

        public Task<IEnumerable<TEntity>> GetListAsync(object predicate = null, IList<ISort> sort = null, IDbTransaction transaction = null)
        {
            return Task.FromResult(this.GetList(predicate,sort,transaction));
        }
        #endregion

        #region udpate
        public bool Update(TEntity entity, IDbTransaction transaction = null)
        {
            entity.ModifiedOn = DateTime.Now;
            return _dbConnection.Update(entity, transaction);
        }
        public  Task<bool> UpdateAsync(TEntity entity, IDbTransaction transaction = null)
        {
            entity.ModifiedOn = DateTime.Now;
            return Task.FromResult(this.Update(entity, transaction));
        }
        #endregion
        
        #region insert
        public int Insert(TEntity entity, IDbTransaction transaction = null)
        {
            entity.ModifiedOn = entity.CreatedOn = DateTime.Now;
            return _dbConnection.Insert(entity, transaction);
        }
        public Task<int> InsertAsync(TEntity entity, IDbTransaction transaction = null)
        {
            entity.ModifiedOn = entity.CreatedOn = DateTime.Now;
            return Task.FromResult(this.Insert(entity, transaction));
        }
        public void Insert(IEnumerable<TEntity> entities, IDbTransaction transaction = null)
        {
            _dbConnection.Insert(entities, transaction);
        }

        public Task InsertAsync(IEnumerable<TEntity> entities, IDbTransaction transaction = null)
        {
            return Task.Run(()=>Insert(entities, transaction));
        }
        #endregion
        
        #region delete

        public bool Delete(TEntity entity, IDbTransaction transaction = null)
        {
            entity.ModifiedOn = DateTime.Now;
            return _dbConnection.Update(entity, transaction);
        }
        public Task<bool> DeleteAsync(TEntity entity, IDbTransaction transaction = null)
        {
            entity.ModifiedOn = DateTime.Now;
            return Task.FromResult(this.Update(entity, transaction));
        }


        public int Delete(int id, IDbTransaction transaction = null)
        {
            string sql = $"UPDATE [{typeof(TEntity).Name}] SET [Deleted]=1,[ModifiedOn]='{DateTime.Now}' WHERE [Id]={id}";
            return _dbConnection.Execute(sql,transaction: transaction);
        }
        public Task<int> DeleteAsync(int id, IDbTransaction transaction = null)
        {
            string sql = $"UPDATE [{typeof(TEntity).Name}] SET [Deleted]=1,[ModifiedOn]='{DateTime.Now}' WHERE [Id]={id}";
            return _dbConnection.ExecuteAsync(sql,transaction: transaction);
        }


        public int Delete(IEnumerable<int> ids, IDbTransaction transaction = null)
        {
            string sql = $"UPDATE [{typeof(TEntity).Name}] SET [Deleted]=1,[ModifiedOn]='{DateTime.Now}' WHERE [Id] in({ string.Join(",", ids) })";
            return _dbConnection.Execute(sql,transaction: transaction);
        }
        public Task<int> DeleteAsync(IEnumerable<int> ids, IDbTransaction transaction = null)
        {
            string sql = $"UPDATE [{typeof(TEntity).Name}] SET [Deleted]=1,[ModifiedOn]='{DateTime.Now}' WHERE [Id] in({ string.Join(",", ids) })";
            return _dbConnection.ExecuteAsync(sql,transaction: transaction);
        }

        public bool Delete(object predicate, IDbTransaction transaction = null)
        {
            return _dbConnection.Delete<TEntity>(predicate, transaction);
        }
        #endregion
    }
}
