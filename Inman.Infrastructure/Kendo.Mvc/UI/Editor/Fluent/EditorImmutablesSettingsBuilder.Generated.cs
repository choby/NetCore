using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorImmutablesSettings
    /// </summary>
    public partial class EditorImmutablesSettingsBuilder
        
    {
        /// <summary>
        /// Callback that allows custom deserialization of an immutable element. The callback accepts two arguments. The DOM element representing the immutable element in the html view and the immutable DOM element, which will be restored.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public EditorImmutablesSettingsBuilder Deserialization(string handler)
        {
            Container.Deserialization = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Callback that allows custom deserialization of an immutable element. The callback accepts two arguments. The DOM element representing the immutable element in the html view and the immutable DOM element, which will be restored.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorImmutablesSettingsBuilder Deserialization(Func<object, object> handler)
        {
            Container.Deserialization = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// Kendo template or a callback that allows custom serialization of an immutable element. The callback accepts DOM element as only parameter and is expected to return the HTML source of a DOM element.
        /// </summary>
        /// <param name="value">The value for Serialization</param>
        public EditorImmutablesSettingsBuilder Serialization(string value)
        {
            Container.SerializationHandler = null;
            Container.Serialization = value;
            return this;
        }
        /// <summary>
        /// Kendo template or a callback that allows custom serialization of an immutable element. The callback accepts DOM element as only parameter and is expected to return the HTML source of a DOM element.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public EditorImmutablesSettingsBuilder SerializationHandler(string handler)
        {
            Container.Serialization = null;
            Container.SerializationHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Kendo template or a callback that allows custom serialization of an immutable element. The callback accepts DOM element as only parameter and is expected to return the HTML source of a DOM element.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorImmutablesSettingsBuilder SerializationHandler(Func<object, object> handler)
        {
            Container.Serialization = null;
            Container.SerializationHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

    }
}
