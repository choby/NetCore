using System;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI RangeSlider
    /// </summary>
    public partial class RangeSliderBuilder<T>: WidgetBuilderBase<RangeSlider<T>, RangeSliderBuilder<T>>
        where T : struct, IComparable 
    {
        public RangeSliderBuilder(RangeSlider<T> component) : base(component)
        {
        }

        /// <summary>Sets the value of the range slider.</summary>
        public RangeSliderBuilder<T> Values(T? selectionStart, T? selectionEnd)
        {
            if (selectionStart.HasValue)
            {
                Component.SelectionStart = selectionStart.Value;
            }

            if (selectionEnd.HasValue)
            {
                Component.SelectionEnd = selectionEnd.Value;
            }

            return this;
        }


        /// <summary>Sets the value of the range slider.</summary>
        public RangeSliderBuilder<T> Values(T[] range)
        {
            if (range == null)
            {
                return this;
            }

            if (range.Count() >= 1)
            {
                Component.SelectionStart = range.First();
            }

            if (range.Count() > 1)
            {
                Component.SelectionEnd = range[1];
            }

            return this;
        }

        public RangeSliderBuilder<T> Tooltip(bool value)
        {
            Container.Tooltip.RangeSlider = Container;
            Container.Tooltip.Enabled = value;

            return this;
        }
    }
}

