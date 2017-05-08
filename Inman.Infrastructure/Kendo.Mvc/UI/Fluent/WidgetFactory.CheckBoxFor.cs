using System;
using System.Linq.Expressions;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="CheckBox"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().CheckBoxFor(m=>m.Property) %&gt;
        /// </code>
        /// </example>
        public virtual CheckBoxBuilder CheckBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
        {
            var explorer = GetModelExplorer(expression);
            var model = explorer.Model;            
            bool checkedValue = false;

            if (model != null && model.GetType().IsPredefinedType())
            {
                checkedValue = Convert.ToBoolean(model);
            }

            return CheckBox()
                .Name(GetExpressionName(expression))
                .Checked(checkedValue);
        }
    }
}

