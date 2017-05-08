namespace Kendo.Mvc.UI.Fluent
{
	using Extensions;

	/// <summary>
	/// Defines the fluent interface for configuring toolbar custom command.
	/// </summary>
	/// <typeparam name="T">The type of the model</typeparam>
	public class GridToolBarCustomCommandBuilder : GridToolBarCommandBuilderBase<GridToolBarCustomCommand, GridToolBarCustomCommandBuilder>
    {
        public GridToolBarCustomCommandBuilder(GridToolBarCustomCommand command) : base(command)
        {
        }        
   
        /// <summary>
        /// Sets the command name.
        /// </summary>
        /// <param name="name">The name of the command</param>
        /// <returns></returns>
        public GridToolBarCustomCommandBuilder Name(string name)
        {
            Command.Name = name;

            if (!Command.Text.HasValue())
            {
                Command.Text = name;
            }

            return this;
        }

        private void SetTextIfEmpty(string value)
        {
            if (string.IsNullOrEmpty(Command.Text))
            {
                Command.Text = value;
            }
        }
    }
}