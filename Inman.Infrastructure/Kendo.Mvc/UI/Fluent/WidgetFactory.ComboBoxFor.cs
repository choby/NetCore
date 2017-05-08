using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="ComboBox"/> bound to a model field.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @Html.Kendo().ComboBoxFor(m => m.Property)
        /// </code>
        /// </example>
        public virtual ComboBoxBuilder ComboBoxFor<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            var explorer = GetModelExplorer(expression);
            var model = explorer.Model;

            var widget = ComboBox()
                    .Expression(GetExpressionName(expression))
                    .Value(GetValueWithEnum(expression));

            return widget;
        }
    }
}