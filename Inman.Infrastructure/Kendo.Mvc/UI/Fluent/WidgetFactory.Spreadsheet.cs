namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a <see cref="Spreadsheet"/>
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Spreadsheet()
        ///             .Name("Spreadsheet")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual SpreadsheetBuilder Spreadsheet()
        {
            return new SpreadsheetBuilder(new Spreadsheet(HtmlHelper.ViewContext));
        }
    }
}