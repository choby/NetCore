using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="Editor" /> UI component.
        /// </summary>
        public virtual EditorBuilder EditorFor(Expression<Func<TModel, string>> expression)
        {
            var metadata = GetModelExplorer(expression);

            return Editor()
                    .Expression(GetExpressionName(expression))
                    .Value((string)metadata.Model);
        }
    }
}