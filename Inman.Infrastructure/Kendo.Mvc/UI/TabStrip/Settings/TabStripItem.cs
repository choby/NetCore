namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TabStripItem class
    /// </summary>
    public partial class TabStripItem : NavigationItem<TabStripItem>, IAsyncContentContainer
    {
        private string loadContentFromUrl;

        public TabStripItem()
        {
        }

        public string ContentUrl
        {
            get
            {
                return loadContentFromUrl;
            }

            set
            {
                loadContentFromUrl = value;
                ContentHtmlAttributes.Clear();
                Content = null;
            }
        }
    }
}
