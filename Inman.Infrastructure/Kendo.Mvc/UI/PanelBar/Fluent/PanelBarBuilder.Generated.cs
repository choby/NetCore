using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI PanelBar
    /// </summary>
    public partial class PanelBarBuilder
        
    {
        /// <summary>
        /// If set to false the widget will not bind to the data source during initialization. In this case data binding will occur when the change event of the
		/// data source is fired. By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public PanelBarBuilder AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// Sets the field of the data item that provides the image URL of the PanelBar nodes.
        /// </summary>
        /// <param name="value">The value for DataImageUrlField</param>
        public PanelBarBuilder DataImageUrlField(string value)
        {
            Container.DataImageUrlField = value;
            return this;
        }

        /// <summary>
        /// Sets the field of the data item that provides the sprite CSS class of the nodes.
		/// If an array, each level uses the field that is at the same index in the array, or the last item in the array.
        /// </summary>
        /// <param name="value">The value for DataSpriteCssClassField</param>
        public PanelBarBuilder DataSpriteCssClassField(string value)
        {
            Container.DataSpriteCssClassField = value;
            return this;
        }

        /// <summary>
        /// Sets the field of the data item that provides the text content of the nodes.
		/// If an array, each level uses the field that is at the same index in the array, or the last item in the array.
        /// </summary>
        /// <param name="value">The value for DataTextField</param>
        public PanelBarBuilder DataTextField(params string[] value)
        {
            Container.DataTextField = value;
            return this;
        }

        /// <summary>
        /// Sets the field of the data item that provides the link URL of the nodes.
        /// </summary>
        /// <param name="value">The value for DataUrlField</param>
        public PanelBarBuilder DataUrlField(string value)
        {
            Container.DataUrlField = value;
            return this;
        }

        /// <summary>
        /// Indicates whether the child DataSources should be fetched lazily when parent groups get expanded.
		/// Setting this to false causes all child DataSources to be loaded at initialization time.
        /// </summary>
        /// <param name="value">The value for LoadOnDemand</param>
        public PanelBarBuilder LoadOnDemand(bool value)
        {
            Container.LoadOnDemand = value;
            return this;
        }

        /// <summary>
        /// The text messages displayed in the widget. Use it to customize or localize the messages.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public PanelBarBuilder Messages(Action<PanelBarMessagesSettingsBuilder> configurator)
        {

            Container.Messages.PanelBar = Container;
            configurator(new PanelBarMessagesSettingsBuilder(Container.Messages));

            return this;
        }

        /// <summary>
        /// Template for rendering each node.
        /// </summary>
        /// <param name="value">The value for Template</param>
        public PanelBarBuilder Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// Template for rendering each node.
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public PanelBarBuilder TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Specifies how the PanelBar items are displayed when opened and closed.
        /// </summary>
        /// <param name="value">The value for ExpandMode</param>
        public PanelBarBuilder ExpandMode(PanelBarExpandMode value)
        {
            Container.ExpandMode = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().PanelBar()
        ///       .Name("PanelBar")
        ///       .Events(events => events
        ///           .Activate("onActivate")
        ///       )
        /// )
        /// </code>
        /// </example>
        public PanelBarBuilder Events(Action<PanelBarEventBuilder> configurator)
        {
            configurator(new PanelBarEventBuilder(Container.Events));
            return this;
        }
        
    }
}

