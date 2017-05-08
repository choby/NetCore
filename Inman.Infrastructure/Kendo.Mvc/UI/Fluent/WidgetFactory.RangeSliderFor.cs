using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual RangeSliderBuilder<TValue> RangeSliderFor<TValue>(Expression<Func<TModel, TValue[]>> expression)
            where TValue : struct, IComparable
        {
            var explorer = GetModelExplorer(expression);

            TValue? minimum = GetRangeValidationParameter<TValue>(explorer, MinimumValidator);
            TValue? maximum = GetRangeValidationParameter<TValue>(explorer, MaximumValidator);

            var rangeSlider = RangeSlider<TValue>()
                                .Expression(GetExpressionName(expression))
                                .Values((TValue[])explorer.Model);

            if (minimum.HasValue)
            {
                rangeSlider.Min(minimum.Value);
            }

            if (maximum.HasValue)
            {
                rangeSlider.Max(maximum.Value);
            }

            return rangeSlider;
        }

        public virtual RangeSliderBuilder<double> RangeSliderFor(Expression<Func<TModel, double[]>> expression)
        {
            return RangeSliderFor<double>(expression);
        }
    }
}