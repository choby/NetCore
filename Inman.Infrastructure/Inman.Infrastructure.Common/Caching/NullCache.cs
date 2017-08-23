using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Common.Caching
{
    public class NullCacheService : ICacheManager
    {
        public T Get<T>(string key) => default(T);
        //{
        //    return default(T);
        //}

        public void Set(string key, object data, int cacheTime)
        {
            
        }

        public bool IsSet(string key) => false;
        //{
        //    return false;
        //}

        public void Remove(string key)
        {
           
        }

        public void RemoveByPattern(string pattern)
        {
            
        }

        public void Clear()
        {
           
        }
    }
}
