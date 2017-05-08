using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisNotesSettings
    /// </summary>
    public partial class ChartCategoryAxisNotesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The position of the category axis note.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartCategoryAxisNotesSettingsBuilder<T> Position(ChartNotePosition value)
        {
            Container.Position = value;
            return this;
        }

        /// <summary>
        /// The icon of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the icon setting.</param>
        public ChartCategoryAxisNotesSettingsBuilder<T> Icon(Action<ChartCategoryAxisNotesIconSettingsBuilder<T>> configurator)
        {

            Container.Icon.Chart = Container.Chart;
            configurator(new ChartCategoryAxisNotesIconSettingsBuilder<T>(Container.Icon));

            return this;
        }

        /// <summary>
        /// The label of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the label setting.</param>
        public ChartCategoryAxisNotesSettingsBuilder<T> Label(Action<ChartCategoryAxisNotesLabelSettingsBuilder<T>> configurator)
        {

            Container.Label.Chart = Container.Chart;
            configurator(new ChartCategoryAxisNotesLabelSettingsBuilder<T>(Container.Label));

            return this;
        }

        /// <summary>
        /// The line of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public ChartCategoryAxisNotesSettingsBuilder<T> Line(Action<ChartCategoryAxisNotesLineSettingsBuilder<T>> configurator)
        {

            Container.Line.Chart = Container.Chart;
            configurator(new ChartCategoryAxisNotesLineSettingsBuilder<T>(Container.Line));

            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the notes. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartCategoryAxisNotesSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the notes. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartCategoryAxisNotesSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
