using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorFileBrowserSchemaSettings
    /// </summary>
    public partial class EditorFileBrowserSchemaSettingsBuilder
        
    {
        /// <summary>
        /// Set the object which describes the file/directory entry fields. Note that a name, type and size fields should be set.
        /// </summary>
        /// <param name="configurator">The configurator for the model setting.</param>
        public EditorFileBrowserSchemaSettingsBuilder Model(Action<EditorFileBrowserSchemaModelSettingsBuilder> configurator)
        {

            Container.Model.Editor = Container.Editor;
            configurator(new EditorFileBrowserSchemaModelSettingsBuilder(Container.Model));

            return this;
        }

    }
}
