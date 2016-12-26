using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Inman.Infrastructure.Common;

namespace Inman.Infrastructure.Common.Extensions
{
    /// <summary>
    /// 列表操作常用扩展
    /// </summary>
    /// <remarks>  
    /// 修改历史 : 无
    /// </remarks>
    public static class Collections
    {
        /// <summary>
        /// 判断集合不包含任何元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static bool NotAny<T>(this IEnumerable<T> items)
        {
            if (items == null)
                return true;
            return !items.Any();
        }
        /// <summary>
        /// 遍历列表并对列表中的每一项执行指定的动作
        /// </summary>
        /// <typeparam name="T">范型类型</typeparam>
        /// <param name="items">列表</param>
        /// <param name="action">动作代理</param>
        public static void Each<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var t in items)
            {
                action(t);
            }
        }


        /// <summary>
        /// 判断列表对象是否为空
        /// </summary>
        /// <typeparam name="T">范型类型</typeparam>
        /// <param name="collection">列表对象</param>
        /// <returns>是否为NULL或集合中的元素COUNT为0</returns>
        public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
        {
            return (collection == null) || (collection.Count == 0);
        }

        /// <summary>
        /// Adds a set of values to a collection.
        /// </summary>
        /// <typeparam name="T">The type of value kept in the collection.</typeparam>
        /// <param name="collection">The collection to add to.</param>
        /// <param name="values">The values to add to the collection.</param>
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> values)
        {
            foreach (T value in values)
            {
                collection.Add(value);
            }
        }

        public static List<T> Copy<T>(this IEnumerable source)
            where T : class,new()
        {
            List<T> lstT = new List<T>();
            IEnumerator enumerator = source.GetEnumerator();
            while (enumerator.MoveNext())
            {
                lstT.Add(enumerator.Current.Copy<T>());
            }
            return lstT;
        }

        public static IList<R> Yield<T, R>(this IEnumerable<T> source, Func<T, R> func)
        {
            if (source == null)
            { return new List<R>(); }

            IList<R> lstR = new List<R>();
            foreach (var item in source)
            {
                lstR.Add(func(item));
            }
            return lstR;
        }

        public static IList<R> Yield<T, R>(this IEnumerable<T> source, Func<T, R> func, Func<T, bool> condition)
        {
            if (source == null)
            { return new List<R>(); }

            IList<R> lstR = new List<R>();
            foreach (var item in source)
            {
                if (condition(item))
                {
                    lstR.Add(func(item));
                }
            }
            return lstR;
        }

        public static IList<T> Insert<T>(this IList<T> source, T item, int index)
        {
            if (source == null)
                return null;

            source.Insert(index, item);

            return source;
        }

        public static IList<R> Yield<Key, Value, R>(this IDictionary<Key, Value> source, Func<KeyValuePair<Key, Value>, R> func)
        {
            if (source == null)
            { return new List<R>(); }

            IList<R> lstR = new List<R>();
            foreach (var item in source)
            {
                lstR.Add(func(item));
            }
            return lstR;
        }

        public static void Remove<T>(this IList<T> source, Func<T, bool> condition)
        {
            if (source == null)
                return;

            IList<T> lst = source.Yield(p => p, condition);
            foreach (T tmpT in lst)
            {
                source.Remove(tmpT);
            }
        }

        public static string YieldField<T>(this IEnumerable<T> source, Func<T, string> func, char separator = ',')
        {
            if (source == null)
            { return string.Empty; }

            string strResult = string.Empty;
            foreach (var item in source)
            {
                strResult += func(item) + separator;
            }
            return strResult.TrimEnd(separator);
        }
    }
}
