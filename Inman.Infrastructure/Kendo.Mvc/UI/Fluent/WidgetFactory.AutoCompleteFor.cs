using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="AutoComplete"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().AutoCompleteFor(m=>m.Property) %&gt;
        /// </code>
        /// </example>
        public virtual AutoCompleteBuilder AutoCompleteFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
        {
            var explorer = GetModelExplorer(expression);
            var model = explorer.Model;

            var widget = AutoComplete()
                    .Expression(GetExpressionName(expression))
                    .Value(GetValue(expression));

            return widget;
        }
    }
}