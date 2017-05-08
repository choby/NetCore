using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ToolBarItemMenuButton
    /// </summary>
    public partial class ToolBarItemMenuButtonBuilder
        
    {
        /// <summary>
        /// Specifies the HTML attributes of a menu button.
        /// </summary>
        /// <param name="value">The value for HtmlAttributes</param>
        public ToolBarItemMenuButtonBuilder HtmlAttributes(IDictionary<string,object> value)
        {
            Container.HtmlAttributes = value;
            return this;
        }

        /// <summary>
        /// Specifies the HTML attributes of a menu button.
        /// </summary>
        /// <param name="value">The value for HtmlAttributes</param>
        public ToolBarItemMenuButtonBuilder HtmlAttributes(object value)
        {
            Container.HtmlAttributes = value.ToDictionary();
            return this;
        }

        /// <summary>
        /// Specifies whether the menu button is initially enabled or disabled.
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public ToolBarItemMenuButtonBuilder Enable(bool value)
        {
            Container.Enable = value;
            return this;
        }

        /// <summary>
        /// Determines if a button is visible or hidden. By default buttons are visible.
        /// </summary>
        /// <param name="value">The value for Hidden</param>
        public ToolBarItemMenuButtonBuilder Hidden(bool value)
        {
            Container.Hidden = value;
            return this;
        }

        /// <summary>
        /// Determines if a button is visible or hidden. By default buttons are visible.
        /// </summary>
        public ToolBarItemMenuButtonBuilder Hidden()
        {
            Container.Hidden = true;
            return this;
        }

        /// <summary>
        /// Sets icon for the menu buttons. The icon should be one of the existing in the Kendo UI theme sprite.
        /// </summary>
        /// <param name="value">The value for Icon</param>
        public ToolBarItemMenuButtonBuilder Icon(string value)
        {
            Container.Icon = value;
            return this;
        }

        /// <summary>
        /// Specifies the ID of the menu buttons.
        /// </summary>
        /// <param name="value">The value for Id</param>
        public ToolBarItemMenuButtonBuilder Id(string value)
        {
            Container.Id = value;
            return this;
        }

        /// <summary>
        /// If set, the ToolBar will render an image with the specified URL in the menu button.
        /// </summary>
        /// <param name="value">The value for ImageUrl</param>
        public ToolBarItemMenuButtonBuilder ImageUrl(string value)
        {
            Container.ImageUrl = value;
            return this;
        }

        /// <summary>
        /// Defines a CSS class (or multiple classes separated by spaces) which will be used for menu button icon.
        /// </summary>
        /// <param name="value">The value for SpriteCssClass</param>
        public ToolBarItemMenuButtonBuilder SpriteCssClass(string value)
        {
            Container.SpriteCssClass = value;
            return this;
        }

        /// <summary>
        /// Specifies the text of the menu buttons.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public ToolBarItemMenuButtonBuilder Text(string value)
        {
            Container.Text = value;
            return this;
        }

        /// <summary>
        /// Specifies the url of the menu button to navigate to.
        /// </summary>
        /// <param name="value">The value for Url</param>
        public ToolBarItemMenuButtonBuilder Url(string value)
        {
            Container.Url = value;
            return this;
        }

    }
}
