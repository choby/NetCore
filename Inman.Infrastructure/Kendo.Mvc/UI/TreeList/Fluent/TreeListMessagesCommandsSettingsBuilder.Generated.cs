using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListMessagesCommandsSettings
    /// </summary>
    public partial class TreeListMessagesCommandsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Defines the text of the "Cancel" button that discards the changes during editing.
        /// </summary>
        /// <param name="value">The value for Canceledit</param>
        public TreeListMessagesCommandsSettingsBuilder<T> Canceledit(string value)
        {
            Container.Canceledit = value;
            return this;
        }

        /// <summary>
        /// Defines the text of the "Add new record" button that adds new data rows.
        /// </summary>
        /// <param name="value">The value for Create</param>
        public TreeListMessagesCommandsSettingsBuilder<T> Create(string value)
        {
            Container.Create = value;
            return this;
        }

        /// <summary>
        /// Defines the text of the "Add child record" button that adds new child data rows.
        /// </summary>
        /// <param name="value">The value for Createchild</param>
        public TreeListMessagesCommandsSettingsBuilder<T> Createchild(string value)
        {
            Container.Createchild = value;
            return this;
        }

        /// <summary>
        /// Defines the text of the "Delete" button that deletes a data row.
        /// </summary>
        /// <param name="value">The value for Destroy</param>
        public TreeListMessagesCommandsSettingsBuilder<T> Destroy(string value)
        {
            Container.Destroy = value;
            return this;
        }

        /// <summary>
        /// Defines the text of the "Edit" button that shows the editable fields for the row.
        /// </summary>
        /// <param name="value">The value for Edit</param>
        public TreeListMessagesCommandsSettingsBuilder<T> Edit(string value)
        {
            Container.Edit = value;
            return this;
        }

        /// <summary>
        /// Defines the text of the "Export to Excel" button that exports the widget data in spreadsheet format.
        /// </summary>
        /// <param name="value">The value for Excel</param>
        public TreeListMessagesCommandsSettingsBuilder<T> Excel(string value)
        {
            Container.Excel = value;
            return this;
        }

        /// <summary>
        /// Defines the text of the "Export to PDF" button that exports the widget data in PDF format.
        /// </summary>
        /// <param name="value">The value for Pdf</param>
        public TreeListMessagesCommandsSettingsBuilder<T> Pdf(string value)
        {
            Container.Pdf = value;
            return this;
        }

        /// <summary>
        /// Defines the text of the "Update" button that applies the changes during editing.
        /// </summary>
        /// <param name="value">The value for Update</param>
        public TreeListMessagesCommandsSettingsBuilder<T> Update(string value)
        {
            Container.Update = value;
            return this;
        }

    }
}
