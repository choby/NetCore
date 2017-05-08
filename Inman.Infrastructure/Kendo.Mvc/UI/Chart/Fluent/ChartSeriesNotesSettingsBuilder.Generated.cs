using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesNotesSettings
    /// </summary>
    public partial class ChartSeriesNotesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The icon of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the icon setting.</param>
        public ChartSeriesNotesSettingsBuilder<T> Icon(Action<ChartSeriesNotesIconSettingsBuilder<T>> configurator)
        {

            Container.Icon.Chart = Container.Chart;
            configurator(new ChartSeriesNotesIconSettingsBuilder<T>(Container.Icon));

            return this;
        }

        /// <summary>
        /// The label of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the label setting.</param>
        public ChartSeriesNotesSettingsBuilder<T> Label(Action<ChartSeriesNotesLabelSettingsBuilder<T>> configurator)
        {

            Container.Label.Chart = Container.Chart;
            configurator(new ChartSeriesNotesLabelSettingsBuilder<T>(Container.Label));

            return this;
        }

        /// <summary>
        /// The line of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public ChartSeriesNotesSettingsBuilder<T> Line(Action<ChartSeriesNotesLineSettingsBuilder<T>> configurator)
        {

            Container.Line.Chart = Container.Chart;
            configurator(new ChartSeriesNotesLineSettingsBuilder<T>(Container.Line));

            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the notes. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesNotesSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the notes. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesNotesSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// Specifies the position of the note.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartSeriesNotesSettingsBuilder<T> Position(ChartNotePosition value)
        {
            Container.Position = value;
            return this;
        }

    }
}
