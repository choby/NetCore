using System;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a <see cref="Editor"/>
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Editor()
        ///             .Name("Editor")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual EditorBuilder Editor()
        {
            return new EditorBuilder(new Editor(HtmlHelper.ViewContext));
        }
    }
}