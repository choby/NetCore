using System;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent interface for configuring the column menu messages.
    /// </summary>
    public class GridColumnMenuMessagesBuilder : IHideObjectMembers
    {
        private readonly GridColumnMenuMessages messages;

        public GridColumnMenuMessagesBuilder(GridColumnMenuMessages messages)
        {
            this.messages = messages;
        }

        /// <summary>
        /// Sets the text displayed for filter menu option.
        /// </summary>
        /// <param name="message">The message</param>        
        public GridColumnMenuMessagesBuilder Filter(string message)
        {
            messages.Filter = message;

            return this;
        }

        /// <summary>
        /// Sets the text displayed for columns menu option.
        /// </summary>
        /// <param name="message">The message</param>        
        public GridColumnMenuMessagesBuilder Columns(string message)
        {
            messages.Columns = message;

            return this;
        }

        /// <summary>
        /// Sets the text displayed for sort ascending menu option.
        /// </summary>
        /// <param name="message">The message</param>        
        public GridColumnMenuMessagesBuilder SortAscending(string message)
        {
            messages.SortAscending = message;

            return this;
        }

        /// <summary>
        /// Sets the text displayed for sort descending menu option.
        /// </summary>
        /// <param name="message">The message</param>        
        public GridColumnMenuMessagesBuilder SortDescending(string message)
        {
            messages.SortDescending = message;

            return this;
        }

        /// <summary>
        /// Sets the text displayed for done menu button.
        /// </summary>
        /// <param name="message">The message</param>        
        public GridColumnMenuMessagesBuilder Done(string message)
        {
            messages.Done = message;

            return this;
        }

        /// <summary>
        /// Sets the text displayed for menu header.
        /// </summary>
        /// <param name="message">The message</param>        
        public GridColumnMenuMessagesBuilder ColumnSettings(string message)
        {
            messages.ColumnSettings = message;

            return this;
        }

        /// <summary>
        /// Sets the text message displayed in the column menu for locking a column.
        /// </summary>
        /// <param name="message">The message</param>        
        public GridColumnMenuMessagesBuilder Lock(string message)
        {
            messages.Lock = message;

            return this;
        }

        /// <summary>
        /// Sets the text message displayed in the column menu for unlocking a column.
        /// </summary>
        /// <param name="message">The message</param>        
        public GridColumnMenuMessagesBuilder Unlock(string message)
        {
            messages.Unlock = message;

            return this;
        }
    }
}