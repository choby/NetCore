using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ColorPicker for ASP.NET MVC events.
    /// </summary>
    public class ColorPickerEventBuilder: EventBuilder
    {
        public ColorPickerEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when a color was selected, either by clicking on it (in the\n\t\t/// simple picker), by clicking ENTER or by pressing "Apply" in the HSV\n\t\t/// picker.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public ColorPickerEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when a color was selected, either by clicking on it (in the\n\t\t/// simple picker), by clicking ENTER or by pressing "Apply" in the HSV\n\t\t/// picker.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ColorPickerEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires as a new color is displayed in the drop-down picker.  This is\n\t\t/// not necessarily the "final" value; for example this event triggers\n\t\t/// when the sliders in the HSV selector are dragged, but then pressing\n\t\t/// ESC would cancel the selection and the color will revert to the\n\t\t/// original value.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public ColorPickerEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fires as a new color is displayed in the drop-down picker.  This is\n\t\t/// not necessarily the "final" value; for example this event triggers\n\t\t/// when the sliders in the HSV selector are dragged, but then pressing\n\t\t/// ESC would cancel the selection and the color will revert to the\n\t\t/// original value.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ColorPickerEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fires when the picker popup is opening.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public ColorPickerEventBuilder Open(string handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fires when the picker popup is opening.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ColorPickerEventBuilder Open(Func<object, object> handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fires when the picker popup is closing.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public ColorPickerEventBuilder Close(string handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fires when the picker popup is closing.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ColorPickerEventBuilder Close(Func<object, object> handler)
        {
            Handler("close", handler);

            return this;
        }

    }
}

