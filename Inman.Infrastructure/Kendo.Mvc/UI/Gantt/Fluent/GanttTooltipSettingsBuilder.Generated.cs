using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttTooltipSettings
    /// </summary>
    public partial class GanttTooltipSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// The template which renders the tooltip.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public GanttTooltipSettingsBuilder<TTaskModel, TDependenciesModel> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the tooltip.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public GanttTooltipSettingsBuilder<TTaskModel, TDependenciesModel> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to false the gantt will not display the task tooltip. By default the task tooltip is displayed.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public GanttTooltipSettingsBuilder<TTaskModel, TDependenciesModel> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

    }
}
