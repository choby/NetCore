namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
		/// <summary>
		/// Creates a new <see cref="DateTimePicker"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		/// @(Html.Kendo().DateTimePicker()
		///             .Name("DateTimePicker")
		/// )
		/// </code>
		/// </example>
		public virtual DateTimePickerBuilder DateTimePicker()
        {
            return new DateTimePickerBuilder(new DateTimePicker(HtmlHelper.ViewContext));
        }
    }
}