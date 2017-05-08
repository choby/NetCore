using Kendo.Mvc.Extensions;
using System;
using System.Collections;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="RecurrenceEditor"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().RecurrenceEditorFor(m=>m.Property) %&gt;
        /// </code>
        /// </example>
        public virtual RecurrenceEditorBuilder RecurrenceEditorFor<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            var explorer = GetModelExplorer(expression);
            var model = explorer.Model;

            var widget = RecurrenceEditor()
                    .Expression(GetExpressionName(expression))
                    .Value(GetValue(expression));

            return widget;
        }
    }
}
