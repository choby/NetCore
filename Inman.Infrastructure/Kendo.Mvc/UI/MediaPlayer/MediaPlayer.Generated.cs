using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MediaPlayer component
    /// </summary>
    public partial class MediaPlayer 
    {
        public bool? AutoPlay { get; set; }

        public bool? AutoRepeat { get; set; }

        public bool? ForwardSeek { get; set; }

        public bool? FullScreen { get; set; }

        public MediaPlayerMessagesSettings Messages { get; } = new MediaPlayerMessagesSettings();

        public bool? Mute { get; set; }

        public bool? Navigatable { get; set; }

        public double? Volume { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoPlay.HasValue)
            {
                settings["autoPlay"] = AutoPlay;
            }

            if (AutoRepeat.HasValue)
            {
                settings["autoRepeat"] = AutoRepeat;
            }

            if (ForwardSeek.HasValue)
            {
                settings["forwardSeek"] = ForwardSeek;
            }

            if (FullScreen.HasValue)
            {
                settings["fullScreen"] = FullScreen;
            }

            var messages = Messages.Serialize();
            if (messages.Any())
            {
                settings["messages"] = messages;
            }

            if (Mute.HasValue)
            {
                settings["mute"] = Mute;
            }

            if (Navigatable.HasValue)
            {
                settings["navigatable"] = Navigatable;
            }

            if (Volume.HasValue)
            {
                settings["volume"] = Volume;
            }

            return settings;
        }
    }
}
