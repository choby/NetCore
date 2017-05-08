using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="Kendo.Mvc.UI.MediaPlayer{T}"/> bound to the specified data item type.
        /// </summary>
        /// <example>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <code lang="CS">
        ///  @(Html.Kendo().MediaPlayer&lt;Order&gt;()
        ///             .Name("MediaPlayer")
        ///             .BindTo(Model)
        /// )
        /// </code>
        /// </example>      
        public virtual MediaPlayerBuilder MediaPlayer() 
        {
            return new MediaPlayerBuilder(new MediaPlayer(HtmlHelper.ViewContext));
        }
    }
}