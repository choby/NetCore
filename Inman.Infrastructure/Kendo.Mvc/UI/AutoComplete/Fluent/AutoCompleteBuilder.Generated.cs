using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI AutoComplete
    /// </summary>
    public partial class AutoCompleteBuilder
        
    {
        /// <summary>
        /// If set to true, the widget automatically adjusts the width of the popup element and does not wrap up the item label.
        /// </summary>
        /// <param name="value">The value for AutoWidth</param>
        public AutoCompleteBuilder AutoWidth(bool value)
        {
            Container.AutoWidth = value;
            return this;
        }

        /// <summary>
        /// Unless this options is set to false, a button will appear when hovering the widget. Clicking that button will reset the widget's value and will trigger the change event.
        /// </summary>
        /// <param name="value">The value for ClearButton</param>
        public AutoCompleteBuilder ClearButton(bool value)
        {
            Container.ClearButton = value;
            return this;
        }

        /// <summary>
        /// The field of the data item used when searching for suggestions.  This is the text that will be displayed in the list of matched results.
        /// </summary>
        /// <param name="value">The value for DataTextField</param>
        public AutoCompleteBuilder DataTextField(string value)
        {
            Container.DataTextField = value;
            return this;
        }

        /// <summary>
        /// The delay in milliseconds between a keystroke and when the widget displays the suggestion popup.
        /// </summary>
        /// <param name="value">The value for Delay</param>
        public AutoCompleteBuilder Delay(double value)
        {
            Container.Delay = value;
            return this;
        }

        /// <summary>
        /// If set to false the widget will be disabled and will not allow user input. The widget is enabled by default and allows user input.
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public AutoCompleteBuilder Enable(bool value)
        {
            Container.Enable = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will not show all items when the text of the search input cleared. By default the widget shows all items when the text of the search input is cleared. Works in conjunction with minLength.
        /// </summary>
        /// <param name="value">The value for EnforceMinLength</param>
        public AutoCompleteBuilder EnforceMinLength(bool value)
        {
            Container.EnforceMinLength = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will not show all items when the text of the search input cleared. By default the widget shows all items when the text of the search input is cleared. Works in conjunction with minLength.
        /// </summary>
        public AutoCompleteBuilder EnforceMinLength()
        {
            Container.EnforceMinLength = true;
            return this;
        }

        /// <summary>
        /// The filtering method used to determine the suggestions for the current value. The default filter is "startswith" -
		/// all data items which begin with the current widget value are displayed in the suggestion popup. The supported filter values are startswith, endswith and contains.
        /// </summary>
        /// <param name="value">The value for Filter</param>
        public AutoCompleteBuilder Filter(string value)
        {
            Container.Filter = value;
            return this;
        }

        /// <summary>
        /// The template used to render the fixed header group. By default the widget displays only the value of the current group.
        /// </summary>
        /// <param name="value">The value for FixedGroupTemplate</param>
        public AutoCompleteBuilder FixedGroupTemplate(string value)
        {
            Container.FixedGroupTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the fixed header group. By default the widget displays only the value of the current group.
        /// </summary>
        /// <param name="value">The ID of the template element for FixedGroupTemplate</param>
        public AutoCompleteBuilder FixedGroupTemplateId(string templateId)
        {
            Container.FixedGroupTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the footer template. The footer template receives the widget itself as a part of the data argument. Use the widget fields directly in the template.
        /// </summary>
        /// <param name="value">The value for FooterTemplate</param>
        public AutoCompleteBuilder FooterTemplate(string value)
        {
            Container.FooterTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the footer template. The footer template receives the widget itself as a part of the data argument. Use the widget fields directly in the template.
        /// </summary>
        /// <param name="value">The ID of the template element for FooterTemplate</param>
        public AutoCompleteBuilder FooterTemplateId(string templateId)
        {
            Container.FooterTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the groups. By default the widget displays only the value of the group.
        /// </summary>
        /// <param name="value">The value for GroupTemplate</param>
        public AutoCompleteBuilder GroupTemplate(string value)
        {
            Container.GroupTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the groups. By default the widget displays only the value of the group.
        /// </summary>
        /// <param name="value">The ID of the template element for GroupTemplate</param>
        public AutoCompleteBuilder GroupTemplateId(string templateId)
        {
            Container.GroupTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The height of the suggestion popup in pixels. The default value is 200 pixels.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public AutoCompleteBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// If set to true the first suggestion will be automatically highlighted.
        /// </summary>
        /// <param name="value">The value for HighlightFirst</param>
        public AutoCompleteBuilder HighlightFirst(bool value)
        {
            Container.HighlightFirst = value;
            return this;
        }

        /// <summary>
        /// If set to false case-sensitive search will be performed to find suggestions. The widget performs case-insensitive searching by default.
        /// </summary>
        /// <param name="value">The value for IgnoreCase</param>
        public AutoCompleteBuilder IgnoreCase(bool value)
        {
            Container.IgnoreCase = value;
            return this;
        }

        /// <summary>
        /// The minimum number of characters the user must type before a search is performed. Set to higher value than 1 if the search could match a lot of items.
        /// </summary>
        /// <param name="value">The value for MinLength</param>
        public AutoCompleteBuilder MinLength(double value)
        {
            Container.MinLength = value;
            return this;
        }

        /// <summary>
        /// The template used to render the "no data" template, which will be displayed if no results are found or the underlying data source is empty.
		/// The noData template receives the widget itself as a part of the data argument. The template will be evaluated on every widget data bound.
        /// </summary>
        /// <param name="value">The value for NoDataTemplate</param>
        public AutoCompleteBuilder NoDataTemplate(string value)
        {
            Container.NoDataTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the "no data" template, which will be displayed if no results are found or the underlying data source is empty.
		/// The noData template receives the widget itself as a part of the data argument. The template will be evaluated on every widget data bound.
        /// </summary>
        /// <param name="value">The ID of the template element for NoDataTemplate</param>
        public AutoCompleteBuilder NoDataTemplateId(string templateId)
        {
            Container.NoDataTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The hint displayed by the widget when it is empty. Not set by default.
        /// </summary>
        /// <param name="value">The value for Placeholder</param>
        public AutoCompleteBuilder Placeholder(string value)
        {
            Container.Placeholder = value;
            return this;
        }

        /// <summary>
        /// The character used to separate multiple values. Empty by default.
        /// </summary>
        /// <param name="value">The value for Separator</param>
        public AutoCompleteBuilder Separator(string value)
        {
            Container.Separator = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will automatically use the first suggestion as its value.
        /// </summary>
        /// <param name="value">The value for Suggest</param>
        public AutoCompleteBuilder Suggest(bool value)
        {
            Container.Suggest = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will automatically use the first suggestion as its value.
        /// </summary>
        public AutoCompleteBuilder Suggest()
        {
            Container.Suggest = true;
            return this;
        }

        /// <summary>
        /// Specifies a static HTML content, which will be rendered as a header of the popup element.
        /// </summary>
        /// <param name="value">The value for HeaderTemplate</param>
        public AutoCompleteBuilder HeaderTemplate(string value)
        {
            Container.HeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// Specifies a static HTML content, which will be rendered as a header of the popup element.
        /// </summary>
        /// <param name="value">The ID of the template element for HeaderTemplate</param>
        public AutoCompleteBuilder HeaderTemplateId(string templateId)
        {
            Container.HeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the suggestions. By default the widget displays only the text of the suggestion (configured via dataTextField).
        /// </summary>
        /// <param name="value">The value for Template</param>
        public AutoCompleteBuilder Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template used to render the suggestions. By default the widget displays only the text of the suggestion (configured via dataTextField).
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public AutoCompleteBuilder TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The value of the widget.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public AutoCompleteBuilder Value(string value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// Specifies the value binding behavior for the widget when the initial model value is null. If set to true, the View-Model field will be updated with the selected item text field. If set to false, the View-Model field will be updated with the selected item.
        /// </summary>
        /// <param name="value">The value for ValuePrimitive</param>
        public AutoCompleteBuilder ValuePrimitive(bool value)
        {
            Container.ValuePrimitive = value;
            return this;
        }

        /// <summary>
        /// Specifies the value binding behavior for the widget when the initial model value is null. If set to true, the View-Model field will be updated with the selected item text field. If set to false, the View-Model field will be updated with the selected item.
        /// </summary>
        public AutoCompleteBuilder ValuePrimitive()
        {
            Container.ValuePrimitive = true;
            return this;
        }

        /// <summary>
        /// Enables the virtualization feature of the widget. The configuration can be set on an object, which contains two properties - itemHeight and valueMapper.For detailed information, refer to the article on virtualization.
        /// </summary>
        /// <param name="configurator">The configurator for the virtual setting.</param>
        public AutoCompleteBuilder Virtual(Action<AutoCompleteVirtualSettingsBuilder> configurator)
        {
            Container.Virtual.Enabled = true;

            Container.Virtual.AutoComplete = Container;
            configurator(new AutoCompleteVirtualSettingsBuilder(Container.Virtual));

            return this;
        }

        /// <summary>
        /// Enables the virtualization feature of the widget. The configuration can be set on an object, which contains two properties - itemHeight and valueMapper.For detailed information, refer to the article on virtualization.
        /// </summary>
        public AutoCompleteBuilder Virtual()
        {
            Container.Virtual.Enabled = true;
            return this;
        }

        /// <summary>
        /// Enables the virtualization feature of the widget. The configuration can be set on an object, which contains two properties - itemHeight and valueMapper.For detailed information, refer to the article on virtualization.
        /// </summary>
        /// <param name="enabled">Enables or disables the virtual option.</param>
        public AutoCompleteBuilder Virtual(bool enabled)
        {
            Container.Virtual.Enabled = enabled;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().AutoComplete()
        ///       .Name("AutoComplete")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public AutoCompleteBuilder Events(Action<AutoCompleteEventBuilder> configurator)
        {
            configurator(new AutoCompleteEventBuilder(Container.Events));
            return this;
        }
        
    }
}

