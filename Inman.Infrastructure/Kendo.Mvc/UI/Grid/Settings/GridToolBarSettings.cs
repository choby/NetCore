namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;
    using System.Linq;
    using Extensions;
    using System;

    public class GridToolBarSettings : JsonObject        
    {
        public GridToolBarSettings(WidgetBase grid)
        {
            Commands = new List<GridActionCommandBase>();
            Component = grid;               
        }  

        public WidgetBase Component { get; }

        public bool Enabled
        {
            get
            {
				return Commands.Any() || ClientTemplate.HasValue() || ClientTemplateId.HasValue();
            }
        }

        public IList<GridActionCommandBase> Commands
        {
            get;
            private set;
        }
		
		public string ClientTemplate
		{
			get;
			set;
		}

        public string ClientTemplateId
        {
            get;
            set;
        }

        protected override void Serialize(IDictionary<string, object> json)
		{
			var commands = new List<IDictionary<string, object>>();

			Commands.Each(command =>
			{
				commands.Add(command.Serialize());
			});

			if (commands.Any() && !ClientTemplate.HasValue())
			{
				json["commands"] = commands;
			}

			if (ClientTemplate.HasValue())
			{
				json["template"] = ClientTemplate;
			}

            if (ClientTemplateId.HasValue())
            {
                var idPrefix = "#";
                if (Component.IsInClientTemplate)
                {
                    idPrefix = "\\" + idPrefix;
                }

                json["template"] = new ClientHandlerDescriptor { HandlerName = $"kendo.template(jQuery('{idPrefix}{ClientTemplateId}').html())" };
            }
        }
    }
}