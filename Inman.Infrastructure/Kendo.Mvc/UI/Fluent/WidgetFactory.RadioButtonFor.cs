using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="RadioButton"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().RadioButtonFor(m => m.Property));
        /// </code>
        /// </example>
        public virtual RadioButtonBuilder RadioButtonFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
        {
            return RadioButton()
                .Name(GetExpressionName(expression));
        }
    }
}