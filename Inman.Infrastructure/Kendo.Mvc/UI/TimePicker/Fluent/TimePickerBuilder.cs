using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI TimePicker
    /// </summary>
    public partial class TimePickerBuilder: WidgetBuilderBase<TimePicker, TimePickerBuilder>
        
    {
        public TimePickerBuilder(TimePicker component) : base(component)
        {
        }

        /// <summary>
        /// Use to enable or disable animation of the popup element.
        /// </summary>
        /// <param name="enable">The boolean value.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().DatePicker()
        ///	           .Name("DatePicker")
        ///	           .Animation(false) //toggle effect
        ///	%&gt;
        /// </code>
        /// </example>
        public TimePickerBuilder Animation(bool enable)
        {
            Component.Animation.Enabled = enable;

            return this;
        }

        /// <summary>
        /// Configures the animation effects of the widget.
        /// </summary>
        /// <param name="animationAction">The action which configures the animation effects.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().DatePicker()
        ///	           .Name("DatePicker")
        ///	           .Animation(animation =>
        ///	           {
        ///		            animation.Open(open =>
        ///		            {
        ///		                open.SlideIn(SlideDirection.Down);
        ///		            })
        ///	           })
        ///	%&gt;
        /// </code>
        /// </example>
        public TimePickerBuilder Animation(Action<PopupAnimationBuilder> animationAction)
        {

            animationAction(new PopupAnimationBuilder(Component.Animation));

            return this as TimePickerBuilder;
        }

        /// <summary>
        /// Enables or disables the picker.
        /// </summary>
        public TimePickerBuilder Enable(bool value)
        {
            Component.Enabled = value;

            return this;
        }

        /// <summary>
        /// Sets the value of the picker input
        /// </summary>
        public TimePickerBuilder Value(DateTime? date)
        {
            Component.Value = date;

            return this;
        }

        /// <summary>
        /// Sets the value of the picker input
        /// </summary>
        public TimePickerBuilder Value(string date)
        {
            DateTime result;

            if (DateTime.TryParse(date, out result))
            {
                Component.Value = result;
            }
            else
            {
                Component.Value = null;
            }

            return this;
        }

        /// <summary>
        /// Sets the value of the timepicker input
        /// </summary>
        public TimePickerBuilder Value(TimeSpan? time)
        {
            if (time.HasValue)
            {
                Component.Value = new DateTime(time.Value.Ticks);
            }
            else
            {
                Component.Value = null;
            }

            return this;
        }

        /// <summary>
        /// Sets the minimum time, which can be selected in timepicker
        /// </summary>
        public TimePickerBuilder Min(TimeSpan value)
        {
            Component.Min = new DateTime(value.Ticks);

            return this;
        }

        /// <summary>
        /// Sets the minimum time, which can be selected in timepicker
        /// </summary>
        public TimePickerBuilder Min(string value)
        {

            Component.Min = DateTime.Parse(value);

            return this;
        }

        /// <summary>
        /// Sets the maximum time, which can be selected in timepicker
        /// </summary>
        public TimePickerBuilder Max(TimeSpan value)
        {
            Component.Max = new DateTime(value.Ticks);

            return this;
        }

        /// <summary>
        /// Sets the maximum time, which can be selected in timepicker
        /// </summary>
        public TimePickerBuilder Max(string value)
        {

            Component.Max = DateTime.Parse(value);

            return this;
        }

        /// <summary>
        /// Binds the TimePicker to a list of DateTime objects.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TimePicker()
        ///             .Name("TimePicker")
        ///             .BindTo(new List<DateTime>
        ///             {
        ///                 DateTime.Now
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public TimePickerBuilder BindTo(IList<DateTime> dates)
        {
            Component.Dates = dates.ToArray();
            return this;
        }
    }
}

