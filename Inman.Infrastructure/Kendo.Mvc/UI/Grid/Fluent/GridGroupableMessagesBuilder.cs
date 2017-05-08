namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent interface for configuring <see cref="GridGroupableSettings"/> messages.
    /// </summary>
    public class GridGroupableMessagesBuilder : IHideObjectMembers
    {
        private readonly GridGroupableMessages messages;

        public GridGroupableMessagesBuilder(GridGroupableMessages messages)
        {
            this.messages = messages;
        }

        /// <summary>
        /// Sets the text of the group panel when grid is not grouped.
        /// </summary>
        /// <param name="message">The message</param>
        /// <returns></returns>
        public GridGroupableMessagesBuilder Empty(string message)
        {
            messages.Empty = message;

            return this;
        }
    }
}
