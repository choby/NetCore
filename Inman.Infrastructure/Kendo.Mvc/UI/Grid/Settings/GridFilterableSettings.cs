using System.Linq;

namespace Kendo.Mvc.UI
{
    public class GridFilterableSettings : JsonObject
    {
        public GridFilterableSettings()
        {
            Mode = GridFilterMode.Menu;
            Messages = new GridFilterableMessages();
            Operators = new GridFilterableOperators();
        }

        public bool Enabled { get; set; }

        public bool? Extra { get; set; }

        public GridFilterMode Mode { get; set; }

        public GridFilterableMessages Messages { get; }

        public GridFilterableOperators Operators { get; }

        protected override void Serialize(System.Collections.Generic.IDictionary<string, object> json)
        {
            if (Extra.HasValue)
            {
                json["extra"] = Extra;
            }

            if (Mode == (GridFilterMode.Row | GridFilterMode.Menu))
            {
                json["mode"] = "menu, row";
            }
            else if (Mode != GridFilterMode.Menu)
            {
                json["mode"] = Mode;
            }

            var messages = Messages.ToJson();

            if (messages.Any())
            {
                json["messages"] = messages;
            }

            var operators = Operators.ToJson();

            if (operators.Any())
            {
                json["operators"] = operators;
            }
        }
    }
}