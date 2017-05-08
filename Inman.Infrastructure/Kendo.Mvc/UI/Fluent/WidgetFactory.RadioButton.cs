using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="RadioButton"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().RadioButton()
        ///             .Name("RadioButton")
        /// );
        /// </code>
        /// </example>
        public virtual RadioButtonBuilder RadioButton()
        {
            return new RadioButtonBuilder(new RadioButton(HtmlHelper.ViewContext));
        }
    }
}