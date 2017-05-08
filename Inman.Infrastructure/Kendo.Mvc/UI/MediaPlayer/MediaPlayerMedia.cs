using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI.Fluent;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the object which holds the information about the media that will be played
    /// </summary>
    public class MediaPlayerMedia: JsonObject
    {
        public MediaPlayerMedia()
        {
           
        }

        /// <summary>
        /// Specifies the title of the media that will be played
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// String or an array of objects that hold the URL\URLs to the videos
        /// </summary>
        public object Source { get; set; }

        protected override void Serialize(IDictionary<string, object> json)
        {
            if (!string.IsNullOrEmpty(Title))
            {
                json.Add("title", Title);
            }
            if (Source != null)
            {
                json.Add("source", Source);
            }
        }
    }

}

