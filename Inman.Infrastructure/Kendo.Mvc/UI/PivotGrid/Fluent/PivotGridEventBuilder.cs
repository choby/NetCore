using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI PivotGrid for ASP.NET MVC events.
    /// </summary>
    public class PivotGridEventBuilder: EventBuilder
    {
        public PivotGridEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fired before the widget binds to its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBinding event.</param>
        public PivotGridEventBuilder DataBinding(string handler)
        {
            Handler("dataBinding", handler);

            return this;
        }

        /// <summary>
        /// Fired before the widget binds to its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PivotGridEventBuilder DataBinding(Func<object, object> handler)
        {
            Handler("dataBinding", handler);

            return this;
        }

        /// <summary>
        /// Fired after the widget is bound to the data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBound event.</param>
        public PivotGridEventBuilder DataBound(string handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired after the widget is bound to the data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PivotGridEventBuilder DataBound(Func<object, object> handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired before column or row field is expanded.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the expandMember event.</param>
        public PivotGridEventBuilder ExpandMember(string handler)
        {
            Handler("expandMember", handler);

            return this;
        }

        /// <summary>
        /// Fired before column or row field is expanded.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PivotGridEventBuilder ExpandMember(Func<object, object> handler)
        {
            Handler("expandMember", handler);

            return this;
        }

        /// <summary>
        /// Fired before column or row field is collapsed.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the collapseMember event.</param>
        public PivotGridEventBuilder CollapseMember(string handler)
        {
            Handler("collapseMember", handler);

            return this;
        }

        /// <summary>
        /// Fired before column or row field is collapsed.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PivotGridEventBuilder CollapseMember(Func<object, object> handler)
        {
            Handler("collapseMember", handler);

            return this;
        }

        /// <summary>
        /// Fired when saveAsExcel method is called.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the excelExport event.</param>
        public PivotGridEventBuilder ExcelExport(string handler)
        {
            Handler("excelExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when saveAsExcel method is called.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PivotGridEventBuilder ExcelExport(Func<object, object> handler)
        {
            Handler("excelExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Export to PDF" toolbar button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the pdfExport event.</param>
        public PivotGridEventBuilder PdfExport(string handler)
        {
            Handler("pdfExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Export to PDF" toolbar button.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PivotGridEventBuilder PdfExport(Func<object, object> handler)
        {
            Handler("pdfExport", handler);

            return this;
        }

    }
}

