using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisNotesLabelSettings
    /// </summary>
    public partial class ChartXAxisNotesLabelSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the label. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartXAxisNotesLabelSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the label.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartXAxisNotesLabelSettingsBuilder<T> Border(Action<ChartXAxisNotesLabelBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartXAxisNotesLabelBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the label. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartXAxisNotesLabelSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font style of the label.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartXAxisNotesLabelSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ChartXAxisNotesLabelSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ChartXAxisNotesLabelSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the x axis notes label. By default the x axis notes label are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartXAxisNotesLabelSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The rotation angle of the label. By default the label are not rotated.
        /// </summary>
        /// <param name="value">The value for Rotation</param>
        public ChartXAxisNotesLabelSettingsBuilder<T> Rotation(double value)
        {
            Container.Rotation = value;
            return this;
        }

        /// <summary>
        /// The format used to display the notes label. Uses kendo.format. Contains one placeholder ("{0}") which represents the axis value.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public ChartXAxisNotesLabelSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The position of the labels.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartXAxisNotesLabelSettingsBuilder<T> Position(ChartNoteLabelPosition value)
        {
            Container.Position = value;
            return this;
        }

    }
}
