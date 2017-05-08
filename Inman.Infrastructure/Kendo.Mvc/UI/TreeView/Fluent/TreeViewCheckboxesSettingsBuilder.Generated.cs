using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeViewCheckboxesSettings
    /// </summary>
    public partial class TreeViewCheckboxesSettingsBuilder
        
    {
        /// <summary>
        /// Indicates whether checkboxes of child items should get checked when the checkbox of a parent item is checked. This
		/// also enables tri-state checkboxes with an indeterminate state.
        /// </summary>
        /// <param name="value">The value for CheckChildren</param>
        public TreeViewCheckboxesSettingsBuilder CheckChildren(bool value)
        {
            Container.CheckChildren = value;
            return this;
        }

        /// <summary>
        /// Indicates whether checkboxes of child items should get checked when the checkbox of a parent item is checked. This
		/// also enables tri-state checkboxes with an indeterminate state.
        /// </summary>
        public TreeViewCheckboxesSettingsBuilder CheckChildren()
        {
            Container.CheckChildren = true;
            return this;
        }

        /// <summary>
        /// Sets the name attribute of the checkbox inputs. That name will be posted to the server.
        /// </summary>
        /// <param name="value">The value for Name</param>
        public TreeViewCheckboxesSettingsBuilder Name(string value)
        {
            Container.Name = value;
            return this;
        }

        /// <summary>
        /// The template which renders the checkboxes. Can be used to allow posting of
		/// additional information along the TreeView checkboxes.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public TreeViewCheckboxesSettingsBuilder Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the checkboxes. Can be used to allow posting of
		/// additional information along the TreeView checkboxes.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public TreeViewCheckboxesSettingsBuilder TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

    }
}
