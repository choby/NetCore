using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.SessionState;

namespace Inman.Infrastructure.Common.Caching
{
    public class SessionCacheManager : ICacheManager
    {
      
        protected ObjectCache Cache
        {
            get
            {
                return MemoryCache.Default;
            }
        }

        private string SessionId
        {
            get
            {
                var cookie = HttpContext.Current?.Request?.Cookies["ASP.NET_SessionId"];
                if (cookie == null)
                    return null;
                return cookie.Value;
            }
        }

        public T Get<T>(string key)
        {
            
            //var _session = HttpContext.Current.Session;
            if (string.IsNullOrEmpty(SessionId))
                return default(T);
            return (T)Cache[$"{SessionId}_{key}"];
        }

        public void Set(string key, object data, int cacheTime)
        {
            //var _session = HttpContext.Current.Session;
            if (data == null || string.IsNullOrEmpty(SessionId))
                return;
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime)
            };
            Cache.Add(new CacheItem($"{SessionId}_{key}", data), policy);
        }

        public bool IsSet(string key)
        {
            //var _session = HttpContext.Current.Session;
            if (string.IsNullOrEmpty(SessionId))
                return false;
            return Cache.Contains($"{SessionId}_{key}");
        }

        public void Remove(string key)
        {
            var _session = HttpContext.Current.Session;
            if (_session == null)
                return ;
            Cache.Remove(key);
        }

        public void RemoveByPattern(string pattern)
        {
            //var _session = HttpContext.Current.Session;
            var regex = new Regex($"{SessionId}_{pattern}", RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var keysToRemove = (from item in Cache
                                where regex.IsMatch(item.Key)
                                select item.Key).ToList();
            foreach (var key in keysToRemove)
                Remove(key);
        }

        public void Clear()
        {
            //var _session = HttpContext.Current.Session;
            if (string.IsNullOrEmpty(SessionId))
                return ;
            foreach (var item in Cache.Where(t=>t.Key.StartsWith($"{SessionId}_")))
                Remove(item.Key);
        }
    }
}
