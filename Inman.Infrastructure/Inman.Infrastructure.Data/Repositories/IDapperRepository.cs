using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inman.Infrastructure.Data.Repositories
{
    /// <summary>
    ///     Dapper repository abstraction interface.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <typeparam name="TPrimaryKey">The type of the primary key.</typeparam>
    /// <seealso cref="IDapperRepository{TEntity,TPrimaryKey}" />
    public interface IDapperRepository<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        /// <summary>
        ///     Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [CanBeNull]
        TEntity Get([NotNull] TPrimaryKey id, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [CanBeNull]
        Task<TEntity> GetAsync([NotNull] TPrimaryKey id, IDbTransaction transaction = null);
     
        Task<TEntity> GetAsync(object predicate, IDbTransaction transaction = null);
        TEntity Get(Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null);


        IEnumerable<int> GetIds(IDbTransaction transaction = null);
        Task<IEnumerable<int>> GetIdsAsync(IDbTransaction transaction = null);

        TEntity Get(object predicate, IDbTransaction transaction = null);
        IEnumerable<int> GetIds(object predicate, IDbTransaction transaction = null);
        Task<IEnumerable<int>> GetIdsAsync(object predicate, IDbTransaction transaction = null);





        /// <summary>
        ///     Gets the list.
        /// </summary>
        /// <returns></returns>
        [CanBeNull]
        IEnumerable<TEntity> GetList(IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the list asynchronous.
        /// </summary>
        /// <returns></returns>
        [CanBeNull]
        Task<IEnumerable<TEntity>> GetListAsync(IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the list.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        [CanBeNull]
        IEnumerable<TEntity> GetList([CanBeNull] object predicate, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the list.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        [CanBeNull]
        IEnumerable<TEntity> GetList([CanBeNull] Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the list asynchronous.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        [CanBeNull]
        Task<IEnumerable<TEntity>> GetListAsync([NotNull] object predicate, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the list asynchronous.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        [CanBeNull]
        Task<IEnumerable<TEntity>> GetListAsync([NotNull] Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the list paged asynchronous.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="itemsPerPage">The items per page.</param>
        /// <param name="sortingProperty">The sorting property.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        [CanBeNull]
        Task<IEnumerable<TEntity>> GetListPagedAsync([NotNull] object predicate, int pageNumber, int itemsPerPage, [NotNull] string sortingProperty, bool ascending = true, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the list paged asynchronous.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="itemsPerPage">The items per page.</param>
        /// <param name="sortingProperty">The sorting property.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        [CanBeNull]
        Task<IEnumerable<TEntity>> GetListPagedAsync([NotNull] Expression<Func<TEntity, bool>> predicate, int pageNumber, int itemsPerPage, [NotNull] string sortingProperty, bool ascending = true, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the list paged asynchronous.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="itemsPerPage">The items per page.</param>
        /// <param name="sortingExpression">The sorting expression.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        [CanBeNull]
        Task<IEnumerable<TEntity>> GetListPagedAsync([NotNull] Expression<Func<TEntity, bool>> predicate, int pageNumber, int itemsPerPage, bool ascending = true, IDbTransaction transaction = null, [NotNull] params Expression<Func<TEntity, object>>[] sortingExpression);

        /// <summary>
        ///     Gets the list paged.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="itemsPerPage">The items per page.</param>
        /// <param name="sortingProperty">The sorting property.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        [CanBeNull]
        IEnumerable<TEntity> GetListPaged([NotNull] object predicate, int pageNumber, int itemsPerPage, [NotNull] string sortingProperty, bool ascending = true, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the list paged.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="itemsPerPage">The items per page.</param>
        /// <param name="sortingProperty">The sorting property.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        [CanBeNull]
        IEnumerable<TEntity> GetListPaged([NotNull] Expression<Func<TEntity, bool>> predicate, int pageNumber, int itemsPerPage, [NotNull] string sortingProperty, bool ascending = true, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the list paged.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="itemsPerPage">The items per page.</param>
        /// <param name="sortingExpression">The sorting expression.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        [CanBeNull]
        IEnumerable<TEntity> GetListPaged([NotNull] Expression<Func<TEntity, bool>> predicate, int pageNumber, int itemsPerPage, bool ascending = true, IDbTransaction transaction = null, [NotNull] params Expression<Func<TEntity, object>>[] sortingExpression);

        /// <summary>
        ///     Counts the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        int Count([NotNull] object predicate, IDbTransaction transaction = null);

        /// <summary>
        ///     Counts the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        int Count([NotNull] Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null);

        /// <summary>
        ///     Counts the asynchronous.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        [NotNull]
        Task<int> CountAsync([NotNull] object predicate, IDbTransaction transaction = null);

        /// <summary>
        ///     Counts the asynchronous.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        [NotNull]
        Task<int> CountAsync([NotNull] Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null);

        /// <summary>
        ///     Queries the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        [CanBeNull]
        IEnumerable<TEntity> Query([NotNull] string query, [CanBeNull] object parameters, IDbTransaction transaction = null);

        /// <summary>
        ///     Queries the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        [CanBeNull]
        IEnumerable<TAny> Query<TAny>([NotNull] string query, [CanBeNull] object parameters, IDbTransaction transaction = null) where TAny : class;

        /// <summary>
        ///     Queries the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        [CanBeNull]
        Task<IEnumerable<TAny>> QueryAsync<TAny>([NotNull] string query, [CanBeNull] object parameters, IDbTransaction transaction = null) where TAny : class;

        /// <summary>
        ///     Queries the specified query.
        /// </summary>
        /// <typeparam name="TAny">The type of any.</typeparam>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        IEnumerable<TAny> Query<TAny>([NotNull] string query, IDbTransaction transaction = null) where TAny : class;

        /// <summary>
        ///     Queries the specified query.
        /// </summary>
        /// <typeparam name="TAny">The type of any.</typeparam>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        [CanBeNull]
        Task<IEnumerable<TAny>> QueryAsync<TAny>([NotNull] string query, IDbTransaction transaction = null) where TAny : class;

        /// <summary>
        ///     Queries the asynchronous.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        [CanBeNull]
        Task<IEnumerable<TEntity>> QueryAsync([NotNull] string query, [CanBeNull] object parameters, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the set.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="firstResult">The first result.</param>
        /// <param name="maxResults">The maximum results.</param>
        /// <param name="sortingProperty"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        [CanBeNull]
        IEnumerable<TEntity> GetSet([NotNull] object predicate, int firstResult, int maxResults, [NotNull] string sortingProperty, bool ascending = true, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the set.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="firstResult">The first result.</param>
        /// <param name="maxResults">The maximum results.</param>
        /// <param name="sortingProperty">The sorting property.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        [CanBeNull]
        IEnumerable<TEntity> GetSet([NotNull] Expression<Func<TEntity, bool>> predicate, int firstResult, int maxResults, [NotNull] string sortingProperty, bool ascending = true, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the set.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="firstResult">The first result.</param>
        /// <param name="maxResults">The maximum results.</param>
        /// <param name="sortingExpression">The sorting expression.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        [CanBeNull]
        IEnumerable<TEntity> GetSet([NotNull] Expression<Func<TEntity, bool>> predicate, int firstResult, int maxResults, bool ascending = true, IDbTransaction transaction = null, [NotNull] params Expression<Func<TEntity, object>>[] sortingExpression);

        /// <summary>
        ///     Gets the set asynchronous.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="firstResult">The first result.</param>
        /// <param name="maxResults">The maximum results.</param>
        /// <param name="sortingProperty">The sorting property.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        [CanBeNull]
        Task<IEnumerable<TEntity>> GetSetAsync([NotNull] object predicate, int firstResult, int maxResults, [NotNull] string sortingProperty, bool ascending = true, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the set asynchronous.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="firstResult">The first result.</param>
        /// <param name="maxResults">The maximum results.</param>
        /// <param name="sortingProperty">The sorting property.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <returns></returns>
        [CanBeNull]
        Task<IEnumerable<TEntity>> GetSetAsync([NotNull] Expression<Func<TEntity, bool>> predicate, int firstResult, int maxResults, [NotNull] string sortingProperty, bool ascending = true, IDbTransaction transaction = null);

        /// <summary>
        ///     Gets the set asynchronous.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="firstResult">The first result.</param>
        /// <param name="maxResults">The maximum results.</param>
        /// <param name="ascending">if set to <c>true</c> [ascending].</param>
        /// <param name="sortingExpression">The sorting expression.</param>
        /// <returns></returns>
        [CanBeNull]
        Task<IEnumerable<TEntity>> GetSetAsync([NotNull] Expression<Func<TEntity, bool>> predicate, int firstResult, int maxResults, bool ascending = true, IDbTransaction transaction = null, [NotNull] params Expression<Func<TEntity, object>>[] sortingExpression);

        /// <summary>
        ///     Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        int Insert([NotNull] TEntity entity, IDbTransaction transaction = null);

        void Insert(IEnumerable<TEntity> entities, IDbTransaction transaction = null);
        Task InsertAsync(IEnumerable<TEntity> entities, IDbTransaction transaction = null);

        /// <summary>
        ///     Inserts the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        [NotNull]
        Task<int> InsertAsync([NotNull] TEntity entity, IDbTransaction transaction = null);

        

        /// <summary>
        ///     Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        bool Update([NotNull] TEntity entity, IDbTransaction transaction = null);

        /// <summary>
        ///     Updates the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        [NotNull]
        Task<bool> UpdateAsync([NotNull] TEntity entity, IDbTransaction transaction = null);

        /// <summary>
        ///     Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        bool Delete([NotNull] TEntity entity, IDbTransaction transaction = null);

        /// <summary>
        ///     Deletes the specified entity.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        void Delete([NotNull] Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null);

        /// <summary>
        ///     Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        [NotNull]
        Task<bool> DeleteAsync([NotNull] TEntity entity, IDbTransaction transaction = null);

        /// <summary>
        ///     Deletes the asynchronous.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        [NotNull]
        Task DeleteAsync([NotNull] Expression<Func<TEntity, bool>> predicate, IDbTransaction transaction = null);
        int Delete(int id, IDbTransaction transaction = null);
        Task<int> DeleteAsync(int id, IDbTransaction transaction = null);
        int Delete(IEnumerable<int> ids, IDbTransaction transaction = null);
        Task<int> DeleteAsync(IEnumerable<int> ids, IDbTransaction transaction = null);
    }
}
