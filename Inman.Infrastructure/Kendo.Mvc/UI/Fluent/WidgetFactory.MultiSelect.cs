namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="MultiSelect"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().MultiSelect()
        ///             .Name("MultiSelect")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Text("First Item");
        ///                 items.Add().Text("Second Item");
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public virtual MultiSelectBuilder MultiSelect()
        {
            return new MultiSelectBuilder(new MultiSelect(HtmlHelper.ViewContext));
        }
    }
}