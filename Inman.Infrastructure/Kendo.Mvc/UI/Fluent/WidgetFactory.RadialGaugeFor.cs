using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual RadialGaugeBuilder RadialGaugeFor<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            var metadata = GetModelExplorer(expression);

            var widget = RadialGauge()
                         .Expression(GetExpressionName(expression))
                         .Pointer(pointer => pointer.Value(
                            Convert.ToDouble(metadata.Model)
                         ));

            return widget;
        }

        public virtual RadialGaugeBuilder RadialGaugeFor<TValue>(Expression<Func<TModel, Nullable<TValue>>> expression)
                    where TValue : struct, IComparable
        {
            var metadata = GetModelExplorer(expression);

            var widget = RadialGauge()
                         .Expression(GetExpressionName(expression))
                         .Pointer(pointer => pointer.Value(
                            Convert.ToDouble(metadata.Model)
                         ));

            return widget;
        }
    }
}