namespace Inman.Infrastructure.Common
{
    public class SearchParam
    {
        private int _page = 1;

        private int _pageSize = 20;

        public int Page { get { return _page; } set { _page = value; } }

        public virtual int PageSize { get { return _pageSize; } set { _pageSize = value; } }
    }
}
