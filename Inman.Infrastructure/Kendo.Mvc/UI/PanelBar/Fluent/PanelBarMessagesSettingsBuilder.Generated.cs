using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring PanelBarMessagesSettings
    /// </summary>
    public partial class PanelBarMessagesSettingsBuilder
        
    {
        /// <summary>
        /// The text message shown while the root level items are loading.
        /// </summary>
        /// <param name="value">The value for Loading</param>
        public PanelBarMessagesSettingsBuilder Loading(string value)
        {
            Container.Loading = value;
            return this;
        }

        /// <summary>
        /// The text message shown when an error occurs while fetching the content.
        /// </summary>
        /// <param name="value">The value for RequestFailed</param>
        public PanelBarMessagesSettingsBuilder RequestFailed(string value)
        {
            Container.RequestFailed = value;
            return this;
        }

        /// <summary>
        /// The text message shown in the retry button.
        /// </summary>
        /// <param name="value">The value for Retry</param>
        public PanelBarMessagesSettingsBuilder Retry(string value)
        {
            Container.Retry = value;
            return this;
        }

    }
}
