namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="TextBox"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TextBox()
        ///             .Name("TextBox")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual TextBoxBuilder<string> TextBox()
        {
            return new TextBoxBuilder<string>(new TextBox<string>(HtmlHelper.ViewContext));
        }

        /// <summary>
        /// Creates a new <see cref="TextBox{T}"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TextBox&lt;double&gt;()
        ///             .Name("TextBox")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual TextBoxBuilder<T> TextBox<T>()
        {
            return new TextBoxBuilder<T>(new TextBox<T>(HtmlHelper.ViewContext));
        }
    }
}
