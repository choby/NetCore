using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI MultiSelect
    /// </summary>
    public partial class MultiSelectBuilder
        
    {
        /// <summary>
        /// Controls whether to bind the widget to the data source on initialization.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public MultiSelectBuilder AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// Controls whether to close the widget suggestion list on item selection.
        /// </summary>
        /// <param name="value">The value for AutoClose</param>
        public MultiSelectBuilder AutoClose(bool value)
        {
            Container.AutoClose = value;
            return this;
        }

        /// <summary>
        /// If set to true, the widget automatically adjusts the width of the popup element and does not wrap up the item label.
        /// </summary>
        /// <param name="value">The value for AutoWidth</param>
        public MultiSelectBuilder AutoWidth(bool value)
        {
            Container.AutoWidth = value;
            return this;
        }

        /// <summary>
        /// Unless this options is set to false, a button will appear when hovering the widget. Clicking that button will reset the widget's value and will trigger the change event.
        /// </summary>
        /// <param name="value">The value for ClearButton</param>
        public MultiSelectBuilder ClearButton(bool value)
        {
            Container.ClearButton = value;
            return this;
        }

        /// <summary>
        /// The field of the data item that provides the text content of the list items. The widget will filter the data source based on this field.
        /// </summary>
        /// <param name="value">The value for DataTextField</param>
        public MultiSelectBuilder DataTextField(string value)
        {
            Container.DataTextField = value;
            return this;
        }

        /// <summary>
        /// The field of the data item that provides the value of the widget.
        /// </summary>
        /// <param name="value">The value for DataValueField</param>
        public MultiSelectBuilder DataValueField(string value)
        {
            Container.DataValueField = value;
            return this;
        }

        /// <summary>
        /// Specifies the delay in milliseconds after which the MultiSelect will start filtering dataSource.
        /// </summary>
        /// <param name="value">The value for Delay</param>
        public MultiSelectBuilder Delay(double value)
        {
            Container.Delay = value;
            return this;
        }

        /// <summary>
        /// If set to false the widget will be disabled and will not allow user input. The widget is enabled by default and allows user input.
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public MultiSelectBuilder Enable(bool value)
        {
            Container.Enable = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will not show all items when the text of the search input cleared. By default the widget shows all items when the text of the search input is cleared. Works in conjunction with minLength.
        /// </summary>
        /// <param name="value">The value for EnforceMinLength</param>
        public MultiSelectBuilder EnforceMinLength(bool value)
        {
            Container.EnforceMinLength = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will not show all items when the text of the search input cleared. By default the widget shows all items when the text of the search input is cleared. Works in conjunction with minLength.
        /// </summary>
        public MultiSelectBuilder EnforceMinLength()
        {
            Container.EnforceMinLength = true;
            return this;
        }

        /// <summary>
        /// The template used to render the fixed header group. By default the widget displays only the value of the current group.
        /// </summary>
        /// <param name="value">The value for FixedGroupTemplate</param>
        public MultiSelectBuilder FixedGroupTemplate(string value)
        {
            Container.FixedGroupTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the fixed header group. By default the widget displays only the value of the current group.
        /// </summary>
        /// <param name="value">The ID of the template element for FixedGroupTemplate</param>
        public MultiSelectBuilder FixedGroupTemplateId(string templateId)
        {
            Container.FixedGroupTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the footer template. The footer template receives the widget itself as a part of the data argument. Use the widget fields directly in the template.
        /// </summary>
        /// <param name="value">The value for FooterTemplate</param>
        public MultiSelectBuilder FooterTemplate(string value)
        {
            Container.FooterTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the footer template. The footer template receives the widget itself as a part of the data argument. Use the widget fields directly in the template.
        /// </summary>
        /// <param name="value">The ID of the template element for FooterTemplate</param>
        public MultiSelectBuilder FooterTemplateId(string templateId)
        {
            Container.FooterTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the groups. By default the widget displays only the value of the group.
        /// </summary>
        /// <param name="value">The value for GroupTemplate</param>
        public MultiSelectBuilder GroupTemplate(string value)
        {
            Container.GroupTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the groups. By default the widget displays only the value of the group.
        /// </summary>
        /// <param name="value">The ID of the template element for GroupTemplate</param>
        public MultiSelectBuilder GroupTemplateId(string templateId)
        {
            Container.GroupTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The height of the suggestion popup in pixels. The default value is 200 pixels.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public MultiSelectBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// If set to true the first suggestion will be automatically highlighted.
        /// </summary>
        /// <param name="value">The value for HighlightFirst</param>
        public MultiSelectBuilder HighlightFirst(bool value)
        {
            Container.HighlightFirst = value;
            return this;
        }

        /// <summary>
        /// If set to false case-sensitive search will be performed to find suggestions. The widget performs case-insensitive searching by default.
        /// </summary>
        /// <param name="value">The value for IgnoreCase</param>
        public MultiSelectBuilder IgnoreCase(bool value)
        {
            Container.IgnoreCase = value;
            return this;
        }

        /// <summary>
        /// The minimum number of characters the user must type before a search is performed. Set to a higher value if the search could match a lot of items.
		/// A zero value means that a request will be made as soon as the user focuses the widget.
        /// </summary>
        /// <param name="value">The value for MinLength</param>
        public MultiSelectBuilder MinLength(double value)
        {
            Container.MinLength = value;
            return this;
        }

        /// <summary>
        /// Defines the limit of the selected items. If set to null widget will not limit number of the selected items.
        /// </summary>
        /// <param name="value">The value for MaxSelectedItems</param>
        public MultiSelectBuilder MaxSelectedItems(double value)
        {
            Container.MaxSelectedItems = value;
            return this;
        }

        /// <summary>
        /// The template used to render the "no data" template, which will be displayed if no results are found or the underlying data source is empty.
		/// The noData template receives the widget itself as a part of the data argument. The template will be evaluated on every widget data bound.
        /// </summary>
        /// <param name="value">The value for NoDataTemplate</param>
        public MultiSelectBuilder NoDataTemplate(string value)
        {
            Container.NoDataTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the "no data" template, which will be displayed if no results are found or the underlying data source is empty.
		/// The noData template receives the widget itself as a part of the data argument. The template will be evaluated on every widget data bound.
        /// </summary>
        /// <param name="value">The ID of the template element for NoDataTemplate</param>
        public MultiSelectBuilder NoDataTemplateId(string templateId)
        {
            Container.NoDataTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The hint displayed by the widget when it is empty. Not set by default.
        /// </summary>
        /// <param name="value">The value for Placeholder</param>
        public MultiSelectBuilder Placeholder(string value)
        {
            Container.Placeholder = value;
            return this;
        }

        /// <summary>
        /// The options that will be used for the popup initialization. For more details about the available options
		/// refer to Popup documentation.
        /// </summary>
        /// <param name="configurator">The configurator for the popup setting.</param>
        public MultiSelectBuilder Popup(Action<MultiSelectPopupSettingsBuilder> configurator)
        {

            Container.Popup.MultiSelect = Container;
            configurator(new MultiSelectPopupSettingsBuilder(Container.Popup));

            return this;
        }

        /// <summary>
        /// Specifies a static HTML content, which will be rendered as a header of the popup element.
        /// </summary>
        /// <param name="value">The value for HeaderTemplate</param>
        public MultiSelectBuilder HeaderTemplate(string value)
        {
            Container.HeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// Specifies a static HTML content, which will be rendered as a header of the popup element.
        /// </summary>
        /// <param name="value">The ID of the template element for HeaderTemplate</param>
        public MultiSelectBuilder HeaderTemplateId(string templateId)
        {
            Container.HeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the items in the popup list.
        /// </summary>
        /// <param name="value">The value for ItemTemplate</param>
        public MultiSelectBuilder ItemTemplate(string value)
        {
            Container.ItemTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the items in the popup list.
        /// </summary>
        /// <param name="value">The ID of the template element for ItemTemplate</param>
        public MultiSelectBuilder ItemTemplateId(string templateId)
        {
            Container.ItemTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the tags.
        /// </summary>
        /// <param name="value">The value for TagTemplate</param>
        public MultiSelectBuilder TagTemplate(string value)
        {
            Container.TagTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the tags.
        /// </summary>
        /// <param name="value">The ID of the template element for TagTemplate</param>
        public MultiSelectBuilder TagTemplateId(string templateId)
        {
            Container.TagTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Represents available tag modes of MultiSelect.
        /// </summary>
        /// <param name="value">The value for TagMode</param>
        public MultiSelectBuilder TagMode(MultiSelectTagMode value)
        {
            Container.TagMode = value;
            return this;
        }

        /// <summary>
        /// Specifies the value binding behavior for the widget. If set to true, the View-Model field will be updated with the selected item value field. If set to false, the View-Model field will be updated with the selected item.
        /// </summary>
        /// <param name="value">The value for ValuePrimitive</param>
        public MultiSelectBuilder ValuePrimitive(bool value)
        {
            Container.ValuePrimitive = value;
            return this;
        }

        /// <summary>
        /// Specifies the value binding behavior for the widget. If set to true, the View-Model field will be updated with the selected item value field. If set to false, the View-Model field will be updated with the selected item.
        /// </summary>
        public MultiSelectBuilder ValuePrimitive()
        {
            Container.ValuePrimitive = true;
            return this;
        }

        /// <summary>
        /// Enables the virtualization feature of the widget. The configuration can be set on an object, which contains two properties - itemHeight and valueMapper.For detailed information, refer to the article on virtualization.
        /// </summary>
        /// <param name="configurator">The configurator for the virtual setting.</param>
        public MultiSelectBuilder Virtual(Action<MultiSelectVirtualSettingsBuilder> configurator)
        {
            Container.Virtual.Enabled = true;

            Container.Virtual.MultiSelect = Container;
            configurator(new MultiSelectVirtualSettingsBuilder(Container.Virtual));

            return this;
        }

        /// <summary>
        /// Enables the virtualization feature of the widget. The configuration can be set on an object, which contains two properties - itemHeight and valueMapper.For detailed information, refer to the article on virtualization.
        /// </summary>
        public MultiSelectBuilder Virtual()
        {
            Container.Virtual.Enabled = true;
            return this;
        }

        /// <summary>
        /// Enables the virtualization feature of the widget. The configuration can be set on an object, which contains two properties - itemHeight and valueMapper.For detailed information, refer to the article on virtualization.
        /// </summary>
        /// <param name="enabled">Enables or disables the virtual option.</param>
        public MultiSelectBuilder Virtual(bool enabled)
        {
            Container.Virtual.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The filtering method used to determine the suggestions for the current value.
        /// </summary>
        /// <param name="value">The value for Filter</param>
        public MultiSelectBuilder Filter(FilterType value)
        {
            Container.Filter = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().MultiSelect()
        ///       .Name("MultiSelect")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public MultiSelectBuilder Events(Action<MultiSelectEventBuilder> configurator)
        {
            configurator(new MultiSelectEventBuilder(Container.Events));
            return this;
        }
        
    }
}

