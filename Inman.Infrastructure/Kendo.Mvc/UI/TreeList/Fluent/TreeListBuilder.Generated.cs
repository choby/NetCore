using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI TreeList
    /// </summary>
    public partial class TreeListBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to false the widget will not bind to the data source during initialization. In this case data binding will occur when the change event of the
		/// data source is fired. By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public TreeListBuilder<T> AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// The configuration of the treelist columns. An array of JavaScript objects or strings. JavaScript objects are interpreted as column configurations. Strings are interpreted as the
		/// field to which the column is bound. The treelist will create a column for every item of the array.
        /// </summary>
        /// <param name="configurator">The configurator for the columns setting.</param>
        public TreeListBuilder<T> Columns(Action<TreeListColumnFactory<T>> configurator)
        {

            configurator(new TreeListColumnFactory<T>(Container.Columns)
            {
                TreeList = Container
            });

            return this;
        }

        /// <summary>
        /// If set to true allows users to resize columns by dragging their header borders. By default resizing is disabled.
        /// </summary>
        /// <param name="value">The value for Resizable</param>
        public TreeListBuilder<T> Resizable(bool value)
        {
            Container.Resizable = value;
            return this;
        }

        /// <summary>
        /// If set to true allows users to resize columns by dragging their header borders. By default resizing is disabled.
        /// </summary>
        public TreeListBuilder<T> Resizable()
        {
            Container.Resizable = true;
            return this;
        }

        /// <summary>
        /// If set to true the user could reorder the columns by dragging their header cells. By default reordering is disabled.
        /// </summary>
        /// <param name="value">The value for Reorderable</param>
        public TreeListBuilder<T> Reorderable(bool value)
        {
            Container.Reorderable = value;
            return this;
        }

        /// <summary>
        /// If set to true the user could reorder the columns by dragging their header cells. By default reordering is disabled.
        /// </summary>
        public TreeListBuilder<T> Reorderable()
        {
            Container.Reorderable = true;
            return this;
        }

        /// <summary>
        /// If set to true the treelist will display the column menu when the user clicks the chevron icon in the column headers. The column menu allows the user to show and hide columns, filter and sort (if filtering and sorting are enabled).
		/// By default the column menu is not enabled.Can be set to a JavaScript object which represents the column menu configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the columnmenu setting.</param>
        public TreeListBuilder<T> ColumnMenu(Action<TreeListColumnMenuSettingsBuilder<T>> configurator)
        {
            Container.ColumnMenu.Enabled = true;

            Container.ColumnMenu.TreeList = Container;
            configurator(new TreeListColumnMenuSettingsBuilder<T>(Container.ColumnMenu));

            return this;
        }

        /// <summary>
        /// If set to true the treelist will display the column menu when the user clicks the chevron icon in the column headers. The column menu allows the user to show and hide columns, filter and sort (if filtering and sorting are enabled).
		/// By default the column menu is not enabled.Can be set to a JavaScript object which represents the column menu configuration.
        /// </summary>
        public TreeListBuilder<T> ColumnMenu()
        {
            Container.ColumnMenu.Enabled = true;
            return this;
        }

        /// <summary>
        /// If set to true the treelist will display the column menu when the user clicks the chevron icon in the column headers. The column menu allows the user to show and hide columns, filter and sort (if filtering and sorting are enabled).
		/// By default the column menu is not enabled.Can be set to a JavaScript object which represents the column menu configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the columnmenu option.</param>
        public TreeListBuilder<T> ColumnMenu(bool enabled)
        {
            Container.ColumnMenu.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// If set to true the user would be able to edit the data to which the treelist is bound. By default editing is disabled.Can be set to a string ("inline" or "popup") to specify the editing mode. The default editing mode is "inline".Can be set to a JavaScript object which represents the editing configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the editable setting.</param>
        public TreeListBuilder<T> Editable(Action<TreeListEditableSettingsBuilder<T>> configurator)
        {
            Container.Editable.Enabled = true;

            Container.Editable.TreeList = Container;
            configurator(new TreeListEditableSettingsBuilder<T>(Container.Editable));

            return this;
        }

        /// <summary>
        /// If set to true the user would be able to edit the data to which the treelist is bound. By default editing is disabled.Can be set to a string ("inline" or "popup") to specify the editing mode. The default editing mode is "inline".Can be set to a JavaScript object which represents the editing configuration.
        /// </summary>
        public TreeListBuilder<T> Editable()
        {
            Container.Editable.Enabled = true;
            return this;
        }

        /// <summary>
        /// If set to true the user would be able to edit the data to which the treelist is bound. By default editing is disabled.Can be set to a string ("inline" or "popup") to specify the editing mode. The default editing mode is "inline".Can be set to a JavaScript object which represents the editing configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the editable option.</param>
        public TreeListBuilder<T> Editable(bool enabled)
        {
            Container.Editable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Configures the Kendo UI TreeList Excel export settings.
        /// </summary>
        /// <param name="configurator">The configurator for the excel setting.</param>
        public TreeListBuilder<T> Excel(Action<TreeListExcelSettingsBuilder<T>> configurator)
        {

            Container.Excel.TreeList = Container;
            configurator(new TreeListExcelSettingsBuilder<T>(Container.Excel));

            return this;
        }

        /// <summary>
        /// If set to true the user can filter the data source using the treelist filter menu. Filtering is disabled by default.Can be set to a JavaScript object which represents the filter menu configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the filterable setting.</param>
        public TreeListBuilder<T> Filterable(Action<TreeListFilterableSettingsBuilder<T>> configurator)
        {
            Container.Filterable.Enabled = true;

            Container.Filterable.TreeList = Container;
            configurator(new TreeListFilterableSettingsBuilder<T>(Container.Filterable));

            return this;
        }

        /// <summary>
        /// If set to true the user can filter the data source using the treelist filter menu. Filtering is disabled by default.Can be set to a JavaScript object which represents the filter menu configuration.
        /// </summary>
        public TreeListBuilder<T> Filterable()
        {
            Container.Filterable.Enabled = true;
            return this;
        }

        /// <summary>
        /// If set to true the user can filter the data source using the treelist filter menu. Filtering is disabled by default.Can be set to a JavaScript object which represents the filter menu configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the filterable option.</param>
        public TreeListBuilder<T> Filterable(bool enabled)
        {
            Container.Filterable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The height of the treelist. Numeric values are treated as pixels.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public TreeListBuilder<T> Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// Defines the text of the command buttons that are shown within the TreeList. Used primarily for localization.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public TreeListBuilder<T> Messages(Action<TreeListMessagesSettingsBuilder<T>> configurator)
        {

            Container.Messages.TreeList = Container;
            configurator(new TreeListMessagesSettingsBuilder<T>(Container.Messages));

            return this;
        }

        /// <summary>
        /// Configures the Kendo UI TreeList PDF export settings.
        /// </summary>
        /// <param name="configurator">The configurator for the pdf setting.</param>
        public TreeListBuilder<T> Pdf(Action<TreeListPdfSettingsBuilder<T>> configurator)
        {

            Container.Pdf.TreeList = Container;
            configurator(new TreeListPdfSettingsBuilder<T>(Container.Pdf));

            return this;
        }

        /// <summary>
        /// If set to true the TreeList will display a scrollbar when the total row height (or width) exceeds the TreeList height (or width). By default scrolling is enabled.Scrolling renders separate tables for the header and data area. For accessibility-conscious applications, disable scrolling.
        /// </summary>
        /// <param name="value">The value for Scrollable</param>
        public TreeListBuilder<T> Scrollable(bool value)
        {
            Container.Scrollable = value;
            return this;
        }

        /// <summary>
        /// If set to true the user could sort the treelist by clicking the column header cells. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the sortable setting.</param>
        public TreeListBuilder<T> Sortable(Action<TreeListSortableSettingsBuilder<T>> configurator)
        {
            Container.Sortable.Enabled = true;

            Container.Sortable.TreeList = Container;
            configurator(new TreeListSortableSettingsBuilder<T>(Container.Sortable));

            return this;
        }

        /// <summary>
        /// If set to true the user could sort the treelist by clicking the column header cells. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        public TreeListBuilder<T> Sortable()
        {
            Container.Sortable.Enabled = true;
            return this;
        }

        /// <summary>
        /// If set to true the user could sort the treelist by clicking the column header cells. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the sortable option.</param>
        public TreeListBuilder<T> Sortable(bool enabled)
        {
            Container.Sortable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// If a String value is assigned to the toolbar configuration option, it will be treated as a single string template for the whole treelist Toolbar,
		/// and the string value will be passed as an argument to a kendo.template() function.If a Function value is assigned (it may be a kendo.template() function call or a generic function reference), then the return value of the function will be used to render the treelist Toolbar contents.If an Array value is assigned, it will be treated as the list of commands displayed in the treelist Toolbar. Commands can be custom or built-in ("create", "excel", "pdf").
        /// </summary>
        /// <param name="configurator">The configurator for the toolbar setting.</param>
        public TreeListBuilder<T> Toolbar(Action<TreeListToolbarFactory<T>> configurator)
        {

            configurator(new TreeListToolbarFactory<T>(Container.Toolbar)
            {
                TreeList = Container
            });

            return this;
        }

        /// <summary>
        /// Specifies whether TreeList selection is allowed. By default selection is disabled
        /// </summary>
        /// <param name="configurator">The configurator for the selectable setting.</param>
        public TreeListBuilder<T> Selectable(Action<TreeListSelectableSettingsBuilder<T>> configurator)
        {
            Container.Selectable.Enabled = true;

            Container.Selectable.TreeList = Container;
            configurator(new TreeListSelectableSettingsBuilder<T>(Container.Selectable));

            return this;
        }

        /// <summary>
        /// Specifies whether TreeList selection is allowed. By default selection is disabled
        /// </summary>
        /// <param name="enabled">Enables or disables the selectable option.</param>
        public TreeListBuilder<T> Selectable(bool enabled)
        {
            Container.Selectable.Enabled = enabled;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().TreeList()
        ///       .Name("TreeList")
        ///       .Events(events => events
        ///           .Cancel("onCancel")
        ///       )
        /// )
        /// </code>
        /// </example>
        public TreeListBuilder<T> Events(Action<TreeListEventBuilder> configurator)
        {
            configurator(new TreeListEventBuilder(Container.Events));
            return this;
        }
        
    }
}

