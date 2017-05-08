using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorTool
    /// </summary>
    public partial class EditorToolBuilder
        
    {
        /// <summary>
        /// When specifying a tool as an object, a tool name is required. Please note that "undo" and "redo" are reserved tool names.
        /// </summary>
        /// <param name="value">The value for Name</param>
        public EditorToolBuilder Name(string value)
        {
            Container.Name = value;
            return this;
        }

        /// <summary>
        /// The text which will be displayed when the end-user hovers the tool button with the mouse.
        /// </summary>
        /// <param name="value">The value for Tooltip</param>
        public EditorToolBuilder Tooltip(string value)
        {
            Container.Tooltip = value;
            return this;
        }

        /// <summary>
        /// The JavaScript function which will be executed when the end-user clicks the tool button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public EditorToolBuilder Exec(string handler)
        {
            Container.Exec = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The JavaScript function which will be executed when the end-user clicks the tool button.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorToolBuilder Exec(Func<object, object> handler)
        {
            Container.Exec = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// For tools that display a list of items (fontName, fontSize, formatting), this option specifies the items in the shown list.
        /// </summary>
        /// <param name="configurator">The configurator for the items setting.</param>
        public EditorToolBuilder Items(Action<EditorToolItemFactory> configurator)
        {

            configurator(new EditorToolItemFactory(Container.Items)
            {
                Editor = Container.Editor
            });

            return this;
        }

        /// <summary>
        /// The kendo template that will be used for rendering the given tool.
        /// </summary>
        /// <param name="value">The value for Template</param>
        public EditorToolBuilder Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The kendo template that will be used for rendering the given tool.
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public EditorToolBuilder TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

    }
}
