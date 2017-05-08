namespace Kendo.Mvc.UI.Fluent
{
	public partial class WidgetFactory<TModel>
	{
		/// <summary>
		/// Creates a new <see cref="Window"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().Window()
		///             .Name("Window")
		/// %&gt;
		/// </code>
		/// </example>
		public virtual DialogBuilder Dialog()
		{
			return new DialogBuilder(new Dialog(HtmlHelper.ViewContext));
		}
	}
}