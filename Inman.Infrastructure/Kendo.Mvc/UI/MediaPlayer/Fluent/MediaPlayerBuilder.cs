using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI MediaPlayer
    /// </summary>
    public partial class MediaPlayerBuilder : WidgetBuilderBase<MediaPlayer, MediaPlayerBuilder>
       
    {
        public MediaPlayerBuilder(MediaPlayer component) : base(component)
        {
        }

        /// <summary>
        /// Specifies the object which holds the information about the media that will be played
        /// </summary>
        /// <param name="value">The value for Media</param>
        public MediaPlayerBuilder Media(Action<MediaPlayerMediaBuilder> configurator)
        {
            configurator(new MediaPlayerMediaBuilder(Component));
            return this;
        }
    }
}

