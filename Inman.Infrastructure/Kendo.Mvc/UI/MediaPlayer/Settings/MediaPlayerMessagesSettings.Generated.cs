using Kendo.Mvc.Extensions;
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
        public string Pause { get; set; }

        public string Play { get; set; }

        public string Mute { get; set; }

        public string Unmute { get; set; }

        public string Quality { get; set; }

        public string Fullscreen { get; set; }


        public MediaPlayer MediaPlayer { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Pause?.HasValue() == true)
            {
                settings["pause"] = Pause;
            }

            if (Play?.HasValue() == true)
            {
                settings["play"] = Play;
            }

            if (Mute?.HasValue() == true)
            {
                settings["mute"] = Mute;
            }

            if (Unmute?.HasValue() == true)
            {
                settings["unmute"] = Unmute;
            }

            if (Quality?.HasValue() == true)
            {
                settings["quality"] = Quality;
            }

            if (Fullscreen?.HasValue() == true)
            {
                settings["fullscreen"] = Fullscreen;
            }

            return settings;
        }
    }
}
