using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Inman.Infrastructure.Common.Extensions
{
    public static class QueryableExtension
    {
        /// <summary>
        /// 转换为强类型分页列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页记录数量</param>
        /// <returns>强类型分页列表</returns>
        public static PagedList<T> ToPagedList<T>(this IQueryable<T> source, int pageIndex, int pageSize)
        {
            return new PagedList<T>(source, pageIndex, pageSize);
        }

        /// <summary>
        /// 转换为强类型分页列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页记录数量</param>
        /// <returns>强类型分页列表</returns>
        public static PagedList<T> ToPagedList<T>(this IEnumerable<T> source, int pageIndex, int pageSize)
        {
            return new PagedList<T>(source.ToList(), pageIndex, pageSize);
        }

        public static IQueryable<TSource> OrderByIf<TSource, TKey>(this IQueryable<TSource> source
                                                                        , Expression<Func<TSource, TKey>> keySelector
                                                                        , bool condition)
        {
            return condition ? source.OrderBy(keySelector) : source;
        }
    }

    public static class WhereIfExtension
    {
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, Expression<Func<T, bool>> predicate, bool condition)
        {
            return condition ? source.Where(predicate) : source;
        }
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, Expression<Func<T, int, bool>> predicate, bool condition)
        {
            return condition ? source.Where(predicate) : source;
        }
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, Func<T, bool> predicate, bool condition)
        {
            return condition ? source.Where(predicate) : source;
        }
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, Func<T, int, bool> predicate, bool condition)
        {
            return condition ? source.Where(predicate) : source;
        }
    }
}
