using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Grid for ASP.NET MVC events.
    /// </summary>
    public class GridEventBuilder: EventBuilder
    {
        public GridEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fired when the user clicks the "cancel" button (in inline or popup editing mode) or closes the popup window.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the cancel event.</param>
        public GridEventBuilder Cancel(string handler)
        {
            Handler("cancel", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "cancel" button (in inline or popup editing mode) or closes the popup window.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder Cancel(Func<object, object> handler)
        {
            Handler("cancel", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user selects a table row or cell in the grid.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public GridEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user selects a table row or cell in the grid.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user hides a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnHide event.</param>
        public GridEventBuilder ColumnHide(string handler)
        {
            Handler("columnHide", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user hides a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder ColumnHide(Func<object, object> handler)
        {
            Handler("columnHide", handler);

            return this;
        }

        /// <summary>
        /// Fired when the column menu is initialized.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnMenuInit event.</param>
        public GridEventBuilder ColumnMenuInit(string handler)
        {
            Handler("columnMenuInit", handler);

            return this;
        }

        /// <summary>
        /// Fired when the column menu is initialized.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder ColumnMenuInit(Func<object, object> handler)
        {
            Handler("columnMenuInit", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user changes the order of a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnReorder event.</param>
        public GridEventBuilder ColumnReorder(string handler)
        {
            Handler("columnReorder", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user changes the order of a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder ColumnReorder(Func<object, object> handler)
        {
            Handler("columnReorder", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user resizes a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnResize event.</param>
        public GridEventBuilder ColumnResize(string handler)
        {
            Handler("columnResize", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user resizes a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder ColumnResize(Func<object, object> handler)
        {
            Handler("columnResize", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user shows a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnShow event.</param>
        public GridEventBuilder ColumnShow(string handler)
        {
            Handler("columnShow", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user shows a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder ColumnShow(Func<object, object> handler)
        {
            Handler("columnShow", handler);

            return this;
        }

        /// <summary>
        /// Fired before the widget binds to its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBinding event.</param>
        public GridEventBuilder DataBinding(string handler)
        {
            Handler("dataBinding", handler);

            return this;
        }

        /// <summary>
        /// Fired before the widget binds to its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder DataBinding(Func<object, object> handler)
        {
            Handler("dataBinding", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBound event.</param>
        public GridEventBuilder DataBound(string handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder DataBound(Func<object, object> handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user collapses a detail table row.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the detailCollapse event.</param>
        public GridEventBuilder DetailCollapse(string handler)
        {
            Handler("detailCollapse", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user collapses a detail table row.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder DetailCollapse(Func<object, object> handler)
        {
            Handler("detailCollapse", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user expands a detail table row.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the detailExpand event.</param>
        public GridEventBuilder DetailExpand(string handler)
        {
            Handler("detailExpand", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user expands a detail table row.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder DetailExpand(Func<object, object> handler)
        {
            Handler("detailExpand", handler);

            return this;
        }

        /// <summary>
        /// Fired when a detail table row is initialized.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the detailInit event.</param>
        public GridEventBuilder DetailInit(string handler)
        {
            Handler("detailInit", handler);

            return this;
        }

        /// <summary>
        /// Fired when a detail table row is initialized.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder DetailInit(Func<object, object> handler)
        {
            Handler("detailInit", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user edits or creates a data item.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the edit event.</param>
        public GridEventBuilder Edit(string handler)
        {
            Handler("edit", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user edits or creates a data item.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder Edit(Func<object, object> handler)
        {
            Handler("edit", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Export to Excel" toolbar button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the excelExport event.</param>
        public GridEventBuilder ExcelExport(string handler)
        {
            Handler("excelExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Export to Excel" toolbar button.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder ExcelExport(Func<object, object> handler)
        {
            Handler("excelExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user is about to filter the DataSource via the filter UI.The event handler function context (available via the this keyword) will be set to the widget instance.Introduced in the Kendo UI 2016 R3 (2016.3.914) release.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the filter event.</param>
        public GridEventBuilder Filter(string handler)
        {
            Handler("filter", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user is about to filter the DataSource via the filter UI.The event handler function context (available via the this keyword) will be set to the widget instance.Introduced in the Kendo UI 2016 R3 (2016.3.914) release.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder Filter(Func<object, object> handler)
        {
            Handler("filter", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user is about to group the DataSource or modify the group descriptors state via the Grid group panel.The event handler function context (available via the this keyword) will be set to the widget instance.Introduced in the Kendo UI 2016 R3 (2016.3.914) release.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the group event.</param>
        public GridEventBuilder Group(string handler)
        {
            Handler("group", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user is about to group the DataSource or modify the group descriptors state via the Grid group panel.The event handler function context (available via the this keyword) will be set to the widget instance.Introduced in the Kendo UI 2016 R3 (2016.3.914) release.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder Group(Func<object, object> handler)
        {
            Handler("group", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user is about change the current page index of DataSource via the pager UI.The event handler function context (available via the this keyword) will be set to the widget instance.Introduced in the Kendo UI 2016 R3 (2016.3.914) release.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the page event.</param>
        public GridEventBuilder Page(string handler)
        {
            Handler("page", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user is about change the current page index of DataSource via the pager UI.The event handler function context (available via the this keyword) will be set to the widget instance.Introduced in the Kendo UI 2016 R3 (2016.3.914) release.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder Page(Func<object, object> handler)
        {
            Handler("page", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Export to PDF" toolbar button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the pdfExport event.</param>
        public GridEventBuilder PdfExport(string handler)
        {
            Handler("pdfExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Export to PDF" toolbar button.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder PdfExport(Func<object, object> handler)
        {
            Handler("pdfExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the grid filter menu is initialized, when it is opened for the first time.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the filterMenuInit event.</param>
        public GridEventBuilder FilterMenuInit(string handler)
        {
            Handler("filterMenuInit", handler);

            return this;
        }

        /// <summary>
        /// Fired when the grid filter menu is initialized, when it is opened for the first time.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder FilterMenuInit(Func<object, object> handler)
        {
            Handler("filterMenuInit", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "destroy" command button.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the remove event.</param>
        public GridEventBuilder Remove(string handler)
        {
            Handler("remove", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "destroy" command button.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder Remove(Func<object, object> handler)
        {
            Handler("remove", handler);

            return this;
        }

        /// <summary>
        /// Fired when a data item is saved.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the save event.</param>
        public GridEventBuilder Save(string handler)
        {
            Handler("save", handler);

            return this;
        }

        /// <summary>
        /// Fired when a data item is saved.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder Save(Func<object, object> handler)
        {
            Handler("save", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "save" command button.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the saveChanges event.</param>
        public GridEventBuilder SaveChanges(string handler)
        {
            Handler("saveChanges", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "save" command button.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder SaveChanges(Func<object, object> handler)
        {
            Handler("saveChanges", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user is about to modify the current state of sort descriptors of DataSource via the sort UI.The event handler function context (available via the this keyword) will be set to the widget instance.Introduced in the Kendo UI 2016 R3 (2016.3.914) release.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the sort event.</param>
        public GridEventBuilder Sort(string handler)
        {
            Handler("sort", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user is about to modify the current state of sort descriptors of DataSource via the sort UI.The event handler function context (available via the this keyword) will be set to the widget instance.Introduced in the Kendo UI 2016 R3 (2016.3.914) release.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder Sort(Func<object, object> handler)
        {
            Handler("sort", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user lock a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnLock event.</param>
        public GridEventBuilder ColumnLock(string handler)
        {
            Handler("columnLock", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user lock a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder ColumnLock(Func<object, object> handler)
        {
            Handler("columnLock", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user unlock a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnUnlock event.</param>
        public GridEventBuilder ColumnUnlock(string handler)
        {
            Handler("columnUnlock", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user unlock a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder ColumnUnlock(Func<object, object> handler)
        {
            Handler("columnUnlock", handler);

            return this;
        }

        /// <summary>
        /// Fired when navigatable is enabled and the user change current item with either\n\t\t/// mouse or keyboard interaction.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the navigate event.</param>
        public GridEventBuilder Navigate(string handler)
        {
            Handler("navigate", handler);

            return this;
        }

        /// <summary>
        /// Fired when navigatable is enabled and the user change current item with either\n\t\t/// mouse or keyboard interaction.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public GridEventBuilder Navigate(Func<object, object> handler)
        {
            Handler("navigate", handler);

            return this;
        }

    }
}

