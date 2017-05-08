namespace Kendo.Mvc.UI.Fluent
{
	public partial class WidgetFactory<TModel>
	{
        /// <summary>
        /// Creates a new <see cref="Tooltip"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Tooltip()
        ///             .For("Container")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual TooltipBuilder Tooltip()
        {
            return new TooltipBuilder(new Tooltip(HtmlHelper.ViewContext));
        }
    }
}