namespace Kendo.Mvc.UI.Fluent
{
	public partial class WidgetFactory<TModel>
	{
        /// <summary>
        /// Creates a <see cref="ToolBar"/>
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ToolBar()
        ///             .Name("ToolBar")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual ToolBarBuilder ToolBar()
        {
            return new ToolBarBuilder(new ToolBar(HtmlHelper.ViewContext));
        }
    }
}