using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring DialogAction
    /// </summary>
    public partial class DialogActionBuilder
        
    {
        /// <summary>
        /// The text to be shown in the action's button.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public DialogActionBuilder Text(string value)
        {
            Container.Text = value;
            return this;
        }

        /// <summary>
        /// The callback function to be called after pressing the action button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public DialogActionBuilder Action(string handler)
        {
            Container.Action = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The callback function to be called after pressing the action button.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DialogActionBuilder Action(Func<object, object> handler)
        {
            Container.Action = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// A boolean property indicating whether the action button will be decorated as primary button or not.
        /// </summary>
        /// <param name="value">The value for Primary</param>
        public DialogActionBuilder Primary(bool value)
        {
            Container.Primary = value;
            return this;
        }

    }
}
