
using DapperExtensions;
using Inman.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Inman.Platform.Data.Repository
{
    

    public interface IRepository<TEntity, TPrimaryKey> where TEntity : BaseEntity, IEntity<TPrimaryKey>
    {
        IDbTransaction BeginTransaction();
        IDbTransaction BeginTransaction(IsolationLevel il);
        TEntity Get(int id, IDbTransaction transaction = null);
        Task<TEntity> GetAsync(int id, IDbTransaction transaction = null);
        IEnumerable<TEntity> GetListPaged(object predicate, IList<ISort> sort, int page, int resultsPerPage, IDbTransaction transaction = null);
        Task<IEnumerable<TEntity>> GetListPagedAsync(object predicate, IList<ISort> sort, int page, int resultsPerPage, IDbTransaction transaction = null);

        bool Update(TEntity entity, IDbTransaction transaction = null);
        Task<bool> UpdateAsync(TEntity entity, IDbTransaction transaction = null);

        int Insert(TEntity entity, IDbTransaction transaction = null);
        Task<int> InsertAsync(TEntity entity, IDbTransaction transaction = null);
        bool Delete(TEntity entity, IDbTransaction transaction = null);
        Task<bool> DeleteAsync(TEntity entity, IDbTransaction transaction = null);
        int Delete(int id, IDbTransaction transaction = null);
        Task<int> DeleteAsync(int id, IDbTransaction transaction = null);
        int Delete(IEnumerable<int> ids, IDbTransaction transaction = null);
        Task<int> DeleteAsync(IEnumerable<int> ids, IDbTransaction transaction = null);
    }
}
