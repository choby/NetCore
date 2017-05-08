using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI RadioButton
    /// </summary>
    public partial class RadioButtonBuilder
        
    {
        /// <summary>
        /// Specifies whether the radio button is checked.
        /// </summary>
        /// <param name="value">The value for Checked</param>
        public RadioButtonBuilder Checked(bool value)
        {
            Container.Checked = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the radio button should be enabled or disabled. By default, it is enabled.
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public RadioButtonBuilder Enable(bool value)
        {
            Container.Enabled = value;
            return this;
        }

        /// <summary>
        /// Specifies the label text.
        /// </summary>
        /// <param name="value">The value for Label</param>
        public RadioButtonBuilder Label(string value)
        {
            Container.Label = value;
            return this;
        }

        /// <summary>
        /// Sets the value of the radio button.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public RadioButtonBuilder Value(object value)
        {
            Component.Value = value;

            return this;
        }
        
    }
}

