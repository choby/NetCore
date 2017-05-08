namespace Kendo.Mvc.UI
{    
    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IDataKey<T> : IDataKey
            where T : class
    {
        string HiddenFieldHtml(IHtmlHelper<T> htmlHelper);
    }
}
