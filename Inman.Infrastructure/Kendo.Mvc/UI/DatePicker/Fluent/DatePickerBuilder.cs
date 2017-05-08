using System;
using System.Collections.Generic;
using System.ComponentModel;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI DatePicker
    /// </summary>
    public partial class DatePickerBuilder: WidgetBuilderBase<DatePicker, DatePickerBuilder>
        
    {
        public DatePickerBuilder(DatePicker component) : base(component)
        {
        }

        /// <summary>
		/// Use to enable or disable animation of the popup element.
		/// </summary>
		/// <param name="enable">The boolean value.</param>
		/// <example>
		/// <code lang="CS">
		/// @(Html.Kendo().DatePicker()
		///	           .Name("DatePicker")
		///	           .Animation(false) //toggle effect
		///	)
		/// </code>
		/// </example>
		public DatePickerBuilder Animation(bool enable)
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
		/// @(Html.Kendo().DatePicker()
		///	           .Name("DatePicker")
		///	           .Animation(animation =>
		///	           {
		///		            animation.Open(open =>
		///		            {
		///		                open.SlideIn(SlideDirection.Down);
		///		            })
		///	           })
		///	)
		/// </code>
		/// </example>
		public DatePickerBuilder Animation(Action<PopupAnimationBuilder> animationAction)
        {

            animationAction(new PopupAnimationBuilder(Component.Animation));

            return this;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public DatePickerBuilder DisableDates(IEnumerable<string> disableDates)
        {
            Component.DisableDates = disableDates;

            return this;
        }

        /// <summary>
        /// Specifies the disabled dates in the DatePicker widget.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().DatePicker()
        ///             .Name("datePicker")
        ///             .DisableDates(DayofWeek.Saturday, DayOfWeek.Sunday)
        /// )
        /// </code>
        /// </example>
        public DatePickerBuilder DisableDates(params DayOfWeek[] days)
        {
            Component.DisableDates = days.ToAbbrev();

            return this;
        }

        /// <summary>
        /// Specifies the disabled dates in the DatePicker widget using a function.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @( Html.Kendo().DatePicker()
        ///             .Name("datePicker")
        ///             .DisableDates("disableDates")
        /// )
        /// </code>
        /// </example>
        public DatePickerBuilder DisableDates(string handler)
        {
            var handlerDescription = new ClientHandlerDescriptor { HandlerName = handler };
            Component.DisableDatesHandler = handlerDescription;

            return this;
        }

        /// <summary>
        /// Enables or disables the picker.
        /// </summary>
        public DatePickerBuilder Enable(bool value)
        {
            Component.Enabled = value;

            return this as DatePickerBuilder;
        }

        /// <summary>
        /// Sets the value of the picker input
        /// </summary>
        public DatePickerBuilder Value(string date)
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

            return this as DatePickerBuilder;
        }

        /// <summary>
        /// Sets the value of the picker input
        /// </summary>
        public DatePickerBuilder Value(DateTime? date)
        {
            Component.Value = date;

            return this as DatePickerBuilder;
        }
       
        /// <summary>
        /// Specifies a list of dates, which will be passed to the month template.
        /// </summary>
        /// <param name="dates">The dates.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .BindTo(new List<DateTime>
        ///             {
        ///                 DateTime.Now
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder BindTo(List<DateTime> dates)
        {
            Component.Dates = dates.ToArray();

            return this;
        }

        /// <summary>
        /// FooterId to be used for rendering the footer of the Calendar.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .FooterId("widgetFooterId")
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder FooterId(string id)
        {
            Component.FooterId = id;

            return this;
        }       

        /// <summary>
        /// Enables/disables footer of the calendar popup.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .Footer(false)
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder Footer(bool footer)
        {
            Component.EnableFooter = footer;

            return this;
        }

        /// <summary>
        /// MonthTemplateId to be used for rendering the cells of the Calendar.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .MonthTemplateId("widgetMonthTemplateId")
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder MonthTemplateId(string id)
        {
            Component.MonthTemplate.ContentId = id;

            return this;
        }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .MonthTemplate("#= data.value #")
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder MonthTemplate(string content)
        {
            Component.MonthTemplate.Content = content;

            return this;
        }

        /// <summary>
        /// Sets the minimal date, which can be selected in DatePicker.
        /// </summary>
        public DatePickerBuilder Min(string date)
        {

            DateTime parsedDate;

            if (DateTime.TryParse(date, out parsedDate))
            {
                Component.Min = parsedDate;
            }
            else
            {
                throw new ArgumentException(Exceptions.StringNotCorrectDate);
            }
            return this;
        }

        /// <summary>
        /// Sets the maximal date, which can be selected in DatePicker.
        /// </summary>
        public DatePickerBuilder Max(string date)
        {

            DateTime parsedDate;

            if (DateTime.TryParse(date, out parsedDate))
            {
                Component.Max = parsedDate;
            }
            else
            {
                throw new ArgumentException(Exceptions.StringNotCorrectDate);
            }
            return this;
        }
    }
}

