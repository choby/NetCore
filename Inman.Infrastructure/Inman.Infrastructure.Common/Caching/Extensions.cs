using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Common.Caching
{
    public static class CacheExtensions
    {
        public static T Get<T>(this ICacheManager cacheManager, string key, Func<T> acquire) => Get(cacheManager, key, 60, acquire);
        //{
        //    return Get(cacheManager, key, 60, acquire);
        //}

        public static T Get<T>(this ICacheManager cacheManager, string key, int cacheTime, Func<T> acquire)
        {
            if (cacheManager.IsSet(key))
            {
                return cacheManager.Get<T>(key);
            }
            var result = acquire();
            cacheManager.Set(key, result, cacheTime);
            return result;
        }
    }
}
