using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI
{
    public interface IWidget : IHtmlAttributesContainer
    {
        string Id { get; }

        string Name { get; }

        ViewContext ViewContext { get; }
    }
}
