namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;    

    public interface IGridActionCommand
    {
        IDictionary<string, object> Serialize();        
        
        string Name
        {
            get;
        }

        IDictionary<string, object> HtmlAttributes
        {
            get;
        }
    }
}