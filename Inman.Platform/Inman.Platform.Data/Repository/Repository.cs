using PetaPoco.NetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inman.Platform.Data.Repository
{
   

    public class Repository<T> :  IRepository<T>
    {
        protected Database _dataBase;
        public Repository(Database dataBase)
        {
            _dataBase = dataBase;
        }

        public async Task<T> GetEntityAsync(string sql, params object[] args)
        {
            T entity = default(T);
            await Task.Run(() =>
            {
               entity = _dataBase.SingleOrDefault<T>(sql, args);
            });
            return entity;
        }
        public async Task<IEnumerable<T>> GetListAsync(string sql, params object[] args)
        {
            IEnumerable<T> list = null;
            await Task.Run(() =>
             {
                 list = _dataBase.Query<T>(sql, args).ToList();
             });
            return list;
        }

        public async Task<IGridReader> GetMultiResult(string sql, params object[] args)
        {
            IGridReader gridRreader = null;
            await Task.Run(() =>
            {
                gridRreader = _dataBase.QueryMultiple(sql, args);
            });
            return gridRreader;
        }

        public async Task<TResult> GetScalar<TResult>(string sql, params object[] args)
        {
            TResult result = default(TResult);
            await Task.Run(() =>
            {
                result = _dataBase.ExecuteScalar<TResult>(sql, args);
            });
            return result;
        }
    }
}
