using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI NumericTextBox
    /// </summary>
    public partial class NumericTextBoxBuilder<T>: WidgetBuilderBase<NumericTextBox<T>, NumericTextBoxBuilder<T>>
        where T : struct 
    {
        public NumericTextBoxBuilder(NumericTextBox<T> component) : base(component)
        {
        }

        // Place custom settings here
    }
}

