using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Scheduler
    /// </summary>
    public partial class SchedulerBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The template used to render the "all day" scheduler events.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for AllDayEventTemplate</param>
        public SchedulerBuilder<T> AllDayEventTemplate(string value)
        {
            Container.AllDayEventTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the "all day" scheduler events.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for AllDayEventTemplate</param>
        public SchedulerBuilder<T> AllDayEventTemplateId(string templateId)
        {
            Container.AllDayEventTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the scheduler will display a slot for "all day" events.
        /// </summary>
        /// <param name="value">The value for AllDaySlot</param>
        public SchedulerBuilder<T> AllDaySlot(bool value)
        {
            Container.AllDaySlot = value;
            return this;
        }

        /// <summary>
        /// If set to false the widget will not bind to the data source during initialization. In this case data binding will occur when the change event of the
		/// data source is fired. By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public SchedulerBuilder<T> AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// If set to false the "current time" marker of the scheduler would not be displayed.
        /// </summary>
        /// <param name="configurator">The configurator for the currenttimemarker setting.</param>
        public SchedulerBuilder<T> CurrentTimeMarker(Action<SchedulerCurrentTimeMarkerSettingsBuilder<T>> configurator)
        {
            Container.CurrentTimeMarker.Enabled = true;

            Container.CurrentTimeMarker.Scheduler = Container;
            configurator(new SchedulerCurrentTimeMarkerSettingsBuilder<T>(Container.CurrentTimeMarker));

            return this;
        }

        /// <summary>
        /// If set to false the "current time" marker of the scheduler would not be displayed.
        /// </summary>
        /// <param name="enabled">Enables or disables the currenttimemarker option.</param>
        public SchedulerBuilder<T> CurrentTimeMarker(bool enabled)
        {
            Container.CurrentTimeMarker.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The current date of the scheduler. Used to determine the period which is displayed by the widget.
        /// </summary>
        /// <param name="value">The value for Date</param>
        public SchedulerBuilder<T> Date(DateTime value)
        {
            Container.Date = value;
            return this;
        }

        /// <summary>
        /// The template used to render the date header cells.By default the scheduler renders the date using a custom date format - "ddd M/dd".
		/// The "ddd" specifier represents the abbreviated name of the week day and will be localized using the current Kendo UI culture.
		/// If the developer wants to control the day and month order, then one needs to define a custom template.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for DateHeaderTemplate</param>
        public SchedulerBuilder<T> DateHeaderTemplate(string value)
        {
            Container.DateHeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the date header cells.By default the scheduler renders the date using a custom date format - "ddd M/dd".
		/// The "ddd" specifier represents the abbreviated name of the week day and will be localized using the current Kendo UI culture.
		/// If the developer wants to control the day and month order, then one needs to define a custom template.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for DateHeaderTemplate</param>
        public SchedulerBuilder<T> DateHeaderTemplateId(string templateId)
        {
            Container.DateHeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The end time of the week and day views. The scheduler will display events ending before the endTime.
        /// </summary>
        /// <param name="value">The value for EndTime</param>
        public SchedulerBuilder<T> EndTime(DateTime value)
        {
            Container.EndTime = value;
            return this;
        }

        /// <summary>
        /// The template used to render the scheduler events.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for EventTemplate</param>
        public SchedulerBuilder<T> EventTemplate(string value)
        {
            Container.EventTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the scheduler events.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for EventTemplate</param>
        public SchedulerBuilder<T> EventTemplateId(string templateId)
        {
            Container.EventTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to false the footer of the scheduler would not be displayed.
        /// </summary>
        /// <param name="configurator">The configurator for the footer setting.</param>
        public SchedulerBuilder<T> Footer(Action<SchedulerFooterSettingsBuilder<T>> configurator)
        {
            Container.Footer.Enabled = true;

            Container.Footer.Scheduler = Container;
            configurator(new SchedulerFooterSettingsBuilder<T>(Container.Footer));

            return this;
        }

        /// <summary>
        /// If set to false the footer of the scheduler would not be displayed.
        /// </summary>
        /// <param name="enabled">Enables or disables the footer option.</param>
        public SchedulerBuilder<T> Footer(bool enabled)
        {
            Container.Footer.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The template used to render the group headers of scheduler day, week, workWeek and timeline views.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for GroupHeaderTemplate</param>
        public SchedulerBuilder<T> GroupHeaderTemplate(string value)
        {
            Container.GroupHeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the group headers of scheduler day, week, workWeek and timeline views.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for GroupHeaderTemplate</param>
        public SchedulerBuilder<T> GroupHeaderTemplateId(string templateId)
        {
            Container.GroupHeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The height of the widget. Numeric values are treated as pixels.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public SchedulerBuilder<T> Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// The number of minutes represented by a major tick.
        /// </summary>
        /// <param name="value">The value for MajorTick</param>
        public SchedulerBuilder<T> MajorTick(int value)
        {
            Container.MajorTick = value;
            return this;
        }

        /// <summary>
        /// The template used to render the major ticks.By default the scheduler renders the time using the current culture time format.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for MajorTimeHeaderTemplate</param>
        public SchedulerBuilder<T> MajorTimeHeaderTemplate(string value)
        {
            Container.MajorTimeHeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the major ticks.By default the scheduler renders the time using the current culture time format.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for MajorTimeHeaderTemplate</param>
        public SchedulerBuilder<T> MajorTimeHeaderTemplateId(string templateId)
        {
            Container.MajorTimeHeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Constraints the maximum date which can be selected via the scheduler navigation.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public SchedulerBuilder<T> Max(DateTime value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// The configuration of the scheduler messages. Use this option to customize or localize the scheduler messages.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public SchedulerBuilder<T> Messages(Action<SchedulerMessagesSettingsBuilder<T>> configurator)
        {

            Container.Messages.Scheduler = Container;
            configurator(new SchedulerMessagesSettingsBuilder<T>(Container.Messages));

            return this;
        }

        /// <summary>
        /// Constraints the minimum date which can be selected via the scheduler navigation.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public SchedulerBuilder<T> Min(DateTime value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// The number of time slots to display per major tick.
        /// </summary>
        /// <param name="value">The value for MinorTickCount</param>
        public SchedulerBuilder<T> MinorTickCount(int value)
        {
            Container.MinorTickCount = value;
            return this;
        }

        /// <summary>
        /// The template used to render the minor ticks.By default the scheduler renders a "&amp;nbsp;".The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for MinorTimeHeaderTemplate</param>
        public SchedulerBuilder<T> MinorTimeHeaderTemplate(string value)
        {
            Container.MinorTimeHeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the minor ticks.By default the scheduler renders a "&amp;nbsp;".The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for MinorTimeHeaderTemplate</param>
        public SchedulerBuilder<T> MinorTimeHeaderTemplateId(string templateId)
        {
            Container.MinorTimeHeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Configures the Kendo UI Scheduler PDF export settings.
        /// </summary>
        /// <param name="configurator">The configurator for the pdf setting.</param>
        public SchedulerBuilder<T> Pdf(Action<SchedulerPdfSettingsBuilder<T>> configurator)
        {

            Container.Pdf.Scheduler = Container;
            configurator(new SchedulerPdfSettingsBuilder<T>(Container.Pdf));

            return this;
        }

        /// <summary>
        /// If set to true the user would be able to select scheduler cells and events. By default selection is disabled.
        /// </summary>
        /// <param name="value">The value for Selectable</param>
        public SchedulerBuilder<T> Selectable(bool value)
        {
            Container.Selectable = value;
            return this;
        }

        /// <summary>
        /// If set to true the user would be able to select scheduler cells and events. By default selection is disabled.
        /// </summary>
        public SchedulerBuilder<T> Selectable()
        {
            Container.Selectable = true;
            return this;
        }

        /// <summary>
        /// If set to true the view will be initially shown in business hours mode. By default view is displayed in full day mode.
        /// </summary>
        /// <param name="value">The value for ShowWorkHours</param>
        public SchedulerBuilder<T> ShowWorkHours(bool value)
        {
            Container.ShowWorkHours = value;
            return this;
        }

        /// <summary>
        /// If set to true the view will be initially shown in business hours mode. By default view is displayed in full day mode.
        /// </summary>
        public SchedulerBuilder<T> ShowWorkHours()
        {
            Container.ShowWorkHours = true;
            return this;
        }

        /// <summary>
        /// If set to true the scheduler will snap events to the nearest slot during dragging (resizing or moving). Set it to false to allow free moving and resizing of events.
        /// </summary>
        /// <param name="value">The value for Snap</param>
        public SchedulerBuilder<T> Snap(bool value)
        {
            Container.Snap = value;
            return this;
        }

        /// <summary>
        /// The start time of the week and day views. The scheduler will display events starting after the startTime.
        /// </summary>
        /// <param name="value">The value for StartTime</param>
        public SchedulerBuilder<T> StartTime(DateTime value)
        {
            Container.StartTime = value;
            return this;
        }

        /// <summary>
        /// The timezone which the scheduler will use to display the scheduler appointment dates. By default the current system timezone is used. This is an acceptable default when the
		/// scheduler widget is bound to local array of events. It is advisable to specify a timezone if the scheduler is bound to a remote service.
		/// That way all users would see the same dates and times no matter their configured system timezone.The complete list of the supported timezones is available in the List of IANA time zones Wikipedia page.
        /// </summary>
        /// <param name="value">The value for Timezone</param>
        public SchedulerBuilder<T> Timezone(string value)
        {
            Container.Timezone = value;
            return this;
        }

        /// <summary>
        /// The width of the widget. Numeric values are treated as pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public SchedulerBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// Sets the start of the work day when the  "Show business hours" button is clicked.
        /// </summary>
        /// <param name="value">The value for WorkDayStart</param>
        public SchedulerBuilder<T> WorkDayStart(DateTime value)
        {
            Container.WorkDayStart = value;
            return this;
        }

        /// <summary>
        /// Sets the end of the work day when the  "Show business hours" button is clicked.
        /// </summary>
        /// <param name="value">The value for WorkDayEnd</param>
        public SchedulerBuilder<T> WorkDayEnd(DateTime value)
        {
            Container.WorkDayEnd = value;
            return this;
        }

        /// <summary>
        /// The start of working week (index based).
        /// </summary>
        /// <param name="value">The value for WorkWeekStart</param>
        public SchedulerBuilder<T> WorkWeekStart(int value)
        {
            Container.WorkWeekStart = value;
            return this;
        }

        /// <summary>
        /// The end of working week (index based).
        /// </summary>
        /// <param name="value">The value for WorkWeekEnd</param>
        public SchedulerBuilder<T> WorkWeekEnd(int value)
        {
            Container.WorkWeekEnd = value;
            return this;
        }

        /// <summary>
        /// Defines the mobile modes supported by Kendo UI Scheduler for ASP.NET MVC
        /// </summary>
        /// <param name="value">The value for Mobile</param>
        public SchedulerBuilder<T> Mobile(MobileMode value)
        {
            Container.Mobile = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Scheduler()
        ///       .Name("Scheduler")
        ///       .Events(events => events
        ///           .Add("onAdd")
        ///       )
        /// )
        /// </code>
        /// </example>
        public SchedulerBuilder<T> Events(Action<SchedulerEventBuilder> configurator)
        {
            configurator(new SchedulerEventBuilder(Container.Events));
            return this;
        }
        
    }
}

