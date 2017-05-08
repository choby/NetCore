using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ToolBarItemButton
    /// </summary>
    public partial class ToolBarItemButtonBuilder
        
    {
        /// <summary>
        /// Specifies the HTML attributes of a ButtonGroup's button.
        /// </summary>
        /// <param name="value">The value for HtmlAttributes</param>
        public ToolBarItemButtonBuilder HtmlAttributes(IDictionary<string,object> value)
        {
            Container.HtmlAttributes = value;
            return this;
        }

        /// <summary>
        /// Specifies the HTML attributes of a ButtonGroup's button.
        /// </summary>
        /// <param name="value">The value for HtmlAttributes</param>
        public ToolBarItemButtonBuilder HtmlAttributes(object value)
        {
            Container.HtmlAttributes = value.ToDictionary();
            return this;
        }

        /// <summary>
        /// Specifies the click event handler of the button. Applicable only for the children of a ButtonGroup.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ToolBarItemButtonBuilder Click(string handler)
        {
            Container.Click = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the click event handler of the button. Applicable only for the children of a ButtonGroup.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ToolBarItemButtonBuilder Click(Func<object, object> handler)
        {
            Container.Click = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// Specifies whether the button is initially enabled or disabled.
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public ToolBarItemButtonBuilder Enable(bool value)
        {
            Container.Enable = value;
            return this;
        }

        /// <summary>
        /// Assigns the button to a group. Applicable only for the children of a ButtonGroup that has togglable true.
        /// </summary>
        /// <param name="value">The value for Group</param>
        public ToolBarItemButtonBuilder Group(string value)
        {
            Container.Group = value;
            return this;
        }

        /// <summary>
        /// Determines if the button is visible or hidden. By default the buttons are visible.
        /// </summary>
        /// <param name="value">The value for Hidden</param>
        public ToolBarItemButtonBuilder Hidden(bool value)
        {
            Container.Hidden = value;
            return this;
        }

        /// <summary>
        /// Determines if the button is visible or hidden. By default the buttons are visible.
        /// </summary>
        public ToolBarItemButtonBuilder Hidden()
        {
            Container.Hidden = true;
            return this;
        }

        /// <summary>
        /// Sets icon for the menu button. The icon should be one of the existing in the Kendo UI theme sprite.
        /// </summary>
        /// <param name="value">The value for Icon</param>
        public ToolBarItemButtonBuilder Icon(string value)
        {
            Container.Icon = value;
            return this;
        }

        /// <summary>
        /// Specifies the ID of the button.
        /// </summary>
        /// <param name="value">The value for Id</param>
        public ToolBarItemButtonBuilder Id(string value)
        {
            Container.Id = value;
            return this;
        }

        /// <summary>
        /// If set, the ToolBar will render an image with the specified URL in the button.
        /// </summary>
        /// <param name="value">The value for ImageUrl</param>
        public ToolBarItemButtonBuilder ImageUrl(string value)
        {
            Container.ImageUrl = value;
            return this;
        }

        /// <summary>
        /// Specifies if the toggle button is initially selected. Applicable only for the children of a ButtonGroup that has togglable true.
        /// </summary>
        /// <param name="value">The value for Selected</param>
        public ToolBarItemButtonBuilder Selected(bool value)
        {
            Container.Selected = value;
            return this;
        }

        /// <summary>
        /// Specifies if the toggle button is initially selected. Applicable only for the children of a ButtonGroup that has togglable true.
        /// </summary>
        public ToolBarItemButtonBuilder Selected()
        {
            Container.Selected = true;
            return this;
        }

        /// <summary>
        /// Defines a CSS class (or multiple classes separated by spaces) which will be used for button icon.
        /// </summary>
        /// <param name="value">The value for SpriteCssClass</param>
        public ToolBarItemButtonBuilder SpriteCssClass(string value)
        {
            Container.SpriteCssClass = value;
            return this;
        }

        /// <summary>
        /// Specifies the toggle event handler of the button. Applicable only for the children of a ButtonGroup.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ToolBarItemButtonBuilder Toggle(string handler)
        {
            Container.Toggle = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the toggle event handler of the button. Applicable only for the children of a ButtonGroup.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ToolBarItemButtonBuilder Toggle(Func<object, object> handler)
        {
            Container.Toggle = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// Specifies if the button is togglable, e.g. has a selected and unselected state. Applicable only for the children of a ButtonGroup.
        /// </summary>
        /// <param name="value">The value for Togglable</param>
        public ToolBarItemButtonBuilder Togglable(bool value)
        {
            Container.Togglable = value;
            return this;
        }

        /// <summary>
        /// Specifies the text of the menu button.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public ToolBarItemButtonBuilder Text(string value)
        {
            Container.Text = value;
            return this;
        }

        /// <summary>
        /// Specifies the url of the button to navigate to.
        /// </summary>
        /// <param name="value">The value for Url</param>
        public ToolBarItemButtonBuilder Url(string value)
        {
            Container.Url = value;
            return this;
        }

        /// <summary>
        /// Specifies where the text of the menu button will be displayed. Applicable only for the buttons of a ButtonGroup.
        /// </summary>
        /// <param name="value">The value for ShowText</param>
        public ToolBarItemButtonBuilder ShowText(ShowIn value)
        {
            Container.ShowText = value;
            return this;
        }

        /// <summary>
        /// Specifies where the icon of the button will be displayed. Applicable only for the children of a ButtonGroup.
        /// </summary>
        /// <param name="value">The value for ShowIcon</param>
        public ToolBarItemButtonBuilder ShowIcon(ShowIn value)
        {
            Container.ShowIcon = value;
            return this;
        }

    }
}
