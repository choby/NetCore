namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="RecurrenceEditor"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().RecurrenceEditor()
        ///             .Name("recurrenceEditor")
        ///             .FirstWeekDay(0)
        ///             .Timezone("Etc/UTC")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual RecurrenceEditorBuilder RecurrenceEditor()
        {
            return new RecurrenceEditorBuilder(new RecurrenceEditor(HtmlHelper.ViewContext));
        }
    }
}
