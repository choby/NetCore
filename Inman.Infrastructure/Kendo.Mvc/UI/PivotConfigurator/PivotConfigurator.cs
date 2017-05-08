using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI PivotConfigurator component
    /// </summary>
    public partial class PivotConfigurator : WidgetBase
        
    {
        public PivotConfigurator(ViewContext viewContext) : base(viewContext)
        {
        }

        public PivotConfiguratorMessages Messages
        {
            get;            
        } = new PivotConfiguratorMessages();

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            var messages = Messages.ToJson();
            if (messages.Count > 0)
            {
                settings["messages"] = messages;
            }


            writer.Write(Initializer.Initialize(Selector, "PivotConfigurator", settings));
        }
    }
}

