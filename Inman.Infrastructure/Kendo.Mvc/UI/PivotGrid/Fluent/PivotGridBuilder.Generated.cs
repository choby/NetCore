using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI PivotGrid
    /// </summary>
    public partial class PivotGridBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to false the widget will not bind to the data source during initialization. In this case data binding will occur when the change event of the
		/// data source is fired. By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public PivotGridBuilder<T> AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// If set to false the user will not be able to add/close/reorder current fields for columns/rows/measures.
        /// </summary>
        /// <param name="value">The value for Reorderable</param>
        public PivotGridBuilder<T> Reorderable(bool value)
        {
            Container.Reorderable = value;
            return this;
        }

        /// <summary>
        /// Configures the Kendo UI PivotGrid Excel export settings.
        /// </summary>
        /// <param name="configurator">The configurator for the excel setting.</param>
        public PivotGridBuilder<T> Excel(Action<PivotGridExcelSettingsBuilder<T>> configurator)
        {

            Container.Excel.PivotGrid = Container;
            configurator(new PivotGridExcelSettingsBuilder<T>(Container.Excel));

            return this;
        }

        /// <summary>
        /// Configures the Kendo UI PivotGrid PDF export settings.
        /// </summary>
        /// <param name="configurator">The configurator for the pdf setting.</param>
        public PivotGridBuilder<T> Pdf(Action<PivotGridPdfSettingsBuilder<T>> configurator)
        {

            Container.Pdf.PivotGrid = Container;
            configurator(new PivotGridPdfSettingsBuilder<T>(Container.Pdf));

            return this;
        }

        /// <summary>
        /// If set to true the user will be able to filter by using the field menu.
        /// </summary>
        /// <param name="value">The value for Filterable</param>
        public PivotGridBuilder<T> Filterable(bool value)
        {
            Container.Filterable = value;
            return this;
        }

        /// <summary>
        /// If set to true the user will be able to filter by using the field menu.
        /// </summary>
        public PivotGridBuilder<T> Filterable()
        {
            Container.Filterable = true;
            return this;
        }

        /// <summary>
        /// If set to true the user could sort the pivotgrid by clicking the dimension fields. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the sortable setting.</param>
        public PivotGridBuilder<T> Sortable(Action<PivotGridSortableSettingsBuilder<T>> configurator)
        {
            Container.Sortable.Enabled = true;

            Container.Sortable.PivotGrid = Container;
            configurator(new PivotGridSortableSettingsBuilder<T>(Container.Sortable));

            return this;
        }

        /// <summary>
        /// If set to true the user could sort the pivotgrid by clicking the dimension fields. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        public PivotGridBuilder<T> Sortable()
        {
            Container.Sortable.Enabled = true;
            return this;
        }

        /// <summary>
        /// If set to true the user could sort the pivotgrid by clicking the dimension fields. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the sortable option.</param>
        public PivotGridBuilder<T> Sortable(bool enabled)
        {
            Container.Sortable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The width of the table columns. Value is treated as pixels.
        /// </summary>
        /// <param name="value">The value for ColumnWidth</param>
        public PivotGridBuilder<T> ColumnWidth(double value)
        {
            Container.ColumnWidth = value;
            return this;
        }

        /// <summary>
        /// The height of the PivotGrid. Numeric values are treated as pixels.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public PivotGridBuilder<T> Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// The template which renders the content of the column header cell. By default it renders the caption of the tuple member.The fields which can be used in the template are:For information about the tuple structure check this link.
        /// </summary>
        /// <param name="value">The value for ColumnHeaderTemplate</param>
        public PivotGridBuilder<T> ColumnHeaderTemplate(string value)
        {
            Container.ColumnHeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// The template which renders the content of the column header cell. By default it renders the caption of the tuple member.The fields which can be used in the template are:For information about the tuple structure check this link.
        /// </summary>
        /// <param name="value">The ID of the template element for ColumnHeaderTemplate</param>
        public PivotGridBuilder<T> ColumnHeaderTemplateId(string templateId)
        {
            Container.ColumnHeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template which renders the content of the data cell. By default renders the formatted value (fmtValue) of the data item.The fields which can be used in the template are:For information about the tuple structure check this link.
		/// About the data item structure review this help topic.
        /// </summary>
        /// <param name="value">The value for DataCellTemplate</param>
        public PivotGridBuilder<T> DataCellTemplate(string value)
        {
            Container.DataCellTemplate = value;
            return this;
        }

        /// <summary>
        /// The template which renders the content of the data cell. By default renders the formatted value (fmtValue) of the data item.The fields which can be used in the template are:For information about the tuple structure check this link.
		/// About the data item structure review this help topic.
        /// </summary>
        /// <param name="value">The ID of the template element for DataCellTemplate</param>
        public PivotGridBuilder<T> DataCellTemplateId(string templateId)
        {
            Container.DataCellTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template which renders the content of the row header cell. By default it renders the caption of the tuple member.The fields which can be used in the template are:For information about the tuple structure check this link.
        /// </summary>
        /// <param name="value">The value for RowHeaderTemplate</param>
        public PivotGridBuilder<T> RowHeaderTemplate(string value)
        {
            Container.RowHeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// The template which renders the content of the row header cell. By default it renders the caption of the tuple member.The fields which can be used in the template are:For information about the tuple structure check this link.
        /// </summary>
        /// <param name="value">The ID of the template element for RowHeaderTemplate</param>
        public PivotGridBuilder<T> RowHeaderTemplateId(string templateId)
        {
            Container.RowHeaderTemplateId = templateId;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().PivotGrid()
        ///       .Name("PivotGrid")
        ///       .Events(events => events
        ///           .DataBinding("onDataBinding")
        ///       )
        /// )
        /// </code>
        /// </example>
        public PivotGridBuilder<T> Events(Action<PivotGridEventBuilder> configurator)
        {
            configurator(new PivotGridEventBuilder(Container.Events));
            return this;
        }
        
    }
}

