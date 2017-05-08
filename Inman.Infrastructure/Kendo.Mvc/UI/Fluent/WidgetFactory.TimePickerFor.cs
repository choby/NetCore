using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {

        /// <summary>
        /// Creates a new <see cref="TimePicker"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TimePickerFor(m=>m.Property) %&gt;
        /// </code>
        /// </example>
        public virtual TimePickerBuilder TimePickerFor(Expression<Func<TModel, Nullable<TimeSpan>>> expression)
        {
            var explorer = GetModelExplorer(expression);

            var widget = TimePicker()
                    .Expression(GetExpressionName(expression))
                    .Format(ExtractEditFormat(explorer.Metadata.EditFormatString))
                    .Value(explorer.Model as TimeSpan?);           

            return widget;
        }

        /// <summary>
        /// Creates a new <see cref="TimePicker"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TimePickerFor(m=>m.Property) %&gt;
        /// </code>
        /// </example>
        public virtual TimePickerBuilder TimePickerFor(Expression<Func<TModel, DateTime>> expression)
        {
            return TimePickerOfTValueFor(expression);
        }

        /// <summary>
        /// Creates a new <see cref="TimePicker"/> bound to nullable model field
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().TimePickerFor(m => m.Property))
        /// </code>
        /// </example>
        public virtual TimePickerBuilder TimePickerFor(Expression<Func<TModel, Nullable<DateTime>>> expression)
        {
            return TimePickerOfTValueFor(expression);
        }

        /// <summary>
        /// Creates a new <see cref="TimePicker"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TimePickerFor(m=>m.Property) %&gt;
        /// </code>
        /// </example>
        private TimePickerBuilder TimePickerOfTValueFor<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            var explorer = GetModelExplorer(expression);

            var widget = TimePicker()
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

        public virtual TimePickerBuilder TimePickerFor(Expression<Func<TModel, TimeSpan>> expression)
        {
            var explorer = GetModelExplorer(expression);

            var widget = TimePicker()
                    .Expression(GetExpressionName(expression))
                    .Format(ExtractEditFormat(explorer.Metadata.EditFormatString))
                    .Value(explorer.Model as TimeSpan?);

            var min = GetRangeValidationParameter<TimeSpan>(explorer, MinimumValidator);
            if (min.HasValue)
            {
                widget.Min(new DateTime(min.Value.Ticks));
            }

            var max = GetRangeValidationParameter<TimeSpan>(explorer, MaximumValidator);
            if (max.HasValue)
            {
                widget.Max(new DateTime(max.Value.Ticks));
            }

            return widget;
        }
    }
}
