namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent interface for configuring toolbar save command.
    /// </summary>
    /// <typeparam name="T">The type of the model</typeparam>
    public class GridToolBarSaveCommandBuilder: GridToolBarCommandBuilderBase< GridToolBarSaveCommand, GridToolBarSaveCommandBuilder>
    {
        public GridToolBarSaveCommandBuilder(GridToolBarSaveCommand command)
            : base(command)
        {
        }

        /// <summary>
        /// Sets the text displayed by the "save changes" button. If not set a default value is used.
        /// </summary>
        /// <param name="text">The text which should be displayed</param>
        /// <returns></returns>
        public GridToolBarSaveCommandBuilder SaveText(string text)
        {
            Command.SaveText = text;

            return this;
        }

        /// <summary>
        /// Sets the text displayed by the "cancel changes" button. If not set a default value is used.
        /// </summary>
        /// <param name="text">The text which should be displayed</param>
        /// <returns></returns>
        public GridToolBarSaveCommandBuilder CancelText(string text)
        {
            Command.CancelText = text;

            return this;
        }
    }
}