using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ComboBox
    /// </summary>
    public partial class ComboBoxBuilder
        
    {
        /// <summary>
        /// Controls whether to bind the widget to the data source on initialization.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public ComboBoxBuilder AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// If set to true, the widget automatically adjusts the width of the popup element and does not wrap up the item label.
        /// </summary>
        /// <param name="value">The value for AutoWidth</param>
        public ComboBoxBuilder AutoWidth(bool value)
        {
            Container.AutoWidth = value;
            return this;
        }

        /// <summary>
        /// Use it to set the Id of the parent ComboBox widget.
		/// Help topic showing how cascading functionality works
        /// </summary>
        /// <param name="value">The value for CascadeFrom</param>
        public ComboBoxBuilder CascadeFrom(string value)
        {
            Container.CascadeFrom = value;
            return this;
        }

        /// <summary>
        /// Defines the field to be used to filter the data source. If not defined the parent's dataValueField option will be used.
		/// Help topic showing how cascading functionality works
        /// </summary>
        /// <param name="value">The value for CascadeFromField</param>
        public ComboBoxBuilder CascadeFromField(string value)
        {
            Container.CascadeFromField = value;
            return this;
        }

        /// <summary>
        /// Unless this options is set to false, a button will appear when hovering the widget. Clicking that button will reset the widget's value and will trigger the change event.
        /// </summary>
        /// <param name="value">The value for ClearButton</param>
        public ComboBoxBuilder ClearButton(bool value)
        {
            Container.ClearButton = value;
            return this;
        }

        /// <summary>
        /// The field of the data item that provides the text content of the list items. The widget will filter the data source based on this field.
        /// </summary>
        /// <param name="value">The value for DataTextField</param>
        public ComboBoxBuilder DataTextField(string value)
        {
            Container.DataTextField = value;
            return this;
        }

        /// <summary>
        /// The field of the data item that provides the value of the widget.
        /// </summary>
        /// <param name="value">The value for DataValueField</param>
        public ComboBoxBuilder DataValueField(string value)
        {
            Container.DataValueField = value;
            return this;
        }

        /// <summary>
        /// The delay in milliseconds between a keystroke and when the widget displays the popup.
        /// </summary>
        /// <param name="value">The value for Delay</param>
        public ComboBoxBuilder Delay(double value)
        {
            Container.Delay = value;
            return this;
        }

        /// <summary>
        /// If set to false the widget will be disabled and will not allow user input. The widget is enabled by default and allows user input.
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public ComboBoxBuilder Enable(bool value)
        {
            Container.Enable = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will not show all items when the text of the search input cleared. By default the widget shows all items when the text of the search input is cleared. Works in conjunction with minLength.
        /// </summary>
        /// <param name="value">The value for EnforceMinLength</param>
        public ComboBoxBuilder EnforceMinLength(bool value)
        {
            Container.EnforceMinLength = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will not show all items when the text of the search input cleared. By default the widget shows all items when the text of the search input is cleared. Works in conjunction with minLength.
        /// </summary>
        public ComboBoxBuilder EnforceMinLength()
        {
            Container.EnforceMinLength = true;
            return this;
        }

        /// <summary>
        /// The template used to render the fixed header group. By default the widget displays only the value of the current group.
        /// </summary>
        /// <param name="value">The value for FixedGroupTemplate</param>
        public ComboBoxBuilder FixedGroupTemplate(string value)
        {
            Container.FixedGroupTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the fixed header group. By default the widget displays only the value of the current group.
        /// </summary>
        /// <param name="value">The ID of the template element for FixedGroupTemplate</param>
        public ComboBoxBuilder FixedGroupTemplateId(string templateId)
        {
            Container.FixedGroupTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the footer template. The footer template receives the widget itself as a part of the data argument. Use the widget fields directly in the template.
        /// </summary>
        /// <param name="value">The value for FooterTemplate</param>
        public ComboBoxBuilder FooterTemplate(string value)
        {
            Container.FooterTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the footer template. The footer template receives the widget itself as a part of the data argument. Use the widget fields directly in the template.
        /// </summary>
        /// <param name="value">The ID of the template element for FooterTemplate</param>
        public ComboBoxBuilder FooterTemplateId(string templateId)
        {
            Container.FooterTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the groups. By default the widget displays only the value of the group.
        /// </summary>
        /// <param name="value">The value for GroupTemplate</param>
        public ComboBoxBuilder GroupTemplate(string value)
        {
            Container.GroupTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the groups. By default the widget displays only the value of the group.
        /// </summary>
        /// <param name="value">The ID of the template element for GroupTemplate</param>
        public ComboBoxBuilder GroupTemplateId(string templateId)
        {
            Container.GroupTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The height of the suggestion popup in pixels. The default value is 200 pixels.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public ComboBoxBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// If set to true the first suggestion will be automatically highlighted.
        /// </summary>
        /// <param name="value">The value for HighlightFirst</param>
        public ComboBoxBuilder HighlightFirst(bool value)
        {
            Container.HighlightFirst = value;
            return this;
        }

        /// <summary>
        /// If set to false case-sensitive search will be performed to find suggestions. The widget performs case-insensitive searching by default.
        /// </summary>
        /// <param name="value">The value for IgnoreCase</param>
        public ComboBoxBuilder IgnoreCase(bool value)
        {
            Container.IgnoreCase = value;
            return this;
        }

        /// <summary>
        /// The minimum number of characters the user must type before a search is performed. Set to higher value than 1 if the search could match a lot of items.
        /// </summary>
        /// <param name="value">The value for MinLength</param>
        public ComboBoxBuilder MinLength(double value)
        {
            Container.MinLength = value;
            return this;
        }

        /// <summary>
        /// The template used to render the "no data" template, which will be displayed if no results are found or the underlying data source is empty.
		/// The noData template receives the widget itself as a part of the data argument. The template will be evaluated on every widget data bound.
        /// </summary>
        /// <param name="value">The value for NoDataTemplate</param>
        public ComboBoxBuilder NoDataTemplate(string value)
        {
            Container.NoDataTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the "no data" template, which will be displayed if no results are found or the underlying data source is empty.
		/// The noData template receives the widget itself as a part of the data argument. The template will be evaluated on every widget data bound.
        /// </summary>
        /// <param name="value">The ID of the template element for NoDataTemplate</param>
        public ComboBoxBuilder NoDataTemplateId(string templateId)
        {
            Container.NoDataTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The hint displayed by the widget when it is empty. Not set by default.
        /// </summary>
        /// <param name="value">The value for Placeholder</param>
        public ComboBoxBuilder Placeholder(string value)
        {
            Container.Placeholder = value;
            return this;
        }

        /// <summary>
        /// The options that will be used for the popup initialization. For more details about the available options
		/// refer to Popup documentation.
        /// </summary>
        /// <param name="configurator">The configurator for the popup setting.</param>
        public ComboBoxBuilder Popup(Action<ComboBoxPopupSettingsBuilder> configurator)
        {

            Container.Popup.ComboBox = Container;
            configurator(new ComboBoxPopupSettingsBuilder(Container.Popup));

            return this;
        }

        /// <summary>
        /// If set to true the widget will automatically use the first suggestion as its value.
        /// </summary>
        /// <param name="value">The value for Suggest</param>
        public ComboBoxBuilder Suggest(bool value)
        {
            Container.Suggest = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will automatically use the first suggestion as its value.
        /// </summary>
        public ComboBoxBuilder Suggest()
        {
            Container.Suggest = true;
            return this;
        }

        /// <summary>
        /// When set to true the widget will automatically set selected value to the typed custom text. Set the option to false to
		/// clear the selected value but keep the custom text.
        /// </summary>
        /// <param name="value">The value for SyncValueAndText</param>
        public ComboBoxBuilder SyncValueAndText(bool value)
        {
            Container.SyncValueAndText = value;
            return this;
        }

        /// <summary>
        /// Specifies a static HTML content, which will be rendered as a header of the popup element.
        /// </summary>
        /// <param name="value">The value for HeaderTemplate</param>
        public ComboBoxBuilder HeaderTemplate(string value)
        {
            Container.HeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// Specifies a static HTML content, which will be rendered as a header of the popup element.
        /// </summary>
        /// <param name="value">The ID of the template element for HeaderTemplate</param>
        public ComboBoxBuilder HeaderTemplateId(string templateId)
        {
            Container.HeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the items. By default the widget displays only the text of the data item (configured via dataTextField).
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ComboBoxBuilder Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template used to render the items. By default the widget displays only the text of the data item (configured via dataTextField).
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ComboBoxBuilder TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The text of the widget used when the autoBind is set to false.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public ComboBoxBuilder Text(string value)
        {
            Container.Text = value;
            return this;
        }

        /// <summary>
        /// The value of the widget.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public ComboBoxBuilder Value(string value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// Specifies the value binding behavior for the widget when the initial model value is null. If set to true, the View-Model field will be updated with the selected item value field. If set to false, the View-Model field will be updated with the selected item.
        /// </summary>
        /// <param name="value">The value for ValuePrimitive</param>
        public ComboBoxBuilder ValuePrimitive(bool value)
        {
            Container.ValuePrimitive = value;
            return this;
        }

        /// <summary>
        /// Specifies the value binding behavior for the widget when the initial model value is null. If set to true, the View-Model field will be updated with the selected item value field. If set to false, the View-Model field will be updated with the selected item.
        /// </summary>
        public ComboBoxBuilder ValuePrimitive()
        {
            Container.ValuePrimitive = true;
            return this;
        }

        /// <summary>
        /// Enables the virtualization feature of the widget. The configuration can be set on an object, which contains two properties - itemHeight and valueMapper.For detailed information, refer to the article on virtualization.
        /// </summary>
        /// <param name="configurator">The configurator for the virtual setting.</param>
        public ComboBoxBuilder Virtual(Action<ComboBoxVirtualSettingsBuilder> configurator)
        {
            Container.Virtual.Enabled = true;

            Container.Virtual.ComboBox = Container;
            configurator(new ComboBoxVirtualSettingsBuilder(Container.Virtual));

            return this;
        }

        /// <summary>
        /// Enables the virtualization feature of the widget. The configuration can be set on an object, which contains two properties - itemHeight and valueMapper.For detailed information, refer to the article on virtualization.
        /// </summary>
        public ComboBoxBuilder Virtual()
        {
            Container.Virtual.Enabled = true;
            return this;
        }

        /// <summary>
        /// Enables the virtualization feature of the widget. The configuration can be set on an object, which contains two properties - itemHeight and valueMapper.For detailed information, refer to the article on virtualization.
        /// </summary>
        /// <param name="enabled">Enables or disables the virtual option.</param>
        public ComboBoxBuilder Virtual(bool enabled)
        {
            Container.Virtual.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The filtering method used to determine the suggestions for the current value.
        /// </summary>
        /// <param name="value">The value for Filter</param>
        public ComboBoxBuilder Filter(FilterType value)
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
        /// @(Html.Kendo().ComboBox()
        ///       .Name("ComboBox")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public ComboBoxBuilder Events(Action<ComboBoxEventBuilder> configurator)
        {
            configurator(new ComboBoxEventBuilder(Container.Events));
            return this;
        }
        
    }
}

