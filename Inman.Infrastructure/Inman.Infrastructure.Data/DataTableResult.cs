using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Data
{
    public class DataTableResult
    {
        public DataTable Data { get; set; }
        public int Total { get; set; }
        int   _page ;
        public int Page {
            get { return _page;}
            set
            {
                _page = value;
                setStartRowIndex();
            }
        }

        int _pageSize ;
        public int PageSize {
            get { return _pageSize; }
            set
            {
                _pageSize = value;
                setStartRowIndex();
            }
        }
        public int PerPageStartRowIndex { get; set; }

        private void setStartRowIndex()
        {
            PerPageStartRowIndex = ((Page > 0 ? Page : 1) - 1) * PageSize;
        }
    }
}
