using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisNotesSettings
    /// </summary>
    public partial class ChartXAxisNotesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The position of the x axis note.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartXAxisNotesSettingsBuilder<T> Position(ChartNotePosition value)
        {
            Container.Position = value;
            return this;
        }

        /// <summary>
        /// The icon of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the icon setting.</param>
        public ChartXAxisNotesSettingsBuilder<T> Icon(Action<ChartXAxisNotesIconSettingsBuilder<T>> configurator)
        {

            Container.Icon.Chart = Container.Chart;
            configurator(new ChartXAxisNotesIconSettingsBuilder<T>(Container.Icon));

            return this;
        }

        /// <summary>
        /// The label of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the label setting.</param>
        public ChartXAxisNotesSettingsBuilder<T> Label(Action<ChartXAxisNotesLabelSettingsBuilder<T>> configurator)
        {

            Container.Label.Chart = Container.Chart;
            configurator(new ChartXAxisNotesLabelSettingsBuilder<T>(Container.Label));

            return this;
        }

        /// <summary>
        /// The line of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public ChartXAxisNotesSettingsBuilder<T> Line(Action<ChartXAxisNotesLineSettingsBuilder<T>> configurator)
        {

            Container.Line.Chart = Container.Chart;
            configurator(new ChartXAxisNotesLineSettingsBuilder<T>(Container.Line));

            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the notes. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartXAxisNotesSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the notes. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartXAxisNotesSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
