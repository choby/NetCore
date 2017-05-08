using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Dialog
    /// </summary>
    public partial class DialogActionFactory
        
    {

        public Dialog Dialog { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DialogActionBuilder Add()
        {
            var item = new DialogAction();
            item.Dialog = Dialog;
            Container.Add(item);

            return new DialogActionBuilder(item);
        }
    }
}
