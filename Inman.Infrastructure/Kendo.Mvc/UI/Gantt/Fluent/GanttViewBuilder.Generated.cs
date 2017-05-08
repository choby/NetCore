using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttView
    /// </summary>
    public partial class GanttViewBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// If set to some date and it is between the range start and range end of the selected view, the timeline of the currently selected view is scrolled to start from this date.Overrides the date option of the gantt.
        /// </summary>
        /// <param name="value">The value for Date</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> Date(DateTime value)
        {
            Container.Date = value;
            return this;
        }

        /// <summary>
        /// Configures the view range settings.
        /// </summary>
        /// <param name="configurator">The configurator for the range setting.</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> Range(Action<GanttViewRangeSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
        {

            Container.Range.Gantt = Container.Gantt;
            configurator(new GanttViewRangeSettingsBuilder<TTaskModel, TDependenciesModel>(Container.Range));

            return this;
        }

        /// <summary>
        /// If set to true the view will be initially selected by the Gantt widget. The default selected view is "day".
        /// </summary>
        /// <param name="value">The value for Selected</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> Selected(bool value)
        {
            Container.Selected = value;
            return this;
        }

        /// <summary>
        /// If set to true the view will be initially selected by the Gantt widget. The default selected view is "day".
        /// </summary>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> Selected()
        {
            Container.Selected = true;
            return this;
        }

        /// <summary>
        /// The size of the time slot headers. Values are treated as pixels.
        /// </summary>
        /// <param name="value">The value for SlotSize</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> SlotSize(double value)
        {
            Container.SlotSize = value;
            return this;
        }

        /// <summary>
        /// The template used to render the time slots in "day" view
        /// </summary>
        /// <param name="value">The value for TimeHeaderTemplate</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> TimeHeaderTemplate(string value)
        {
            Container.TimeHeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the time slots in "day" view
        /// </summary>
        /// <param name="value">The ID of the template element for TimeHeaderTemplate</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> TimeHeaderTemplateId(string templateId)
        {
            Container.TimeHeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the day slots in "day" and "week" views.
        /// </summary>
        /// <param name="value">The value for DayHeaderTemplate</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> DayHeaderTemplate(string value)
        {
            Container.DayHeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the day slots in "day" and "week" views.
        /// </summary>
        /// <param name="value">The ID of the template element for DayHeaderTemplate</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> DayHeaderTemplateId(string templateId)
        {
            Container.DayHeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the week slots in "week" and "month" views.
        /// </summary>
        /// <param name="value">The value for WeekHeaderTemplate</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> WeekHeaderTemplate(string value)
        {
            Container.WeekHeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the week slots in "week" and "month" views.
        /// </summary>
        /// <param name="value">The ID of the template element for WeekHeaderTemplate</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> WeekHeaderTemplateId(string templateId)
        {
            Container.WeekHeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the month slots in "month" and "year" views.
        /// </summary>
        /// <param name="value">The value for MonthHeaderTemplate</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> MonthHeaderTemplate(string value)
        {
            Container.MonthHeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the month slots in "month" and "year" views.
        /// </summary>
        /// <param name="value">The ID of the template element for MonthHeaderTemplate</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> MonthHeaderTemplateId(string templateId)
        {
            Container.MonthHeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template used to render the year slots in "year" view.
        /// </summary>
        /// <param name="value">The value for YearHeaderTemplate</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> YearHeaderTemplate(string value)
        {
            Container.YearHeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// The template used to render the year slots in "year" view.
        /// </summary>
        /// <param name="value">The ID of the template element for YearHeaderTemplate</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> YearHeaderTemplateId(string templateId)
        {
            Container.YearHeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The format used to display the start and end dates in the resize tooltip.
        /// </summary>
        /// <param name="value">The value for ResizeTooltipFormat</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> ResizeTooltipFormat(string value)
        {
            Container.ResizeTooltipFormat = value;
            return this;
        }

        /// <summary>
        /// The view type. Supported types are "day", "week", "month" and "year".
        /// </summary>
        /// <param name="value">The value for Type</param>
        public GanttViewBuilder<TTaskModel, TDependenciesModel> Type(GanttViewType value)
        {
            Container.Type = value;
            return this;
        }

    }
}
