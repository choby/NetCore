using Kendo.Mvc.UI;
using System;

namespace Kendo.Mvc.Extensions
{
    public static class HtmlAttributesContainerExtensions
    {
        public static void ThrowIfClassIsPresent(this IHtmlAttributesContainer container, string @class, string message)
        {
            object value;

            if (container.HtmlAttributes.TryGetValue("class", out value))
            {
                if (value != null)
                {
                    var classes = value.ToString().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    if (Array.IndexOf(classes, @class) > -1)
                    {
                        throw new NotSupportedException(message.FormatWith(@class));
                    }
                }
            }
        }
    }
}