using Inman.Infrastructure.IOC;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Excel
{
    public class Excel<TModel>
    {
        public IModelMetadataProvider ModelMetadataProvider
        {
            get {
                return EngineContext.Current.GetService<IModelMetadataProvider>();
            }
        }
        public IList<ExcelColumnBase<TModel>> Columns { get; } = new List<ExcelColumnBase<TModel>>();
    }
}
