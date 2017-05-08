using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring DropDownListVirtualSettings
    /// </summary>
    public partial class DropDownListVirtualSettingsBuilder
        
    {
        /// <summary>
        /// Specifies the height of the virtual item. All items in the virtualized list must have the same height.
		/// If the developer does not specify one, the framework will automatically set itemHeight based on the current theme and font size.
        /// </summary>
        /// <param name="value">The value for ItemHeight</param>
        public DropDownListVirtualSettingsBuilder ItemHeight(double value)
        {
            Container.ItemHeight = value;
            return this;
        }

        /// <summary>
        /// The changes introduced with the Kendo UI R3 2016 release enable you to determine if the valueMapper must resolve a value to an index or a value to a dataItem. This is configured through the mapValueTo option that accepts two possible values - "index" or "dataItem". By default, the mapValueTo is set to "index", which does not affect the current behavior of the virtualization process.For more information, refer to the article on virtualization.
        /// </summary>
        /// <param name="value">The value for MapValueTo</param>
        public DropDownListVirtualSettingsBuilder MapValueTo(string value)
        {
            Container.MapValueTo = value;
            return this;
        }

        /// <summary>
        /// The widget calls the valueMapper function when the widget receives a value, that is not fetched from the remote server yet.
		/// The widget will pass the selected value(s) in the valueMapper function. In turn, the valueMapper implementation should return the respective data item(s) index/indices.
		/// &gt; Important
		/// &gt;
		/// &gt; As of the Kendo UI R3 2016 release, the implementation of the valueMapper function is optional. It is required only if the widget contains an initial value or if the value method is used.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public DropDownListVirtualSettingsBuilder ValueMapper(string handler)
        {
            Container.ValueMapper = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The widget calls the valueMapper function when the widget receives a value, that is not fetched from the remote server yet.
		/// The widget will pass the selected value(s) in the valueMapper function. In turn, the valueMapper implementation should return the respective data item(s) index/indices.
		/// &gt; Important
		/// &gt;
		/// &gt; As of the Kendo UI R3 2016 release, the implementation of the valueMapper function is optional. It is required only if the widget contains an initial value or if the value method is used.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DropDownListVirtualSettingsBuilder ValueMapper(Func<object, object> handler)
        {
            Container.ValueMapper = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
