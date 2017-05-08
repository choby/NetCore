using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListEditableSettings
    /// </summary>
    public partial class TreeListEditableSettingsBuilder<T>
        
    {
        public TreeListEditableSettingsBuilder(TreeListEditableSettings<T> container)
        {
            Container = container;
        }

        protected TreeListEditableSettings<T> Container
        {
            get;
            private set;
        }

		/// <summary>
		/// The editing mode to use. The supported editing modes are "inline" and "popup".
		/// </summary>
		/// <param name="value">The value for Mode</param>
		public TreeListEditableSettingsBuilder<T> Mode(string value)
		{
			Container.Mode = value.ToLowerInvariant() == "inline" ? TreeListEditMode.InLine : TreeListEditMode.PopUp;
			return this;
		}
	}
}
