using System;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual RangeSliderBuilder<T> RangeSlider<T>() where T : struct, IComparable
        {
            return new RangeSliderBuilder<T>(new RangeSlider<T>(HtmlHelper.ViewContext));
        }

        public virtual RangeSliderBuilder<double> RangeSlider()
        {
            return new RangeSliderBuilder<double>(new RangeSlider<double>(HtmlHelper.ViewContext));
        }
    }
}