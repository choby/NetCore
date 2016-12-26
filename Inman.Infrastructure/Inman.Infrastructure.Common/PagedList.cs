using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Inman.Infrastructure.Common
{
    public interface IPagedList<T> : IList<T>
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
        int TotalCount { get; set; }
        int TotalPages { get; set; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get; }
    }

    public interface IPagedList
    {
        /// <summary>
        /// 总记录数
        /// </summary>
        int TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        int TotalPages { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        int PageIndex { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        int PageSize { get; set; }

        Array InnerList { get; set; }
    }

    public class PagedList<T> : List<T>, IPagedList<T>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        public PagedList(IQueryable<T> source, int pageIndex, int pageSize)
        {
            int total = source.Count();
            this.TotalCount = total;
            this.TotalPages = total / pageSize;

            if (total % pageSize > 0)
                TotalPages++;

            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.AddRange(source.Skip(pageIndex * pageSize).Take(pageSize).ToList());
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        public PagedList(IList<T> source, int pageIndex, int pageSize)
        {
            TotalCount = source.Count();
            TotalPages = TotalCount / pageSize;

            if (TotalCount % pageSize > 0)
                TotalPages++;

            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.AddRange(source.Skip(pageIndex * pageSize).Take(pageSize).ToList());
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="totalCount">Total count</param>
        public PagedList(IEnumerable<T> source, int pageIndex, int pageSize, int totalCount)
        {
            TotalCount = totalCount;
            TotalPages = TotalCount / pageSize;

            if (TotalCount % pageSize > 0)
                TotalPages++;

            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.AddRange(source);
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }

        public bool HasPreviousPage
        {
            get { return (PageIndex > 0); }
        }
        public bool HasNextPage
        {
            get { return (PageIndex + 1 < TotalPages); }
        }
    }

    [DataContract]
    public class PagedList : IPagedList
    {
        [DataMember]
        public int TotalCount { get; set; }

        [DataMember]
        public int TotalPages { get; set; }

        [DataMember]
        public int PageIndex { get; set; }

        [DataMember]
        public int PageSize { get; set; }

        [DataMember]
        public Array InnerList { get; set; }
    }
}
