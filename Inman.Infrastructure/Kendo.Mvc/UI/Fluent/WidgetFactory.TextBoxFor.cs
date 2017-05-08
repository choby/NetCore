using System;
using System.Linq.Expressions;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="TextBox"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TextBoxFor(m=>m.Property) %&gt;
        /// </code>
        /// </example>
        public virtual TextBoxBuilder<TProperty> TextBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
        {
            var explorer = GetModelExplorer(expression);

            return TextBox<TProperty>()
                    .Expression(GetExpressionName(expression))
                    .Value((TProperty)explorer.Model);
        }
    }
}
