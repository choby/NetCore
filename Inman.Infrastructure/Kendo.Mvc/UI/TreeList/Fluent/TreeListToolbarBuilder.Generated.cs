using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListToolbar
    /// </summary>
    public partial class TreeListToolbarBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The click handler of the toolbar command. Used for custom toolbar commands.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public TreeListToolbarBuilder<T> Click(string handler)
        {
            Container.Click = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The click handler of the toolbar command. Used for custom toolbar commands.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeListToolbarBuilder<T> Click(Func<object, object> handler)
        {
            Container.Click = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// The name of the toolbar command. Either a built-in ("create", "excel", "pdf") or custom. The name is reflected in one of the CSS classes, which is applied to the button - k-grid-name.
		/// This class can be used to get a reference to the button (after TreeList initialization) and attach click handlers.
        /// </summary>
        /// <param name="value">The value for Name</param>
        public TreeListToolbarBuilder<T> Name(string value)
        {
            Container.Name = value;
            return this;
        }

        /// <summary>
        /// The text displayed by the command button. If not set the name` option would be used as the button text instead.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public TreeListToolbarBuilder<T> Text(string value)
        {
            Container.Text = value;
            return this;
        }

    }
}
