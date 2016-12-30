using PetaPoco.NetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inman.IdentityServer.Data
{
    

    public interface IRepository<T>
    {
        Task<T> GetEntityAsync(string sql, params object[] args);
        Task<IEnumerable<T>> GetListAsync(string sql, params object[] args);
        Task<IGridReader> GetMultiResult(string sql, params object[] args);
        Task<TResult> GetScalar<TResult>(string sql, params object[] args);
    }
}
