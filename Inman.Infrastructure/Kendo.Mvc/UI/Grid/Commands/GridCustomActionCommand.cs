namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;    
    using Kendo.Mvc.Extensions;    

    public class GridCustomActionCommand : GridCustomCommandBase
	{        
        public ClientHandlerDescriptor Click { get; } = new ClientHandlerDescriptor();

		public override IDictionary<string, object> Serialize()
        {
            var state = base.Serialize();

            if (Text.HasValue())
            {
                state["text"] = Text;
            }

            if (Click.HasValue())
            {
                state["click"] = Click;
            }

            return state;
        }
    }
}
