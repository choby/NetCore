namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using Kendo.Mvc.Infrastructure;

    /// <summary>
    /// Defines the fluent interface for configuring toolbar commands.
    /// </summary>
    /// <typeparam name="T">The type of the model</typeparam>    
    public class GridToolBarCommandFactory<T> : IHideObjectMembers
		where T : class
    {
        private readonly GridToolBarSettings settings;
		private readonly Grid<T> grid;

		public GridToolBarCommandFactory(GridToolBarSettings settings, Grid<T> grid)
        {
            this.settings = settings;
			this.grid = grid;
        }

        /// <summary>
        /// Defines a create command.
        /// </summary>
        /// <returns></returns>
        public GridToolBarCommandBuilder Create()
        {
            var command = new GridToolBarCreateCommand();

            settings.Commands.Add(command);

			grid.Editable.Enabled = true;

			return new GridToolBarCommandBuilder(command);
        }

        /// <summary>
        /// Represents a command which exports the current grid data to Excel.
        /// </summary>
        /// <returns></returns>
        public GridToolBarCommandBuilder Excel()
        {
            var command = new GridToolBarExcelCommand();

            settings.Commands.Add(command);

            return new GridToolBarCommandBuilder(command);
        }

        /// <summary>
        /// Represents a command which exports the current grid data to PDF.
        /// </summary>
        /// <returns></returns>
        public GridToolBarCommandBuilder Pdf()
        {
            var command = new GridToolBarPdfCommand();

            settings.Commands.Add(command);

            return new GridToolBarCommandBuilder(command);
        }

        /// <summary>
        /// Defines a save command.
        /// </summary>
        public GridToolBarSaveCommandBuilder Save()
        {
            var save = new GridToolBarSaveCommand();

            settings.Commands.Add(save);

			var cancel = new GridToolBarCancelCommand(save);
			settings.Commands.Add(cancel);			

			grid.Editable.Enabled = true;

			return new GridToolBarSaveCommandBuilder(save);
        }

        /// <summary>
        /// Defines a custom command.
        /// </summary>
        public GridToolBarCustomCommandBuilder Custom()
        {
            var command = new GridToolBarCustomCommand();

            settings.Commands.Add(command);

            return new GridToolBarCustomCommandBuilder(command);
        }
	
		/// <summary>
		/// Sets toolbar template.
		/// </summary>
		/// <param name="template">The action defining the template.</param>
		public void ClientTemplate(string template)
		{
			settings.ClientTemplate = template;
		}

        /// <summary>
		/// Sets the id of the script element which contains the client-side toolbar template of the grid.
		/// </summary>		
		public void ClientTemplateId(string template)
        {
            settings.ClientTemplateId = template;
        }
    }
}