using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesNotesLabelSettings
    /// </summary>
    public partial class ChartSeriesNotesLabelSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the label. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartSeriesNotesLabelSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the label.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartSeriesNotesLabelSettingsBuilder<T> Border(Action<ChartSeriesNotesLabelBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartSeriesNotesLabelBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the label. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesNotesLabelSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font style of the label.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartSeriesNotesLabelSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ChartSeriesNotesLabelSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ChartSeriesNotesLabelSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the series notes label. By default the series notes label are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartSeriesNotesLabelSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The rotation angle of the label. By default the label are not rotated.
        /// </summary>
        /// <param name="value">The value for Rotation</param>
        public ChartSeriesNotesLabelSettingsBuilder<T> Rotation(double value)
        {
            Container.Rotation = value;
            return this;
        }

        /// <summary>
        /// The format used to display the notes label. Uses kendo.format. Contains one placeholder ("{0}") which represents the axis value.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public ChartSeriesNotesLabelSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// Specifies the position of the labels.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartSeriesNotesLabelSettingsBuilder<T> Position(ChartNoteLabelPosition value)
        {
            Container.Position = value;
            return this;
        }

    }
}
