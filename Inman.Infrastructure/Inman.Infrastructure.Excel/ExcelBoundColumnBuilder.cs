using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Excel
{
    public class ExcelBoundColumnBuilder<TModel>
    {
        private readonly ExcelColumnBase<TModel> _column;

        public ExcelBoundColumnBuilder(ExcelColumnBase<TModel> column)
        {
            _column = column;
        }

        /// <summary>
        /// 设置宽度
        /// </summary>
        /// <param name="pixelWidth"></param>
        /// <returns></returns>
        public ExcelBoundColumnBuilder<TModel> Width(int pixelWidth)
        {
            _column.Width = pixelWidth;
            return this;
        }

        /// <summary>
        /// 设置宽度
        /// </summary>
        /// <returns></returns>
        public ExcelBoundColumnBuilder<TModel> Title(string title)
        {
            _column.Title = title;
            return this;
        }
    }
}
