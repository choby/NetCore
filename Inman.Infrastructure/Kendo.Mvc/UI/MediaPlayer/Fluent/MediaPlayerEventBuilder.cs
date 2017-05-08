using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI MediaPlayer for ASP.NET MVC events.
    /// </summary>
    public class MediaPlayerEventBuilder: EventBuilder
    {
        public MediaPlayerEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when the media finishes playing.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the end event.</param>
        public MediaPlayerEventBuilder End(string handler)
        {
            Handler("end", handler);

            return this;
        }

        /// <summary>
        /// Fires when the media finishes playing.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MediaPlayerEventBuilder End(Func<object, object> handler)
        {
            Handler("end", handler);

            return this;
        }

        /// <summary>
        /// Fires when the media is paused.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the pause event.</param>
        public MediaPlayerEventBuilder Pause(string handler)
        {
            Handler("pause", handler);

            return this;
        }

        /// <summary>
        /// Fires when the media is paused.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MediaPlayerEventBuilder Pause(Func<object, object> handler)
        {
            Handler("pause", handler);

            return this;
        }

        /// <summary>
        /// Fires when the media begins playing.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the play event.</param>
        public MediaPlayerEventBuilder Play(string handler)
        {
            Handler("play", handler);

            return this;
        }

        /// <summary>
        /// Fires when the media begins playing.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MediaPlayerEventBuilder Play(Func<object, object> handler)
        {
            Handler("play", handler);

            return this;
        }

        /// <summary>
        /// Fires when loading is over and the widget is ready to start playing the media.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the ready event.</param>
        public MediaPlayerEventBuilder Ready(string handler)
        {
            Handler("ready", handler);

            return this;
        }

        /// <summary>
        /// Fires when loading is over and the widget is ready to start playing the media.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MediaPlayerEventBuilder Ready(Func<object, object> handler)
        {
            Handler("ready", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user selects a new play time.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the timeChange event.</param>
        public MediaPlayerEventBuilder TimeChange(string handler)
        {
            Handler("timeChange", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user selects a new play time.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MediaPlayerEventBuilder TimeChange(Func<object, object> handler)
        {
            Handler("timeChange", handler);

            return this;
        }

        /// <summary>
        /// This event is fired upon changing the volume level.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the volumeChange event.</param>
        public MediaPlayerEventBuilder VolumeChange(string handler)
        {
            Handler("volumeChange", handler);

            return this;
        }

        /// <summary>
        /// This event is fired upon changing the volume level.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MediaPlayerEventBuilder VolumeChange(Func<object, object> handler)
        {
            Handler("volumeChange", handler);

            return this;
        }

    }
}

