namespace Kendo.Mvc.UI
{
    public interface IGanttBoundColumn
    {
        string Field
        {
            get;
            set;
        }

        string Format
        {
            get;
            set;
        }

        string Title 
        { 
            get; 
            set; 
        }

        string Width 
        { 
            get; 
            set; 
        }

        bool? Editable
        {
            get;
            set;
        }

        bool? Sortable
        {
            get;
            set;
        }
    }
}
