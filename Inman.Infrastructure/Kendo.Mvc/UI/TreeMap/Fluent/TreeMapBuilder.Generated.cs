using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI TreeMap
    /// </summary>
    public partial class TreeMapBuilder
        
    {
        /// <summary>
        /// If set to false the widget will not bind to the data source during initialization. In this case data binding will occur when the change event of the
		/// data source is fired. By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public TreeMapBuilder AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// The theme of the TreeMap.
        /// </summary>
        /// <param name="value">The value for Theme</param>
        public TreeMapBuilder Theme(string value)
        {
            Container.Theme = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the tile value.
        /// </summary>
        /// <param name="value">The value for ValueField</param>
        public TreeMapBuilder ValueField(string value)
        {
            Container.ValueField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the tile color.
        /// </summary>
        /// <param name="value">The value for ColorField</param>
        public TreeMapBuilder ColorField(string value)
        {
            Container.ColorField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the tile title.
        /// </summary>
        /// <param name="value">The value for TextField</param>
        public TreeMapBuilder TextField(string value)
        {
            Container.TextField = value;
            return this;
        }

        /// <summary>
        /// The template which renders the treeMap tile content.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public TreeMapBuilder Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the treeMap tile content.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public TreeMapBuilder TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The default colors for the TreeMap items (tiles). Can be set to array of specific colors or array of color ranges. For more information on the widget behavior, see the Colors section on the TreeMap Overview page.
        /// </summary>
        /// <param name="value">The value for Colors</param>
        public TreeMapBuilder Colors(params String[] value)
        {
            Container.Colors = value;
            return this;
        }

        /// <summary>
        /// The layout type for the Treemap.
        /// </summary>
        /// <param name="value">The value for Type</param>
        public TreeMapBuilder Type(TreeMapType value)
        {
            Container.Type = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().TreeMap()
        ///       .Name("TreeMap")
        ///       .Events(events => events
        ///           .ItemCreated("onItemCreated")
        ///       )
        /// )
        /// </code>
        /// </example>
        public TreeMapBuilder Events(Action<TreeMapEventBuilder> configurator)
        {
            configurator(new TreeMapEventBuilder(Container.Events));
            return this;
        }
        
    }
}

