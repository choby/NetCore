using Dapper;
using Inman.Infrastructure.Data.DapperExtensions;
using Inman.Infrastructure.Data.DapperExtensions.Expressions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using System.Linq;

namespace Inman.Infrastructure.Data.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public class DapperRepository<TEntity, TPrimaryKey> : IDapperRepository<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        IDbConnection _dbConnection;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbConnection"></param>
        public DapperRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual IDbConnection Connection
        {
          get { return _dbConnection; }
        }


        //public virtual IDbTransaction ActiveTransaction
        //{
        //    get { return null; }
        //}

        #region id-list
        public virtual IEnumerable<int> GetIds(IDbTransaction transaction = null)
        {
            return Connection.GetFieldList<TEntity,int>("Id", transaction: transaction);
        }

        public virtual Task<IEnumerable<int>> GetIdsAsync(IDbTransaction transaction = null)
        {
            return Task.FromResult(Connection.GetFieldList<TEntity, int>("Id", transaction: transaction));
        }

        public virtual IEnumerable<int> GetIds(object predicate, IDbTransaction transaction = null)
        {
            return Connection.GetFieldList<TEntity, int>("Id", predicate, transaction: transaction);
        }
        public virtual Task<IEnumerable<int>> GetIdsAsync(object predicate, IDbTransaction transaction = null)
        {
            return Task.FromResult(Connection.GetFieldList<TEntity, int>("Id", predicate, transaction: transaction));
        }
        #endregion


        #region single
        public  TEntity Get(TPrimaryKey id, IDbTransaction transaction = null)
        {
            return Connection.Get<TEntity>(id, transaction);
        }

        public  Task<TEntity> GetAsync(TPrimaryKey id, IDbTransaction transaction = null)
        {
            return Connection.GetAsync<TEntity>(id, transaction);
        }

        public TEntity Get(object predicate, IDbTransaction transaction = null)
        {
            return this.GetList(predicate, transaction: transaction).SingleOrDefault();
        }

        public Task<TEntity> GetAsync(object predicate, IDbTransaction transaction = null)
        {
            return Task.FromResult(this.Get(predicate, transaction: transaction));
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null)
        {
            return this.GetList(predicate, transaction: transaction).SingleOrDefault();
        }

        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null)
        {
            return Task.FromResult(this.Get(predicate, transaction: transaction));
        }
        #endregion


        #region list
        public  IEnumerable<TEntity> GetList(IDbTransaction transaction = null)
        {
            return Connection.GetList<TEntity>(transaction: transaction);
        }

        public  IEnumerable<TEntity> GetList(object predicate, IDbTransaction transaction = null)
        {
            return Connection.GetList<TEntity>(predicate, transaction: transaction);
        }

        public  Task<IEnumerable<TEntity>> GetListAsync(IDbTransaction transaction = null)
        {
            return Connection.GetListAsync<TEntity>(transaction: transaction);
        }

        public  Task<IEnumerable<TEntity>> GetListAsync(object predicate, IDbTransaction transaction = null)
        {
            return Connection.GetListAsync<TEntity>(predicate, transaction: transaction);
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null)
        {
            return Connection.GetList<TEntity>(predicate.ToPredicateGroup<TEntity, TPrimaryKey>(), transaction: transaction);
        }

        public Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null)
        {
            return Connection.GetListAsync<TEntity>(predicate.ToPredicateGroup<TEntity, TPrimaryKey>(), transaction: transaction);
        }


        public IEnumerable<TEntity> Query(string query, object parameters, IDbTransaction transaction = null)
        {
            return Connection.Query<TEntity>(query, parameters, transaction);
        }

        public Task<IEnumerable<TEntity>> QueryAsync(string query, object parameters, IDbTransaction transaction = null)
        {
            return Connection.QueryAsync<TEntity>(query, parameters, transaction);
        }

        public IEnumerable<TAny> Query<TAny>(string query, IDbTransaction transaction = null) where TAny : class
        {
            return Connection.Query<TAny>(query, transaction: transaction);
        }

        public Task<IEnumerable<TAny>> QueryAsync<TAny>(string query, IDbTransaction transaction = null) where TAny : class
        {
            return Connection.QueryAsync<TAny>(query, transaction: transaction);
        }

        public IEnumerable<TAny> Query<TAny>(string query, object parameters, IDbTransaction transaction = null) where TAny : class
        {
            return Connection.Query<TAny>(query, parameters, transaction);
        }

        public Task<IEnumerable<TAny>> QueryAsync<TAny>(string query, object parameters, IDbTransaction transaction = null) where TAny : class
        {
            return Connection.QueryAsync<TAny>(query, parameters, transaction);
        }
        #endregion


        #region paged

        public  IEnumerable<TEntity> GetListPaged(
            object predicate,
            int pageNumber,
            int itemsPerPage,
            string sortingProperty,
            bool ascending = true,
            IDbTransaction transaction = null)
        {
            return Connection.GetPage<TEntity>(
                predicate,
                new List<ISort> { new Sort { Ascending = ascending, PropertyName = sortingProperty } },
                pageNumber,
                itemsPerPage,
                transaction);
        }

        public  Task<IEnumerable<TEntity>> GetListPagedAsync(
            object predicate,
            int pageNumber,
            int itemsPerPage,
            string sortingProperty,
            bool ascending = true,
            IDbTransaction transaction = null)
        {
            return Connection.GetPageAsync<TEntity>(
                predicate,
                new List<ISort> { new Sort { Ascending = ascending, PropertyName = sortingProperty } },
                pageNumber,
                itemsPerPage,
                transaction);
        }

        public IEnumerable<TEntity> GetListPaged(Expression<Func<TEntity, bool>> predicate, int pageNumber, int itemsPerPage, string sortingProperty, bool ascending = true, IDbTransaction transaction = null)
        {
            return Connection.GetPage<TEntity>(
                predicate.ToPredicateGroup<TEntity, TPrimaryKey>(),
                new List<ISort> { new Sort { Ascending = ascending, PropertyName = sortingProperty } },
                pageNumber,
                itemsPerPage,
                transaction);
        }

        public IEnumerable<TEntity> GetListPaged(Expression<Func<TEntity, bool>> predicate, int pageNumber, int itemsPerPage, bool ascending = true, IDbTransaction transaction = null, params Expression<Func<TEntity, object>>[] sortingExpression)
        {
            return Connection.GetPage<TEntity>(predicate.ToPredicateGroup<TEntity, TPrimaryKey>(), sortingExpression.ToSortable(ascending), pageNumber, itemsPerPage, transaction);
        }

        public Task<IEnumerable<TEntity>> GetListPagedAsync(Expression<Func<TEntity, bool>> predicate, int pageNumber, int itemsPerPage, string sortingProperty, bool ascending = true, IDbTransaction transaction = null)
        {
            return Connection.GetPageAsync<TEntity>(
                predicate.ToPredicateGroup<TEntity, TPrimaryKey>(),
                new List<ISort> { new Sort { Ascending = ascending, PropertyName = sortingProperty } },
                pageNumber,
                itemsPerPage,
                transaction);
        }

        public Task<IEnumerable<TEntity>> GetListPagedAsync([NotNull] Expression<Func<TEntity, bool>> predicate, int pageNumber, int itemsPerPage, bool ascending = true, IDbTransaction transaction = null, [NotNull] params Expression<Func<TEntity, object>>[] sortingExpression)
        {
            return Task.FromResult(GetListPaged(predicate, pageNumber, itemsPerPage, ascending, transaction,sortingExpression));
        }
        #endregion


        #region set
        public IEnumerable<TEntity> GetSet(object predicate, int firstResult, int maxResults, string sortingProperty, bool ascending = true, IDbTransaction transaction = null)
        {
            return Connection.GetSet<TEntity>(
                predicate,
                new List<ISort> { new Sort { Ascending = ascending, PropertyName = sortingProperty } },
                firstResult,
                maxResults,
                transaction);
        }

        public Task<IEnumerable<TEntity>> GetSetAsync(object predicate, int firstResult, int maxResults, string sortingProperty, bool ascending = true, IDbTransaction transaction = null)
        {
            return Connection.GetSetAsync<TEntity>(
                predicate,
                new List<ISort> { new Sort { Ascending = ascending, PropertyName = sortingProperty } },
                firstResult,
                maxResults,
                transaction);
        }



        public IEnumerable<TEntity> GetSet(Expression<Func<TEntity, bool>> predicate, int firstResult, int maxResults, string sortingProperty, bool ascending = true, IDbTransaction transaction = null)
        {
            return Connection.GetSet<TEntity>(
                predicate.ToPredicateGroup<TEntity, TPrimaryKey>(),
                new List<ISort> { new Sort { Ascending = ascending, PropertyName = sortingProperty } },
                firstResult,
                maxResults,
                transaction
            );
        }

        public IEnumerable<TEntity> GetSet(Expression<Func<TEntity, bool>> predicate, int firstResult, int maxResults, bool ascending = true, IDbTransaction transaction = null, params Expression<Func<TEntity, object>>[] sortingExpression)
        {
            return Connection.GetSet<TEntity>(predicate.ToPredicateGroup<TEntity, TPrimaryKey>(), sortingExpression.ToSortable(ascending), firstResult, maxResults, transaction);
        }

        public Task<IEnumerable<TEntity>> GetSetAsync([NotNull] Expression<Func<TEntity, bool>> predicate, int firstResult, int maxResults, bool ascending = true, IDbTransaction transaction = null, [NotNull] params Expression<Func<TEntity, object>>[] sortingExpression)
        {
            return Task.FromResult(GetSet(predicate, firstResult, maxResults, ascending, transaction, sortingExpression));
        }

        public Task<IEnumerable<TEntity>> GetSetAsync(Expression<Func<TEntity, bool>> predicate, int firstResult, int maxResults, string sortingProperty, bool ascending = true, IDbTransaction transaction = null)
        {
            return Connection.GetSetAsync<TEntity>(
                predicate.ToPredicateGroup<TEntity, TPrimaryKey>(),
                new List<ISort> { new Sort { Ascending = ascending, PropertyName = sortingProperty } },
                firstResult,
                maxResults,
                transaction
            );
        }
        #endregion

        #region count

        public int Count(object predicate, IDbTransaction transaction = null)
        {
            return Connection.Count<TEntity>(predicate, transaction);
        }

        public  Task<int> CountAsync(object predicate, IDbTransaction transaction = null)
        {
            return Connection.CountAsync<TEntity>(predicate, transaction);
        }
        public int Count(Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null)
        {
            return Connection.Count<TEntity>(predicate.ToPredicateGroup<TEntity, TPrimaryKey>(), transaction);
        }

        public  Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null)
        {
            return Connection.CountAsync<TEntity>(predicate.ToPredicateGroup<TEntity, TPrimaryKey>(), transaction);
        }
        #endregion

        #region insert
        public  int Insert(TEntity entity, IDbTransaction transaction = null)
        {
            entity.CreatedOn = entity.ModifiedOn = DateTime.Now;
           return Connection.Insert(entity, transaction);
        }

        public Task<int> InsertAsync([NotNull] TEntity entity, IDbTransaction transaction = null)
        {
            return Task.FromResult(Insert(entity));
        }


        public void Insert(IEnumerable<TEntity> entities, IDbTransaction transaction = null)
        {
            var datetime = DateTime.Now;
            foreach (var item in entities)
            {
                item.CreatedOn = item.ModifiedOn = datetime;
            }
            _dbConnection.Insert(entities, transaction);
        }

        public Task InsertAsync(IEnumerable<TEntity> entities, IDbTransaction transaction = null)
        {
            return Task.Run(() => Insert(entities, transaction));
        }

        #endregion


        #region update
        public  bool Update(TEntity entity, IDbTransaction transaction = null)
        {
            entity.ModifiedOn = DateTime.Now;
            return Connection.Update(entity, transaction);
        }

        public Task<bool> UpdateAsync([NotNull] TEntity entity, IDbTransaction transaction = null)
        {
            return Task.FromResult(Update(entity));
        }
        #endregion

        #region delete
        public  bool Delete(TEntity entity, IDbTransaction transaction = null)
        {
            entity.Deleted = true;
            return Connection.Update(entity);
            //Connection.Delete(entity, ActiveTransaction);
        }

        public  void Delete(Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null)
        {
            //Connection.Delete(predicate.ToPredicateGroup<TEntity, TPrimaryKey>(), ActiveTransaction);
        }

        public Task<bool> DeleteAsync([NotNull] TEntity entity, IDbTransaction transaction = null)
        {
            return Task.FromResult(Delete(entity));
        }

        public Task DeleteAsync([NotNull] Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null)
        {
            
            return Task.Run(()=> Delete(predicate));
           
        }

        public int Delete(int id, IDbTransaction transaction = null)
        {
            string sql = $"UPDATE [{typeof(TEntity).Name}] SET [Deleted]=1,[ModifiedOn]='{DateTime.Now}' WHERE [Id]={id}";
            return _dbConnection.Execute(sql, transaction: transaction);
        }
        public Task<int> DeleteAsync(int id, IDbTransaction transaction = null)
        {
            string sql = $"UPDATE [{typeof(TEntity).Name}] SET [Deleted]=1,[ModifiedOn]='{DateTime.Now}' WHERE [Id]={id}";
            return _dbConnection.ExecuteAsync(sql, transaction: transaction);
        }


        public int Delete(IEnumerable<int> ids, IDbTransaction transaction = null)
        {
            string sql = $"UPDATE [{typeof(TEntity).Name}] SET [Deleted]=1,[ModifiedOn]='{DateTime.Now}' WHERE [Id] in({ string.Join(",", ids) })";
            return _dbConnection.Execute(sql, transaction: transaction);
        }
        public Task<int> DeleteAsync(IEnumerable<int> ids, IDbTransaction transaction = null)
        {
            string sql = $"UPDATE [{typeof(TEntity).Name}] SET [Deleted]=1,[ModifiedOn]='{DateTime.Now}' WHERE [Id] in({ string.Join(",", ids) })";
            return _dbConnection.ExecuteAsync(sql, transaction: transaction);
        }
        #endregion
    }
}
