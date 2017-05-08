using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI MaskedTextBox
    /// </summary>
    public partial class MaskedTextBoxBuilder
        
    {
        /// <summary>
        /// Specifies whether the widget will replace the prompt characters with spaces on blur. Prompt chars will be shown again on focus (available since Q2 2014 SP1).
        /// </summary>
        /// <param name="value">The value for ClearPromptChar</param>
        public MaskedTextBoxBuilder ClearPromptChar(bool value)
        {
            Container.ClearPromptChar = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the widget will replace the prompt characters with spaces on blur. Prompt chars will be shown again on focus (available since Q2 2014 SP1).
        /// </summary>
        public MaskedTextBoxBuilder ClearPromptChar()
        {
            Container.ClearPromptChar = true;
            return this;
        }

        /// <summary>
        /// Specifies the culture info used by the widget.
        /// </summary>
        /// <param name="value">The value for Culture</param>
        public MaskedTextBoxBuilder Culture(string value)
        {
            Container.Culture = value;
            return this;
        }

        /// <summary>
        /// Specifies the input mask. The following mask rules are supported:
        /// </summary>
        /// <param name="value">The value for Mask</param>
        public MaskedTextBoxBuilder Mask(string value)
        {
            Container.Mask = value;
            return this;
        }

        /// <summary>
        /// Specifies the character used to represent the absence of user input in the widget
        /// </summary>
        /// <param name="value">The value for PromptChar</param>
        public MaskedTextBoxBuilder PromptChar(string value)
        {
            Container.PromptChar = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the widget will unmask the input value on form post (available since Q1 2015).
        /// </summary>
        /// <param name="value">The value for UnmaskOnPost</param>
        public MaskedTextBoxBuilder UnmaskOnPost(bool value)
        {
            Container.UnmaskOnPost = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the widget will unmask the input value on form post (available since Q1 2015).
        /// </summary>
        public MaskedTextBoxBuilder UnmaskOnPost()
        {
            Container.UnmaskOnPost = true;
            return this;
        }

        /// <summary>
        /// Specifies the value of the MaskedTextBox widget.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public MaskedTextBoxBuilder Value(string value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// Enables or disables the textbox
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public MaskedTextBoxBuilder Enable(bool value)
        {
            Container.Enable = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().MaskedTextBox()
        ///       .Name("MaskedTextBox")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public MaskedTextBoxBuilder Events(Action<MaskedTextBoxEventBuilder> configurator)
        {
            configurator(new MaskedTextBoxEventBuilder(Container.Events));
            return this;
        }
        
    }
}

