using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListColumnCommand
    /// </summary>
    public partial class TreeListColumnCommandBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The CSS class applied to the command button.
        /// </summary>
        /// <param name="value">The value for ClassName</param>
        public TreeListColumnCommandBuilder<T> ClassName(string value)
        {
            Container.ClassName = value;
            return this;
        }

        /// <summary>
        /// The CSS class applied to the icon span of the command button.
        /// </summary>
        /// <param name="value">The value for ImageClass</param>
        public TreeListColumnCommandBuilder<T> ImageClass(string value)
        {
            Container.ImageClass = value;
            return this;
        }

        /// <summary>
        /// The JavaScript function executed when the user clicks the command button. The function receives a jQuery Event as an argument.The function context (available via the this keyword) will be set to the treelist instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public TreeListColumnCommandBuilder<T> Click(string handler)
        {
            Container.Click = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The JavaScript function executed when the user clicks the command button. The function receives a jQuery Event as an argument.The function context (available via the this keyword) will be set to the treelist instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeListColumnCommandBuilder<T> Click(Func<object, object> handler)
        {
            Container.Click = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// The name of the command. The built-in command names are "edit", "createChild" and "destroy". Check the columns.command section for additional important information. When set to a custom value, the name is rendered as a data-command attribute.
        /// </summary>
        /// <param name="value">The value for Name</param>
        public TreeListColumnCommandBuilder<T> Name(string value)
        {
            Container.Name = value;
            return this;
        }

        /// <summary>
        /// The text displayed by the command button. If not set the name option is used as the button text.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public TreeListColumnCommandBuilder<T> Text(string value)
        {
            Container.Text = value;
            return this;
        }

    }
}
