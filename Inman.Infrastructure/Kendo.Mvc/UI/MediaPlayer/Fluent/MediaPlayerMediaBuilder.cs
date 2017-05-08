using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class MediaPlayerMediaBuilder
    {
        protected MediaPlayer Component
        {
            get;
            private set;
        }

        public MediaPlayerMediaBuilder(MediaPlayer component)
        {
            Component = component;
        }

        /// <summary>
        /// Specifies the title of the media that will be played
        /// </summary>
        public MediaPlayerMediaBuilder Title(string title)
        {
            Component.Media.Title = title;
            return this;
        }

        public MediaPlayerMediaBuilder Source(object source)
        {
            Component.Media.Source = source;
            return this;
        }
    }
}
