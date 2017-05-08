using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="DropDownList"/> bound to a model field.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @Html.Kendo().DropDownListFor(m => m.Property)
        /// </code>
        /// </example>
        public virtual DropDownListBuilder DropDownListFor<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            var explorer = GetModelExplorer(expression);
            var model = explorer.Model;

            var widget = DropDownList()
                    .Expression(GetExpressionName(expression))
                    .Value(GetValueWithEnum(expression));

            return widget;
        }
    }
}