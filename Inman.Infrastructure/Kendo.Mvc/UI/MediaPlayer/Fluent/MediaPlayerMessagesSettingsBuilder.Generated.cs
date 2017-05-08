using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MediaPlayerMessagesSettings
    /// </summary>
    public partial class MediaPlayerMessagesSettingsBuilder
        
    {
        /// <summary>
        /// Pause button tooltip message.
        /// </summary>
        /// <param name="value">The value for Pause</param>
        public MediaPlayerMessagesSettingsBuilder Pause(string value)
        {
            Container.Pause = value;
            return this;
        }

        /// <summary>
        /// Play button tooltip message.
        /// </summary>
        /// <param name="value">The value for Play</param>
        public MediaPlayerMessagesSettingsBuilder Play(string value)
        {
            Container.Play = value;
            return this;
        }

        /// <summary>
        /// Mute button tooltip message.
        /// </summary>
        /// <param name="value">The value for Mute</param>
        public MediaPlayerMessagesSettingsBuilder Mute(string value)
        {
            Container.Mute = value;
            return this;
        }

        /// <summary>
        /// Unmute button tooltip message.
        /// </summary>
        /// <param name="value">The value for Unmute</param>
        public MediaPlayerMessagesSettingsBuilder Unmute(string value)
        {
            Container.Unmute = value;
            return this;
        }

        /// <summary>
        /// Quality button tooltip message.
        /// </summary>
        /// <param name="value">The value for Quality</param>
        public MediaPlayerMessagesSettingsBuilder Quality(string value)
        {
            Container.Quality = value;
            return this;
        }

        /// <summary>
        /// Fullscreen button tooltip message.
        /// </summary>
        /// <param name="value">The value for Fullscreen</param>
        public MediaPlayerMessagesSettingsBuilder Fullscreen(string value)
        {
            Container.Fullscreen = value;
            return this;
        }

    }
}
