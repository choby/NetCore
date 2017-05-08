using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorDeserializationSettings
    /// </summary>
    public partial class EditorDeserializationSettingsBuilder
        
    {
        /// <summary>
        /// Callback that allows custom deserialization to be plugged in. The method accepts string as the only parameter and is expected to return the modified content as string as well.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public EditorDeserializationSettingsBuilder Custom(string handler)
        {
            Container.Custom = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Callback that allows custom deserialization to be plugged in. The method accepts string as the only parameter and is expected to return the modified content as string as well.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorDeserializationSettingsBuilder Custom(Func<object, object> handler)
        {
            Container.Custom = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
