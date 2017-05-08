using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ToolBarItem
    /// </summary>
    public partial class ToolBarItemBuilder
        
    {
        /// <summary>
        /// Specifies the HTML attributes of a ToolBar button.
        /// </summary>
        /// <param name="value">The value for HtmlAttributes</param>
        public ToolBarItemBuilder HtmlAttributes(IDictionary<string,object> value)
        {
            Container.HtmlAttributes = value;
            return this;
        }

        /// <summary>
        /// Specifies the HTML attributes of a ToolBar button.
        /// </summary>
        /// <param name="value">The value for HtmlAttributes</param>
        public ToolBarItemBuilder HtmlAttributes(object value)
        {
            Container.HtmlAttributes = value.ToDictionary();
            return this;
        }

        /// <summary>
        /// Specifies the buttons of ButtonGroup.
        /// </summary>
        /// <param name="configurator">The configurator for the buttons setting.</param>
        public ToolBarItemBuilder Buttons(Action<ToolBarItemButtonFactory> configurator)
        {

            configurator(new ToolBarItemButtonFactory(Container.Buttons)
            {
                ToolBar = Container.ToolBar
            });

            return this;
        }

        /// <summary>
        /// Specifies the click event handler of the button. Applicable only for commands of type button and splitButton.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ToolBarItemBuilder Click(string handler)
        {
            Container.Click = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the click event handler of the button. Applicable only for commands of type button and splitButton.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ToolBarItemBuilder Click(Func<object, object> handler)
        {
            Container.Click = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// Specifies whether the control is initially enabled or disabled. Default value is "true".
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public ToolBarItemBuilder Enable(bool value)
        {
            Container.Enable = value;
            return this;
        }

        /// <summary>
        /// Assigns the button to a group. Applicable only for buttons with togglable: true.
        /// </summary>
        /// <param name="value">The value for Group</param>
        public ToolBarItemBuilder Group(string value)
        {
            Container.Group = value;
            return this;
        }

        /// <summary>
        /// Determines if a button is visible or hidden. By default buttons are visible.
        /// </summary>
        /// <param name="value">The value for Hidden</param>
        public ToolBarItemBuilder Hidden(bool value)
        {
            Container.Hidden = value;
            return this;
        }

        /// <summary>
        /// Determines if a button is visible or hidden. By default buttons are visible.
        /// </summary>
        public ToolBarItemBuilder Hidden()
        {
            Container.Hidden = true;
            return this;
        }

        /// <summary>
        /// Sets icon for the item. The icon should be one of the existing in the Kendo UI theme sprite.
        /// </summary>
        /// <param name="value">The value for Icon</param>
        public ToolBarItemBuilder Icon(string value)
        {
            Container.Icon = value;
            return this;
        }

        /// <summary>
        /// Specifies the ID of the button.
        /// </summary>
        /// <param name="value">The value for Id</param>
        public ToolBarItemBuilder Id(string value)
        {
            Container.Id = value;
            return this;
        }

        /// <summary>
        /// If set, the ToolBar will render an image with the specified URL in the button.
        /// </summary>
        /// <param name="value">The value for ImageUrl</param>
        public ToolBarItemBuilder ImageUrl(string value)
        {
            Container.ImageUrl = value;
            return this;
        }

        /// <summary>
        /// Specifies the menu buttons of a SplitButton.
        /// </summary>
        /// <param name="configurator">The configurator for the menubuttons setting.</param>
        public ToolBarItemBuilder MenuButtons(Action<ToolBarItemMenuButtonFactory> configurator)
        {

            configurator(new ToolBarItemMenuButtonFactory(Container.MenuButtons)
            {
                ToolBar = Container.ToolBar
            });

            return this;
        }

        /// <summary>
        /// Specifies what element will be added in the command overflow popup. Applicable only for items that have a template.
        /// </summary>
        /// <param name="value">The value for OverflowTemplate</param>
        public ToolBarItemBuilder OverflowTemplate(string value)
        {
            Container.OverflowTemplate = value;
            return this;
        }

        /// <summary>
        /// Specifies what element will be added in the command overflow popup. Applicable only for items that have a template.
        /// </summary>
        /// <param name="value">The ID of the template element for OverflowTemplate</param>
        public ToolBarItemBuilder OverflowTemplateId(string templateId)
        {
            Container.OverflowTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Specifies whether the button is primary. Primary buttons receive different styling.
        /// </summary>
        /// <param name="value">The value for Primary</param>
        public ToolBarItemBuilder Primary(bool value)
        {
            Container.Primary = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the button is primary. Primary buttons receive different styling.
        /// </summary>
        public ToolBarItemBuilder Primary()
        {
            Container.Primary = true;
            return this;
        }

        /// <summary>
        /// Specifies if the toggle button is initially selected. Applicable only for buttons with togglable: true.
        /// </summary>
        /// <param name="value">The value for Selected</param>
        public ToolBarItemBuilder Selected(bool value)
        {
            Container.Selected = value;
            return this;
        }

        /// <summary>
        /// Specifies if the toggle button is initially selected. Applicable only for buttons with togglable: true.
        /// </summary>
        public ToolBarItemBuilder Selected()
        {
            Container.Selected = true;
            return this;
        }

        /// <summary>
        /// Defines a CSS class (or multiple classes separated by spaces) which will be used for button icon.
        /// </summary>
        /// <param name="value">The value for SpriteCssClass</param>
        public ToolBarItemBuilder SpriteCssClass(string value)
        {
            Container.SpriteCssClass = value;
            return this;
        }

        /// <summary>
        /// Specifies what element will be added in the ToolBar wrapper. Items with template does not have a type.
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ToolBarItemBuilder Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// Specifies what element will be added in the ToolBar wrapper. Items with template does not have a type.
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ToolBarItemBuilder TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Sets the text of the button.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public ToolBarItemBuilder Text(string value)
        {
            Container.Text = value;
            return this;
        }

        /// <summary>
        /// Specifies if the button is togglable, e.g. has a selected and unselected state.
        /// </summary>
        /// <param name="value">The value for Togglable</param>
        public ToolBarItemBuilder Togglable(bool value)
        {
            Container.Togglable = value;
            return this;
        }

        /// <summary>
        /// Specifies if the button is togglable, e.g. has a selected and unselected state.
        /// </summary>
        public ToolBarItemBuilder Togglable()
        {
            Container.Togglable = true;
            return this;
        }

        /// <summary>
        /// Specifies the toggle event handler of the button. Applicable only for commands of type button and togglable: true.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ToolBarItemBuilder Toggle(string handler)
        {
            Container.Toggle = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the toggle event handler of the button. Applicable only for commands of type button and togglable: true.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ToolBarItemBuilder Toggle(Func<object, object> handler)
        {
            Container.Toggle = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// Specifies the url to navigate to.
        /// </summary>
        /// <param name="value">The value for Url</param>
        public ToolBarItemBuilder Url(string value)
        {
            Container.Url = value;
            return this;
        }

        /// <summary>
        /// Specifies the type of the item.
        /// </summary>
        /// <param name="value">The value for Type</param>
        public ToolBarItemBuilder Type(CommandType value)
        {
            Container.Type = value;
            return this;
        }

        /// <summary>
        /// Specifies where the text will be displayed.
        /// </summary>
        /// <param name="value">The value for ShowText</param>
        public ToolBarItemBuilder ShowText(ShowIn value)
        {
            Container.ShowText = value;
            return this;
        }

        /// <summary>
        /// Specifies where the icon will be displayed.
        /// </summary>
        /// <param name="value">The value for ShowIcon</param>
        public ToolBarItemBuilder ShowIcon(ShowIn value)
        {
            Container.ShowIcon = value;
            return this;
        }

        /// <summary>
        /// Specifies how the button behaves when the ToolBar is resized.
        /// </summary>
        /// <param name="value">The value for Overflow</param>
        public ToolBarItemBuilder Overflow(ShowInOverflowPopup value)
        {
            Container.Overflow = value;
            return this;
        }

    }
}
