namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="TreeMap"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TreeMap()
        ///             .Name("TreeMap")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual TreeMapBuilder TreeMap()
        {
            return new TreeMapBuilder(new TreeMap(HtmlHelper.ViewContext));
        }
    }
}