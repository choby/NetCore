using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorImageBrowserSchemaSettings
    /// </summary>
    public partial class EditorImageBrowserSchemaSettingsBuilder
        
    {
        /// <summary>
        /// Set the object which describes the image/directory entry fields. Note that a name, type and size fields should be set.
        /// </summary>
        /// <param name="configurator">The configurator for the model setting.</param>
        public EditorImageBrowserSchemaSettingsBuilder Model(Action<EditorImageBrowserSchemaModelSettingsBuilder> configurator)
        {

            Container.Model.Editor = Container.Editor;
            configurator(new EditorImageBrowserSchemaModelSettingsBuilder(Container.Model));

            return this;
        }

    }
}
