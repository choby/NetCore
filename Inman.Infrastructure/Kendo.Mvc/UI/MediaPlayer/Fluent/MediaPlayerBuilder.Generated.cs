using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI MediaPlayer
    /// </summary>
    public partial class MediaPlayerBuilder
        
    {
        /// <summary>
        /// If set to true, the widget will start playing the video or videos after initializing.
        /// </summary>
        /// <param name="value">The value for AutoPlay</param>
        public MediaPlayerBuilder AutoPlay(bool value)
        {
            Container.AutoPlay = value;
            return this;
        }

        /// <summary>
        /// If set to true, the widget will start playing the video or videos after initializing.
        /// </summary>
        public MediaPlayerBuilder AutoPlay()
        {
            Container.AutoPlay = true;
            return this;
        }

        /// <summary>
        /// If set to true, the widget will start playing the video or videos after initializing.
        /// </summary>
        /// <param name="value">The value for AutoRepeat</param>
        public MediaPlayerBuilder AutoRepeat(bool value)
        {
            Container.AutoRepeat = value;
            return this;
        }

        /// <summary>
        /// If set to true, the widget will start playing the video or videos after initializing.
        /// </summary>
        public MediaPlayerBuilder AutoRepeat()
        {
            Container.AutoRepeat = true;
            return this;
        }

        /// <summary>
        /// If set to false, the user will be prevented from seeking the video forward.
        /// </summary>
        /// <param name="value">The value for ForwardSeek</param>
        public MediaPlayerBuilder ForwardSeek(bool value)
        {
            Container.ForwardSeek = value;
            return this;
        }

        /// <summary>
        /// If set to true, the widget will enter fullscreen mode.
        /// </summary>
        /// <param name="value">The value for FullScreen</param>
        public MediaPlayerBuilder FullScreen(bool value)
        {
            Container.FullScreen = value;
            return this;
        }

        /// <summary>
        /// If set to true, the widget will enter fullscreen mode.
        /// </summary>
        public MediaPlayerBuilder FullScreen()
        {
            Container.FullScreen = true;
            return this;
        }

        /// <summary>
        /// The object which holds the localization strings.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public MediaPlayerBuilder Messages(Action<MediaPlayerMessagesSettingsBuilder> configurator)
        {

            Container.Messages.MediaPlayer = Container;
            configurator(new MediaPlayerMessagesSettingsBuilder(Container.Messages));

            return this;
        }

        /// <summary>
        /// If set to true, the video will be played without sound.
        /// </summary>
        /// <param name="value">The value for Mute</param>
        public MediaPlayerBuilder Mute(bool value)
        {
            Container.Mute = value;
            return this;
        }

        /// <summary>
        /// If set to true, the video will be played without sound.
        /// </summary>
        public MediaPlayerBuilder Mute()
        {
            Container.Mute = true;
            return this;
        }

        /// <summary>
        /// If set to true, the option enables the keyboard navigation for the widget.
        /// </summary>
        /// <param name="value">The value for Navigatable</param>
        public MediaPlayerBuilder Navigatable(bool value)
        {
            Container.Navigatable = value;
            return this;
        }

        /// <summary>
        /// If set to true, the option enables the keyboard navigation for the widget.
        /// </summary>
        public MediaPlayerBuilder Navigatable()
        {
            Container.Navigatable = true;
            return this;
        }

        /// <summary>
        /// A value between 0 and 100 that specifies the volume of the video.
        /// </summary>
        /// <param name="value">The value for Volume</param>
        public MediaPlayerBuilder Volume(double value)
        {
            Container.Volume = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().MediaPlayer()
        ///       .Name("MediaPlayer")
        ///       .Events(events => events
        ///           .End("onEnd")
        ///       )
        /// )
        /// </code>
        /// </example>
        public MediaPlayerBuilder Events(Action<MediaPlayerEventBuilder> configurator)
        {
            configurator(new MediaPlayerEventBuilder(Container.Events));
            return this;
        }
        
    }
}

