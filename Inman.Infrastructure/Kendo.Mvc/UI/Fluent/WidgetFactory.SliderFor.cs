using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual SliderBuilder<TValue> SliderFor<TValue>(Expression<Func<TModel, TValue>> expression)
            where TValue : struct, IComparable
        {
            var explorer = GetModelExplorer(expression);

            TValue? minimum = GetRangeValidationParameter<TValue>(explorer, MinimumValidator);
            TValue? maximum = GetRangeValidationParameter<TValue>(explorer, MaximumValidator);

            var slider = Slider<TValue>()
                            .Expression(GetExpressionName(expression))
                            .Value((TValue?)explorer.Model);

            if (minimum.HasValue)
            {
                slider.Min(minimum.Value);
            }

            if (maximum.HasValue)
            {
                slider.Max(maximum.Value);
            }

            return slider;
        }

        public virtual SliderBuilder<TValue> SliderFor<TValue>(Expression<Func<TModel, Nullable<TValue>>> expression)
            where TValue : struct, IComparable
        {
            var explorer = GetModelExplorer(expression);

            TValue? minimum = GetRangeValidationParameter<TValue>(explorer, MinimumValidator);
            TValue? maximum = GetRangeValidationParameter<TValue>(explorer, MaximumValidator);

            var slider = Slider<TValue>()
                            .Expression(GetExpressionName(expression))
                            .Value((TValue?)explorer.Model);

            if (minimum.HasValue)
            {
                slider.Min(minimum.Value);
            }

            if (maximum.HasValue)
            {
                slider.Max(maximum.Value);
            }

            return slider;
        }

        public virtual SliderBuilder<double> SliderFor(Expression<Func<TModel, double>> expression)
        {
            return SliderFor<double>(expression);
        }

        public virtual SliderBuilder<double> SliderFor(Expression<Func<TModel, Nullable<double>>> expression)
        {
            return SliderFor<double>(expression);
        }
    }
}