using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI TreeView
    /// </summary>
    public partial class TreeViewBuilder
        
    {
        /// <summary>
        /// If set to false the widget will not bind to the data source during initialization. In this case data binding will occur when the change event of the
		/// data source is fired. By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public TreeViewBuilder AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will auto-scroll the containing element when the mouse/finger is close to the top/bottom of it.
        /// </summary>
        /// <param name="value">The value for AutoScroll</param>
        public TreeViewBuilder AutoScroll(bool value)
        {
            Container.AutoScroll = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will auto-scroll the containing element when the mouse/finger is close to the top/bottom of it.
        /// </summary>
        public TreeViewBuilder AutoScroll()
        {
            Container.AutoScroll = true;
            return this;
        }

        /// <summary>
        /// If true or an object, renders checkboxes beside each node.
        /// </summary>
        /// <param name="configurator">The configurator for the checkboxes setting.</param>
        public TreeViewBuilder Checkboxes(Action<TreeViewCheckboxesSettingsBuilder> configurator)
        {
            Container.Checkboxes.Enabled = true;

            Container.Checkboxes.TreeView = Container;
            configurator(new TreeViewCheckboxesSettingsBuilder(Container.Checkboxes));

            return this;
        }

        /// <summary>
        /// If true or an object, renders checkboxes beside each node.
        /// </summary>
        /// <param name="enabled">Enables or disables the checkboxes option.</param>
        public TreeViewBuilder Checkboxes(bool enabled)
        {
            Container.Checkboxes.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Sets the field of the data item that provides the image URL of the TreeView nodes.
        /// </summary>
        /// <param name="value">The value for DataImageUrlField</param>
        public TreeViewBuilder DataImageUrlField(string value)
        {
            Container.DataImageUrlField = value;
            return this;
        }

        /// <summary>
        /// Sets the field of the data item that provides the sprite CSS class of the nodes.
		/// If an array, each level uses the field that is at the same index in the array, or the last item in the array.
        /// </summary>
        /// <param name="value">The value for DataSpriteCssClassField</param>
        public TreeViewBuilder DataSpriteCssClassField(string value)
        {
            Container.DataSpriteCssClassField = value;
            return this;
        }

        /// <summary>
        /// Sets the field of the data item that provides the text content of the nodes.
		/// If an array, each level uses the field that is at the same index in the array, or the last item in the array.
        /// </summary>
        /// <param name="value">The value for DataTextField</param>
        public TreeViewBuilder DataTextField(params string[] value)
        {
            Container.DataTextField = value;
            return this;
        }

        /// <summary>
        /// Sets the field of the data item that provides the link URL of the nodes.
        /// </summary>
        /// <param name="value">The value for DataUrlField</param>
        public TreeViewBuilder DataUrlField(string value)
        {
            Container.DataUrlField = value;
            return this;
        }

        /// <summary>
        /// Disables (false) or enables (true) drag-and-drop of the nodes.
        /// </summary>
        /// <param name="value">The value for DragAndDrop</param>
        public TreeViewBuilder DragAndDrop(bool value)
        {
            Container.DragAndDrop = value;
            return this;
        }

        /// <summary>
        /// Disables (false) or enables (true) drag-and-drop of the nodes.
        /// </summary>
        public TreeViewBuilder DragAndDrop()
        {
            Container.DragAndDrop = true;
            return this;
        }

        /// <summary>
        /// Indicates whether the child DataSources should be fetched lazily when parent groups get expanded.
		/// Setting this to false causes all child DataSources to be loaded at initialization time.
        /// </summary>
        /// <param name="value">The value for LoadOnDemand</param>
        public TreeViewBuilder LoadOnDemand(bool value)
        {
            Container.LoadOnDemand = value;
            return this;
        }

        /// <summary>
        /// The text messages displayed in the widget. Use it to customize or localize the messages.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public TreeViewBuilder Messages(Action<TreeViewMessagesSettingsBuilder> configurator)
        {

            Container.Messages.TreeView = Container;
            configurator(new TreeViewMessagesSettingsBuilder(Container.Messages));

            return this;
        }

        /// <summary>
        /// Template for rendering each node.
        /// </summary>
        /// <param name="value">The value for Template</param>
        public TreeViewBuilder Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// Template for rendering each node.
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public TreeViewBuilder TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().TreeView()
        ///       .Name("TreeView")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public TreeViewBuilder Events(Action<TreeViewEventBuilder> configurator)
        {
            configurator(new TreeViewEventBuilder(Container.Events));
            return this;
        }
        
    }
}

