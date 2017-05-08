namespace Kendo.Mvc.UI
{    
    using System.Collections.Generic;    

    public interface IGridColumn
    {
        bool IsLast
        {
            get;
        }

        string ClientTemplate
        {
            get;
            set;
        }
        
        string ClientFooterTemplate
        {
            get;
            set;
        }

        string ClientGroupFooterTemplate
        {
            get;
            set;
        }     

        bool Encoded
        {
            get;
            set;
        }

		string ClientHeaderTemplate
		{
			get;
			set;
		}

		IDictionary<string, object> HeaderHtmlAttributes 
        { 
            get; 
        }

        IDictionary<string, object> FooterHtmlAttributes
        {
            get;
        }         
        
        bool Hidden 
        { 
            get; 
            set; 
        }

        bool Locked 
        { 
            get; 
            set; 
        }

        bool Lockable
        {
            get;
            set;
        }

        bool IncludeInMenu
        {
            get;
            set;
        }
        
        IDictionary<string, object> HtmlAttributes 
        { 
            get; 
        }
        
        string Title 
        { 
            get; 
            set; 
        }
        
        bool Visible 
        { 
            get; 
            set; 
        }

        int MinScreenWidth
        {
            get;
            set;
        }

        string Width 
        { 
            get; 
            set; 
        }      
    }
}
