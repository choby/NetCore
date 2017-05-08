using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.TagHelpers
{
    public partial class NumericTextBoxTagHelper
    {
        /// <summary>
        /// Fires when the value is changed
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public string OnChange { get; set; }

        /// <summary>
        /// Fires when the value is changed from the spin buttons
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the spin event.</param>
        public string OnSpin { get; set; }


        protected override Dictionary<string, object> SerializeEvents()
        {
            var settings = new Dictionary<string, object>();

            if (OnChange?.HasValue() == true)
            {
                settings["change"] = CreateHandler(OnChange);
            }

            if (OnSpin?.HasValue() == true)
            {
                settings["spin"] = CreateHandler(OnSpin);
            }

            return settings;
        }
    }
}

