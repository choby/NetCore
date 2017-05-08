using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
	public partial class WidgetFactory<TModel>
	{
		/// <summary>
		/// Creates a new <see cref="ColorPicker"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().ColorPickerFor(m=>m.Property) %&gt;
		/// </code>
		/// </example>
		public virtual ColorPickerBuilder ColorPickerFor(Expression<Func<TModel, String>> expression)
		{
			var metadata = GetModelExplorer(expression);
			//var rules = HtmlHelper.GetClientValidationRules(metadata, expression.Name);

			var widget = ColorPicker()
				.Expression(GetExpressionName(expression))
				.Value(metadata.Model as String);

			return widget;
		}
	}
}