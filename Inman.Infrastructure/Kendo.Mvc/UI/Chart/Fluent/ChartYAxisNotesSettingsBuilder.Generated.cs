using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisNotesSettings
    /// </summary>
    public partial class ChartYAxisNotesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The position of the y axis notes.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartYAxisNotesSettingsBuilder<T> Position(ChartNotePosition value)
        {
            Container.Position = value;
            return this;
        }

        /// <summary>
        /// The icon of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the icon setting.</param>
        public ChartYAxisNotesSettingsBuilder<T> Icon(Action<ChartYAxisNotesIconSettingsBuilder<T>> configurator)
        {

            Container.Icon.Chart = Container.Chart;
            configurator(new ChartYAxisNotesIconSettingsBuilder<T>(Container.Icon));

            return this;
        }

        /// <summary>
        /// The label of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the label setting.</param>
        public ChartYAxisNotesSettingsBuilder<T> Label(Action<ChartYAxisNotesLabelSettingsBuilder<T>> configurator)
        {

            Container.Label.Chart = Container.Chart;
            configurator(new ChartYAxisNotesLabelSettingsBuilder<T>(Container.Label));

            return this;
        }

        /// <summary>
        /// The line of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public ChartYAxisNotesSettingsBuilder<T> Line(Action<ChartYAxisNotesLineSettingsBuilder<T>> configurator)
        {

            Container.Line.Chart = Container.Chart;
            configurator(new ChartYAxisNotesLineSettingsBuilder<T>(Container.Line));

            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the notes. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartYAxisNotesSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the notes. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartYAxisNotesSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
