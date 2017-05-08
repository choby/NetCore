using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI FlatColorPicker
    /// </summary>
    public partial class FlatColorPickerBuilder: WidgetBuilderBase<FlatColorPicker, FlatColorPickerBuilder>
        
    {
        public FlatColorPickerBuilder(FlatColorPicker component) : base(component)
        {
        }

		/// <summary>
		/// Indicates whether the picker will show an input for entering colors.
		/// </summary>
		/// <param name="showInput">Whether the input field should be shown.</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().FlatColorPicker()
		///             .Name("FlatColorPicker")
		///             .Input(false)
		/// %&gt;
		/// </code>
		/// </example>
		public FlatColorPickerBuilder Input(bool showInput)
		{
			Component.Input = showInput;

			return this;
		}
	}
}

