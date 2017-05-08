using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListColumnSortableSettings
    /// </summary>
    public partial class TreeListColumnSortableSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// A JavaScript function which is used to compare the values - should return -1 if first argument is less than second one, 0 if both are the same or +1 if the first one is greater than second one.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public TreeListColumnSortableSettingsBuilder<T> Compare(string handler)
        {
            Container.Compare = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A JavaScript function which is used to compare the values - should return -1 if first argument is less than second one, 0 if both are the same or +1 if the first one is greater than second one.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeListColumnSortableSettingsBuilder<T> Compare(Func<object, object> handler)
        {
            Container.Compare = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
