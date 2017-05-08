using Microsoft.AspNetCore.Mvc.Rendering;
using Kendo.Mvc.UI.Fluent;

namespace Kendo.Mvc.UI
{    public static class HtmlHelperExtension
    {
        public static WidgetFactory<TModel> Kendo<TModel>(this IHtmlHelper<TModel> helper)
        {
            return new WidgetFactory<TModel>(helper);
        }
    }
}