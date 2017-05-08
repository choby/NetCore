using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisNotesLabelSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the label. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the label.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Border(Action<StockChartNavigatorCategoryAxisNotesLabelBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisNotesLabelBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the label. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font style of the label.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category notes label. By default the category notes label are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The rotation angle of the label. By default the label are not rotated.
        /// </summary>
        /// <param name="value">The value for Rotation</param>
        public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Rotation(double value)
        {
            Container.Rotation = value;
            return this;
        }

        /// <summary>
        /// The format used to display the notes label. Uses kendo.format. Contains one placeholder ("{0}") which represents the category value.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The position of the labels.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T> Position(string value)
        {
            Container.Position = value;
            return this;
        }

    }
}
