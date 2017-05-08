namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
		/// <summary>
		/// Creates a new <see cref="MaskedTextBox"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().MaskedTextBox()
		///             .Name("MaskedTextBox")
		/// %&gt;
		/// </code>
		/// </example>
		public virtual MaskedTextBoxBuilder MaskedTextBox()
		{
			return new MaskedTextBoxBuilder(new MaskedTextBox(HtmlHelper.ViewContext));
		}
	}
}