using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
		/// <summary>
		/// Creates a new <see cref="NumericTextBox{TValue}"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().NumericTextBoxFor(m=>m.Property))
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<TValue> NumericTextBoxFor<TValue>(Expression<Func<TModel, Nullable<TValue>>> expression)
			where TValue : struct
		{
            var explorer = GetModelExplorer(expression);

			var widget = NumericTextBox<TValue>()
					.Expression(GetExpressionName(expression))
					.Format(ExtractEditFormat(explorer.Metadata.EditFormatString))
					.Value((TValue?)explorer.Model);

            var min = GetRangeValidationParameter<TValue>(explorer, MinimumValidator);
            if (min.HasValue)
            {
                widget.Min(min.Value);
            }

            var max = GetRangeValidationParameter<TValue>(explorer, MaximumValidator);
            if (max.HasValue)
            {
                widget.Max(max.Value);
            }

            return widget;
		}

		/// <summary>
		/// Creates a new <see cref="NumericTextBox{T}"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().NumericTextBoxFor(m=>m.NullableProperty))
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<TValue> NumericTextBoxFor<TValue>(Expression<Func<TModel, TValue>> expression)
			where TValue : struct
		{
			var explorer = GetModelExplorer(expression);

            var widget = NumericTextBox<TValue>()
					.Expression(GetExpressionName(expression))
					.Format(ExtractEditFormat(explorer.Metadata.EditFormatString))
					.Value((TValue?)explorer.Model);

            var min = GetRangeValidationParameter<TValue>(explorer, MinimumValidator);
            if (min.HasValue)
            {
                widget.Min(min.Value);
            }

            var max = GetRangeValidationParameter<TValue>(explorer, MaximumValidator);
            if (max.HasValue)
            {
                widget.Max(max.Value);
            }

            return widget;
		}

		/// <summary>
		/// Creates a new <see cref="NumericTextBox{T}"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().IntegerTextBoxFor(m=>m.Property))
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<int> IntegerTextBoxFor(Expression<Func<TModel, Nullable<int>>> expression)
		{
			return NumericTextBoxFor<int>(expression).Format("n0").Decimals(0);
		}

		/// <summary>
		/// Creates a new <see cref="NumericTextBox{T}"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().IntegerTextBoxFor(m=>m.Property))
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<short> IntegerTextBoxFor(Expression<Func<TModel, Nullable<short>>> expression)
		{
			return NumericTextBoxFor<short>(expression).Format("n0").Decimals(0);
		}

		/// <summary>
		/// Creates a new <see cref="NumericTextBox{T}"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().IntegerTextBoxFor(m=>m.Property))
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<long> IntegerTextBoxFor(Expression<Func<TModel, Nullable<long>>> expression)
		{
			return NumericTextBoxFor<long>(expression).Format("n0").Decimals(0);
		}

		/// <summary>
		/// Creates a new <see cref="NumericTextBox{T}"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().IntegerTextBoxFor(m=>m.Property))
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<int> IntegerTextBoxFor(Expression<Func<TModel, int>> expression)
		{
			return NumericTextBoxFor<int>(expression).Format("n0").Decimals(0);
		}

		/// <summary>
		/// Creates a new <see cref="NumericTextBox{T}"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().CurrencyTextBoxFor(m=>m.Property))
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<decimal> CurrencyTextBoxFor(Expression<Func<TModel, Nullable<decimal>>> expression)
		{
			return NumericTextBoxFor<decimal>(expression).Format("c");
		}

		/// <summary>
		/// Creates a new <see cref="NumericTextBox{T}"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().CurrencyTextBoxFor(m=>m.Property))
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<decimal> CurrencyTextBoxFor(Expression<Func<TModel, decimal>> expression)
		{
			return NumericTextBoxFor<decimal>(expression).Format("c");
		}

		/// <summary>
		/// Creates a new <see cref="NumericTextBox{T}"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().PercentTextBoxFor(m=>m.Property))
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<double> PercentTextBoxFor(Expression<Func<TModel, Nullable<double>>> expression)
		{
			return NumericTextBoxFor<double>(expression).Format("p");
		}

		/// <summary>
		/// Creates a new <see cref="NumericTextBox{T}"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().PercentTextBoxFor(m=>m.Property))
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<double> PercentTextBoxFor(Expression<Func<TModel, double>> expression)
		{
			return NumericTextBoxFor<double>(expression).Format("p");
		}
	}
}