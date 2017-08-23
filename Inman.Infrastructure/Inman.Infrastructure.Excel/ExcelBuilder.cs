using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Excel
{
    public class ExcelBuilder<T>
    {
        private readonly Excel<T> _container;

        public ExcelBuilder(Excel<T> excel)
        {
            _container = excel;
        }

        public ExcelBuilder<T> Colmuns(Action<ExcelColumnFactory<T>> configurator)
        {
            var obj = new ExcelColumnFactory<T>(this._container);
            configurator(obj);
            return this;
        }
    }
}
