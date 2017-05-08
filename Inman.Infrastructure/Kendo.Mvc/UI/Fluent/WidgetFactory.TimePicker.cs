namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="TimePicker"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TimePicker()
        ///             .Name("TimePicker")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual TimePickerBuilder TimePicker()
        {
            return new TimePickerBuilder(new TimePicker(HtmlHelper.ViewContext));
        }
    }
}