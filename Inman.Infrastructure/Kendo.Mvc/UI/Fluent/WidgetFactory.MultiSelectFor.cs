using Kendo.Mvc.Extensions;
using System;
using System.Collections;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="MultiSelect"/> bound to a model field.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @Html.Kendo().MultiSelectFor(m => m.Property)
        /// </code>
        /// </example>
        public virtual MultiSelectBuilder MultiSelectFor<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            var explorer = GetModelExplorer(expression);
            var model = explorer.Model;

            var widget = MultiSelect()
                    .Expression(GetExpressionName(expression))
                    .Value(model as IEnumerable);

            return widget;
        }
    }
}