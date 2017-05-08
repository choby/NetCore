namespace Kendo.Mvc.UI
{
    using System;

    public interface IListViewEditingSettings
    {
        bool Enabled
        {
            get;
        }
    }

    public class ListViewEditingSettings<T> : IListViewEditingSettings where T : class
    {
        public ListViewEditingSettings()
        {
            DefaultDataItem = CreateDefaultItem;
        }

        public bool Enabled
        {
            get;
            set;
        }

        public string TemplateName
        {
            get;
            set;
        }

        public Func<T> DefaultDataItem
        {
            get;
            set;
        }

        private T CreateDefaultItem()
        {
            return Activator.CreateInstance<T>();
        }
    }
}