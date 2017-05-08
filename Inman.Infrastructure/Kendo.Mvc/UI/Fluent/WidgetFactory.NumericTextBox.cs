namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
		/// <summary>
		/// Creates a new <see cref="NumericTextBox"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///	 @(Html.Kendo().NumericTextBox()
		///		.Name("NumericTextBox")
		///	 )
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<double> NumericTextBox()
		{
			return new NumericTextBoxBuilder<double>(new NumericTextBox<double>(HtmlHelper.ViewContext));
		}

		/// <summary>
		/// Creates a new <see cref="NumericTextBox{T}"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().NumericTextBox&lt;double&gt;()
		///		.Name("NumericTextBox")
		///  )
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<T> NumericTextBox<T>() where T : struct
		{
			return new NumericTextBoxBuilder<T>(new NumericTextBox<T>(HtmlHelper.ViewContext));
		}

		/// <summary>
		/// Creates a new <see cref="CurrencyTextBox"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().CurrencyTextBox()
		///     .Name("CurrencyTextBox")
		///  )
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<decimal> CurrencyTextBox()
		{
			return NumericTextBox<decimal>().Format("c");
		}

		/// <summary>
		/// Creates a new <see cref="PercentTextBox"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().PercentTextBox()
		///     .Name("PercentTextBox")
		///  )
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<double> PercentTextBox()
		{
			return NumericTextBox().Format("p");
		}

		/// <summary>
		/// Creates a new <see cref="IntegerTextBox"/>.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().IntegerTextBox()
		///     .Name("IntegerTextBox")
		///  )
		/// </code>
		/// </example>
		public virtual NumericTextBoxBuilder<int> IntegerTextBox()
		{
			return NumericTextBox<int>().Format("n0").Decimals(0);
		}
	}
}