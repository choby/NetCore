using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="CheckBox"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  @(Html.Kendo().CheckBox()
        ///             .Name("CheckBox")
        /// );
        /// </code>
        /// </example>
        public virtual CheckBoxBuilder CheckBox()
        {
            return new CheckBoxBuilder(new CheckBox(HtmlHelper.ViewContext));
        }
    }
}