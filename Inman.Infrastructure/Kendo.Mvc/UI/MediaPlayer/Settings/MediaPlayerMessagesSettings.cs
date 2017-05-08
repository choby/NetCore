using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MediaPlayerMessagesSettings class
    /// </summary>
    public partial class MediaPlayerMessagesSettings
    {
        private readonly string MuteDefault = "Mute";
        private readonly string PlayDefault = "Play";
        private readonly string PauseDefault = "Pause";
        private readonly string QualityDefault = "Quality";
        private readonly string UnmuteDefault = "Unmute";
        private readonly string FullscreenDefault = "Full Screen";

        public MediaPlayerMessagesSettings()
        {
            if (Messages.MediaPlayer_Mute != MuteDefault)
            {
                this.Mute = Messages.MediaPlayer_Mute;
            }
            if (Messages.MediaPlayer_Pause != PauseDefault)
            {
                this.Pause = Messages.MediaPlayer_Pause;
            }
            if (Messages.MediaPlayer_Play != PlayDefault)
            {
                this.Play = Messages.MediaPlayer_Play;
            }
            if (Messages.MediaPlayer_Quality != QualityDefault)
            {
                this.Quality = Messages.MediaPlayer_Quality;
            }
            if (Messages.MediaPlayer_Unmute != UnmuteDefault)
            {
                this.Unmute = Messages.MediaPlayer_Unmute;
            }
            if (Messages.MediaPlayer_Fullscreen != FullscreenDefault)
            {
                this.Fullscreen = Messages.MediaPlayer_Fullscreen;
            }
        }

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            // Do manual serialization here

            return settings;
        }
    }
}
