using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Grid
    /// </summary>
    public partial class GridBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to true and selection of the Grid is enabled the user could copy the selection into the clipboard and paste it into Excel or other similar programs that understand TSV/CSV formats. By default allowCopy is disabled and the default format is TSV.
		/// Can be set to a JavaScript object which represents the allowCopy configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the allowcopy setting.</param>
        public GridBuilder<T> AllowCopy(Action<GridAllowCopySettingsBuilder<T>> configurator)
        {
            Container.AllowCopy.Enabled = true;

            Container.AllowCopy.Grid = Container;
            configurator(new GridAllowCopySettingsBuilder<T>(Container.AllowCopy));

            return this;
        }

        /// <summary>
        /// If set to true and selection of the Grid is enabled the user could copy the selection into the clipboard and paste it into Excel or other similar programs that understand TSV/CSV formats. By default allowCopy is disabled and the default format is TSV.
		/// Can be set to a JavaScript object which represents the allowCopy configuration.
        /// </summary>
        public GridBuilder<T> AllowCopy()
        {
            Container.AllowCopy.Enabled = true;
            return this;
        }

        /// <summary>
        /// If set to true and selection of the Grid is enabled the user could copy the selection into the clipboard and paste it into Excel or other similar programs that understand TSV/CSV formats. By default allowCopy is disabled and the default format is TSV.
		/// Can be set to a JavaScript object which represents the allowCopy configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the allowcopy option.</param>
        public GridBuilder<T> AllowCopy(bool enabled)
        {
            Container.AllowCopy.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// If set to false, the Grid will not bind to the data source during initialization, i.e. it will not call the fetch method of the dataSource instance. In such scenarios data binding will occur when the change event of the
		/// dataSource instance is fired. By default, autoBind is set to true and the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public GridBuilder<T> AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// Defines the width of the column resize handle in pixels. Apply a larger value for easier grasping.
        /// </summary>
        /// <param name="value">The value for ColumnResizeHandleWidth</param>
        public GridBuilder<T> ColumnResizeHandleWidth(double value)
        {
            Container.ColumnResizeHandleWidth = value;
            return this;
        }

        /// <summary>
        /// If set to true the grid will display the column menu when the user clicks the chevron icon in the column headers. The column menu allows the user to show and hide columns, filter and sort (if filtering and sorting are enabled).
		/// By default the column menu is not enabled.Can be set to a JavaScript object which represents the column menu configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the columnmenu setting.</param>
        public GridBuilder<T> ColumnMenu(Action<GridColumnMenuSettingsBuilder<T>> configurator)
        {
            Container.ColumnMenu.Enabled = true;

            Container.ColumnMenu.Grid = Container;
            configurator(new GridColumnMenuSettingsBuilder<T>(Container.ColumnMenu));

            return this;
        }

        /// <summary>
        /// If set to true the grid will display the column menu when the user clicks the chevron icon in the column headers. The column menu allows the user to show and hide columns, filter and sort (if filtering and sorting are enabled).
		/// By default the column menu is not enabled.Can be set to a JavaScript object which represents the column menu configuration.
        /// </summary>
        public GridBuilder<T> ColumnMenu()
        {
            Container.ColumnMenu.Enabled = true;
            return this;
        }

        /// <summary>
        /// If set to true the grid will display the column menu when the user clicks the chevron icon in the column headers. The column menu allows the user to show and hide columns, filter and sort (if filtering and sorting are enabled).
		/// By default the column menu is not enabled.Can be set to a JavaScript object which represents the column menu configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the columnmenu option.</param>
        public GridBuilder<T> ColumnMenu(bool enabled)
        {
            Container.ColumnMenu.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Configures the Kendo UI Grid Excel export settings.
        /// </summary>
        /// <param name="configurator">The configurator for the excel setting.</param>
        public GridBuilder<T> Excel(Action<GridExcelSettingsBuilder<T>> configurator)
        {

            Container.Excel.Grid = Container;
            configurator(new GridExcelSettingsBuilder<T>(Container.Excel));

            return this;
        }

        /// <summary>
        /// If set to true the user could group the grid by dragging the column header cells. By default grouping is disabled.Can be set to a JavaScript object which represents the grouping configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the groupable setting.</param>
        public GridBuilder<T> Groupable(Action<GridGroupableSettingsBuilder<T>> configurator)
        {
            Container.Groupable.Enabled = true;

            Container.Groupable.Grid = Container;
            configurator(new GridGroupableSettingsBuilder<T>(Container.Groupable));

            return this;
        }

        /// <summary>
        /// If set to true the user could group the grid by dragging the column header cells. By default grouping is disabled.Can be set to a JavaScript object which represents the grouping configuration.
        /// </summary>
        public GridBuilder<T> Groupable()
        {
            Container.Groupable.Enabled = true;
            return this;
        }

        /// <summary>
        /// If set to true the user could group the grid by dragging the column header cells. By default grouping is disabled.Can be set to a JavaScript object which represents the grouping configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the groupable option.</param>
        public GridBuilder<T> Groupable(bool enabled)
        {
            Container.Groupable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// If set to true the use could navigate the widget using the keyboard navigation. By default keyboard navigation is disabled.
        /// </summary>
        /// <param name="value">The value for Navigatable</param>
        public GridBuilder<T> Navigatable(bool value)
        {
            Container.Navigatable = value;
            return this;
        }

        /// <summary>
        /// If set to true the use could navigate the widget using the keyboard navigation. By default keyboard navigation is disabled.
        /// </summary>
        public GridBuilder<T> Navigatable()
        {
            Container.Navigatable = true;
            return this;
        }

        /// <summary>
        /// If set to true and current view contains no records, message similar to "No records available" will be displayed. By default this option is disabled.
        /// </summary>
        /// <param name="configurator">The configurator for the norecords setting.</param>
        public GridBuilder<T> NoRecords(Action<GridNoRecordsSettingsBuilder<T>> configurator)
        {
            Container.NoRecords.Enabled = true;

            Container.NoRecords.Grid = Container;
            configurator(new GridNoRecordsSettingsBuilder<T>(Container.NoRecords));

            return this;
        }

        /// <summary>
        /// If set to true and current view contains no records, message similar to "No records available" will be displayed. By default this option is disabled.
        /// </summary>
        public GridBuilder<T> NoRecords()
        {
            Container.NoRecords.Enabled = true;
            return this;
        }

        /// <summary>
        /// If set to true and current view contains no records, message similar to "No records available" will be displayed. By default this option is disabled.
        /// </summary>
        /// <param name="enabled">Enables or disables the norecords option.</param>
        public GridBuilder<T> NoRecords(bool enabled)
        {
            Container.NoRecords.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Configures the Kendo UI Grid PDF export settings.
        /// </summary>
        /// <param name="configurator">The configurator for the pdf setting.</param>
        public GridBuilder<T> Pdf(Action<GridPdfSettingsBuilder<T>> configurator)
        {

            Container.Pdf.Grid = Container;
            configurator(new GridPdfSettingsBuilder<T>(Container.Pdf));

            return this;
        }

        /// <summary>
        /// If set to true the user could sort the grid by clicking the column header cells. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the sortable setting.</param>
        public GridBuilder<T> Sortable(Action<GridSortableSettingsBuilder<T>> configurator)
        {
            Container.Sortable.Enabled = true;

            Container.Sortable.Grid = Container;
            configurator(new GridSortableSettingsBuilder<T>(Container.Sortable));

            return this;
        }

        /// <summary>
        /// If set to true the user could sort the grid by clicking the column header cells. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        public GridBuilder<T> Sortable()
        {
            Container.Sortable.Enabled = true;
            return this;
        }

        /// <summary>
        /// If set to true the user could sort the grid by clicking the column header cells. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the sortable option.</param>
        public GridBuilder<T> Sortable(bool enabled)
        {
            Container.Sortable.Enabled = enabled;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Grid()
        ///       .Name("Grid")
        ///       .Events(events => events
        ///           .Cancel("onCancel")
        ///       )
        /// )
        /// </code>
        /// </example>
        public GridBuilder<T> Events(Action<GridEventBuilder> configurator)
        {
            configurator(new GridEventBuilder(Container.Events));
            return this;
        }
        
    }
}

