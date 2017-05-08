using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI CheckBox
    /// </summary>
    public partial class CheckBoxBuilder
        
    {
        /// <summary>
        /// Indicates whether the CheckBox is checked.
        /// </summary>
        /// <param name="value">The value for Checked</param>
        public CheckBoxBuilder Checked(bool value)
        {
            Container.Checked = value;
            return this;
        }

        /// <summary>
        /// Indicates whether the CheckBox should be enabled or disabled. By default, it is enabled.
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public CheckBoxBuilder Enable(bool value)
        {
            Container.Enabled = value;
            return this;
        }

        /// <summary>
        /// Specifies the checkbox label.
        /// </summary>
        /// <param name="value">The value for Label</param>
        public CheckBoxBuilder Label(string value)
        {
            Container.Label = value;
            return this;
        }
    }
}

