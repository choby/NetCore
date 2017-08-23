using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;


namespace Inman.Infrastructure.Excel
{
    public abstract class ExcelColumnBase<TModel>
    {
        public bool Visible { get; set; }

        public string Format { get; set; }

        public Type MemberType { get; set; }

        public string Title { get; set; }

        public string Member { get; set; }

        public int Width { get; set; }

        public abstract object GetColumnValue(TModel model);
        public ModelMetadata Metadata { get; protected set; }
    }
}
