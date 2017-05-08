using System;
using System.Linq.Expressions;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {		
		public virtual MaskedTextBoxBuilder MaskedTextBoxFor<TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			var metadata = GetModelExplorer(expression);
			var model = metadata.Model;

            return MaskedTextBox()
                    .Expression(GetExpressionName(expression))
                    .Value(GetValue(expression));
		}
	}
}