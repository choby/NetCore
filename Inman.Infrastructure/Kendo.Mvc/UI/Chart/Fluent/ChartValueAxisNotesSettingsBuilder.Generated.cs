using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisNotesSettings
    /// </summary>
    public partial class ChartValueAxisNotesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The position of the value axis note.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartValueAxisNotesSettingsBuilder<T> Position(ChartNotePosition value)
        {
            Container.Position = value;
            return this;
        }

        /// <summary>
        /// The icon of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the icon setting.</param>
        public ChartValueAxisNotesSettingsBuilder<T> Icon(Action<ChartValueAxisNotesIconSettingsBuilder<T>> configurator)
        {

            Container.Icon.Chart = Container.Chart;
            configurator(new ChartValueAxisNotesIconSettingsBuilder<T>(Container.Icon));

            return this;
        }

        /// <summary>
        /// The label of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the label setting.</param>
        public ChartValueAxisNotesSettingsBuilder<T> Label(Action<ChartValueAxisNotesLabelSettingsBuilder<T>> configurator)
        {

            Container.Label.Chart = Container.Chart;
            configurator(new ChartValueAxisNotesLabelSettingsBuilder<T>(Container.Label));

            return this;
        }

        /// <summary>
        /// The line of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public ChartValueAxisNotesSettingsBuilder<T> Line(Action<ChartValueAxisNotesLineSettingsBuilder<T>> configurator)
        {

            Container.Line.Chart = Container.Chart;
            configurator(new ChartValueAxisNotesLineSettingsBuilder<T>(Container.Line));

            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the notes. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartValueAxisNotesSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the notes. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartValueAxisNotesSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
