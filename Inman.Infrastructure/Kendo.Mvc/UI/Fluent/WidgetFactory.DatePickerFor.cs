using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="DatePicker"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePickerFor(m=>m.Property) %&gt;
        /// </code>
        /// </example>
        public virtual DatePickerBuilder DatePickerFor(Expression<Func<TModel, DateTime>> expression)
        {
            return DatePickerOfTValueFor(expression);
        }

        /// <summary>
        /// Creates a new <see cref="DateTimePicker"/> bound to nullable model field
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().DateTimePickerFor(m => m.Property))
        /// </code>
        /// </example>
        public virtual DatePickerBuilder DatePickerFor(Expression<Func<TModel, Nullable<DateTime>>> expression)
        {
            return DatePickerOfTValueFor(expression);
        }

        private DatePickerBuilder DatePickerOfTValueFor<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            var explorer = GetModelExplorer(expression);

            var widget = DatePicker()
                    .Expression(GetExpressionName(expression))
                    .Format(ExtractEditFormat(explorer.Metadata.EditFormatString))
                    .Value(explorer.Model as DateTime?);

            var min = GetRangeValidationParameter<DateTime>(explorer, MinimumValidator);
            if (min.HasValue)
            {
                widget.Min(min.Value);
            }

            var max = GetRangeValidationParameter<DateTime>(explorer, MaximumValidator);
            if (max.HasValue)
            {
                widget.Max(max.Value);
            }

            return widget;
        }

    }
}
