using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring AutoCompleteVirtualSettings
    /// </summary>
    public partial class AutoCompleteVirtualSettingsBuilder
        
    {
        /// <summary>
        /// Specifies the height of the virtual item. All items in the virtualized list must have the same height.
		/// If the developer does not specify one, the framework will automatically set itemHeight based on the current theme and font size.
        /// </summary>
        /// <param name="value">The value for ItemHeight</param>
        public AutoCompleteVirtualSettingsBuilder ItemHeight(double value)
        {
            Container.ItemHeight = value;
            return this;
        }

        /// <summary>
        /// The changes introduced with the Kendo UI R3 2016 release enable you to determine if the valueMapper must resolve a value to an index or a value to a dataItem. This is configured through the mapValueTo option that accepts two possible values - "index" or "dataItem". By default, the mapValueTo is set to "index", which does not affect the current behavior of the virtualization process.For more information, refer to the article on virtualization.
        /// </summary>
        /// <param name="value">The value for MapValueTo</param>
        public AutoCompleteVirtualSettingsBuilder MapValueTo(string value)
        {
            Container.MapValueTo = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public AutoCompleteVirtualSettingsBuilder ValueMapper(string handler)
        {
            Container.ValueMapper = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public AutoCompleteVirtualSettingsBuilder ValueMapper(Func<object, object> handler)
        {
            Container.ValueMapper = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
