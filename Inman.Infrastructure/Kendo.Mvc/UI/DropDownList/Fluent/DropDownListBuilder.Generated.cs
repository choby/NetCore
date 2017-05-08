using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI DropDownList
    /// </summary>
    public partial class DropDownListBuilder
        
    {
        /// <summary>
        /// Controls whether to bind the widget to the data source on initialization.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public DropDownListBuilder AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// If set to true, the widget automatically adjusts the width of the popup element and does not wrap up the item label.
        /// </summary>
        /// <param name="value">The value for AutoWidth</param>
        public DropDownListBuilder AutoWidth(bool value)
        {
            Container.AutoWidth = value;
            return this;
        }

        /// <summary>
        /// Use it to set the Id of the parent DropDownList widget.
		/// Help topic showing how cascading functionality works
        /// </summary>
        /// <param name="value">The value for CascadeFrom</param>
        public DropDownListBuilder CascadeFrom(string value)
        {
            Container.CascadeFrom = value;
            return this;
        }

        /// <summary>
        /// Defines the field to be used to filter the data source. If not defined the parent's dataValueField option will be used.
		/// Help topic showing how cascading functionality works
        /// </summary>
        /// <param name="value">The value for CascadeFromField</param>
        public DropDownListBuilder CascadeFromField(string value)
        {
            Container.CascadeFromField = value;
            return this;
        }

        /// <summary>
        /// The field of the data item that provides the text content of the list items. The widget will filter the data source based on this field.
        /// </summary>
        /// <param name="value">The value for DataTextField</param>
        public DropDownListBuilder DataTextField(string value)
        {
            Container.DataTextField = value;
            return this;
        }

        /// <summary>
        /// The field of the data item that provides the value of the widget.
        /// </summary>
        /// <param name="value">The value for DataValueField</param>
        public DropDownListBuilder DataValueField(string value)
        {
            Container.DataValueField = value;
            return this;
        }

        /// <summary>
        /// Specifies the delay in milliseconds before the search-text typed by the end user is cleared.
        /// </summary>
        /// <param name="value">The value for Delay</param>
        public DropDownListBuilder Delay(double value)
        {
            Container.Delay = value;
            return this;
        }

        /// <summary>
        /// If set to false the widget will be disabled and will not allow user input. The widget is enabled by default and allows user input.
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public DropDownListBuilder Enable(bool value)
        {
            Container.Enable = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will not show all items when the text of the search input cleared. By default the widget shows all items when the text of the search input is cleared. Works in conjunction with minLength.
        /// </summary>
        /// <param name="value">The value for EnforceMinLength</param>
        public DropDownListBuilder EnforceMinLength(bool value)
        {
            Container.EnforceMinLength = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will not show all items when the text of the search input cleared. By default the widget shows all items when the text of the search input is cleared. Works in conjunction with minLength.
        /// </summary>
        public DropDownListBuilder EnforceMinLength()
        {
            Container.EnforceMinLength = true;
            return this;
        }

        /// <summary>
        /// The template used to render the fixed header group. By default the widget displays only the value of the current group.
        /// </summary>
        /// <param name="value">The value for FixedGroupTemplate</param>
        public DropDownListBuilder FixedGroupTemplate(string value)
        {
            Container.FixedGroupTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the fixed header group. By default the widget displays only the value of the current group.
        /// </summary>
        /// <param name="value">The ID of the template element for FixedGroupTemplate</param>
        public DropDownListBuilder FixedGroupTemplateId(string templateId)
        {
            Container.FixedGroupTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the footer template. The footer template receives the widget itself as a part of the data argument. Use the widget fields directly in the template.
        /// </summary>
        /// <param name="value">The value for FooterTemplate</param>
        public DropDownListBuilder FooterTemplate(string value)
        {
            Container.FooterTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the footer template. The footer template receives the widget itself as a part of the data argument. Use the widget fields directly in the template.
        /// </summary>
        /// <param name="value">The ID of the template element for FooterTemplate</param>
        public DropDownListBuilder FooterTemplateId(string templateId)
        {
            Container.FooterTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the groups. By default the widget displays only the value of the group.
        /// </summary>
        /// <param name="value">The value for GroupTemplate</param>
        public DropDownListBuilder GroupTemplate(string value)
        {
            Container.GroupTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the groups. By default the widget displays only the value of the group.
        /// </summary>
        /// <param name="value">The ID of the template element for GroupTemplate</param>
        public DropDownListBuilder GroupTemplateId(string templateId)
        {
            Container.GroupTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The height of the suggestion popup in pixels. The default value is 200 pixels.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public DropDownListBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// If set to false case-sensitive search will be performed to find suggestions. The widget performs case-insensitive searching by default.
        /// </summary>
        /// <param name="value">The value for IgnoreCase</param>
        public DropDownListBuilder IgnoreCase(bool value)
        {
            Container.IgnoreCase = value;
            return this;
        }

        /// <summary>
        /// The minimum number of characters the user must type before a filter is performed. Set to higher value than 1 if the search could match a lot of items.
        /// </summary>
        /// <param name="value">The value for MinLength</param>
        public DropDownListBuilder MinLength(double value)
        {
            Container.MinLength = value;
            return this;
        }

        /// <summary>
        /// The template used to render the "no data" template, which will be displayed if no results are found or the underlying data source is empty.
		/// The noData template receives the widget itself as a part of the data argument. The template will be evaluated on every widget data bound.
        /// </summary>
        /// <param name="value">The value for NoDataTemplate</param>
        public DropDownListBuilder NoDataTemplate(string value)
        {
            Container.NoDataTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the "no data" template, which will be displayed if no results are found or the underlying data source is empty.
		/// The noData template receives the widget itself as a part of the data argument. The template will be evaluated on every widget data bound.
        /// </summary>
        /// <param name="value">The ID of the template element for NoDataTemplate</param>
        public DropDownListBuilder NoDataTemplateId(string templateId)
        {
            Container.NoDataTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The options that will be used for the popup initialization. For more details about the available options
		/// refer to Popup documentation.
        /// </summary>
        /// <param name="configurator">The configurator for the popup setting.</param>
        public DropDownListBuilder Popup(Action<DropDownListPopupSettingsBuilder> configurator)
        {

            Container.Popup.DropDownList = Container;
            configurator(new DropDownListPopupSettingsBuilder(Container.Popup));

            return this;
        }

        /// <summary>
        /// Define the text of the default empty item. If the value is an object, then the widget will use it as a valid data item.
		///  Note that the optionLabel will not be available if the widget is empty.
        /// </summary>
        /// <param name="value">The value for OptionLabel</param>
        public DropDownListBuilder OptionLabel(object value)
        {
            Container.OptionLabel = value;
            return this;
        }

        /// <summary>
        /// The template used to render the option label.
        /// </summary>
        /// <param name="value">The value for OptionLabelTemplate</param>
        public DropDownListBuilder OptionLabelTemplate(string value)
        {
            Container.OptionLabelTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the option label.
        /// </summary>
        /// <param name="value">The ID of the template element for OptionLabelTemplate</param>
        public DropDownListBuilder OptionLabelTemplateId(string templateId)
        {
            Container.OptionLabelTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Specifies a static HTML content, which will be rendered as a header of the popup element.
        /// </summary>
        /// <param name="value">The value for HeaderTemplate</param>
        public DropDownListBuilder HeaderTemplate(string value)
        {
            Container.HeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// Specifies a static HTML content, which will be rendered as a header of the popup element.
        /// </summary>
        /// <param name="value">The ID of the template element for HeaderTemplate</param>
        public DropDownListBuilder HeaderTemplateId(string templateId)
        {
            Container.HeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the items. By default the widget displays only the text of the data item (configured via dataTextField).
        /// </summary>
        /// <param name="value">The value for Template</param>
        public DropDownListBuilder Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template used to render the items. By default the widget displays only the text of the data item (configured via dataTextField).
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public DropDownListBuilder TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The valueTemplate used to render the selected value. By default the widget displays only the text of the data item (configured via dataTextField).
        /// </summary>
        /// <param name="value">The value for ValueTemplate</param>
        public DropDownListBuilder ValueTemplate(string value)
        {
            Container.ValueTemplate = value;
            return this;
        }

        /// <summary>
        /// The valueTemplate used to render the selected value. By default the widget displays only the text of the data item (configured via dataTextField).
        /// </summary>
        /// <param name="value">The ID of the template element for ValueTemplate</param>
        public DropDownListBuilder ValueTemplateId(string templateId)
        {
            Container.ValueTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The text of the widget used when the autoBind is set to false.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public DropDownListBuilder Text(string value)
        {
            Container.Text = value;
            return this;
        }

        /// <summary>
        /// The value of the widget.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public DropDownListBuilder Value(string value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// Specifies the value binding behavior for the widget when the initial model value is null. If set to true, the View-Model field will be updated with the selected item value field. If set to false, the View-Model field will be updated with the selected item.
        /// </summary>
        /// <param name="value">The value for ValuePrimitive</param>
        public DropDownListBuilder ValuePrimitive(bool value)
        {
            Container.ValuePrimitive = value;
            return this;
        }

        /// <summary>
        /// Specifies the value binding behavior for the widget when the initial model value is null. If set to true, the View-Model field will be updated with the selected item value field. If set to false, the View-Model field will be updated with the selected item.
        /// </summary>
        public DropDownListBuilder ValuePrimitive()
        {
            Container.ValuePrimitive = true;
            return this;
        }

        /// <summary>
        /// Enables the virtualization feature of the widget. The configuration can be set on an object, which contains two properties - itemHeight and valueMapper.For detailed information, refer to the article on virtualization.
        /// </summary>
        /// <param name="configurator">The configurator for the virtual setting.</param>
        public DropDownListBuilder Virtual(Action<DropDownListVirtualSettingsBuilder> configurator)
        {
            Container.Virtual.Enabled = true;

            Container.Virtual.DropDownList = Container;
            configurator(new DropDownListVirtualSettingsBuilder(Container.Virtual));

            return this;
        }

        /// <summary>
        /// Enables the virtualization feature of the widget. The configuration can be set on an object, which contains two properties - itemHeight and valueMapper.For detailed information, refer to the article on virtualization.
        /// </summary>
        public DropDownListBuilder Virtual()
        {
            Container.Virtual.Enabled = true;
            return this;
        }

        /// <summary>
        /// Enables the virtualization feature of the widget. The configuration can be set on an object, which contains two properties - itemHeight and valueMapper.For detailed information, refer to the article on virtualization.
        /// </summary>
        /// <param name="enabled">Enables or disables the virtual option.</param>
        public DropDownListBuilder Virtual(bool enabled)
        {
            Container.Virtual.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The filtering method used to determine the suggestions for the current value. Filtration is turned off by default.
        /// </summary>
        /// <param name="value">The value for Filter</param>
        public DropDownListBuilder Filter(FilterType value)
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
        /// @(Html.Kendo().DropDownList()
        ///       .Name("DropDownList")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public DropDownListBuilder Events(Action<DropDownListEventBuilder> configurator)
        {
            configurator(new DropDownListEventBuilder(Container.Events));
            return this;
        }
        
    }
}

