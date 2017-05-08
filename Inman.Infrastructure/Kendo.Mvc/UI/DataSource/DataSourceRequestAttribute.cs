using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.UI
{
    public class DataSourceRequestAttribute : ModelBinderAttribute
    {
        public DataSourceRequestAttribute()
        {
            BinderType = typeof(DataSourceRequestModelBinder);
        }
        
    }
}