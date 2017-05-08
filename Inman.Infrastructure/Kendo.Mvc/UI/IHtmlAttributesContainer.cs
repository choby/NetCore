using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
    public interface IHtmlAttributesContainer
    {
        /// <summary>
        /// The HtmlAttributes applied to objects which can have child items
        /// </summary>
        IDictionary<string, object> HtmlAttributes
        {
            get;
        }
    }
}