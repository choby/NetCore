using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorFileBrowserSchemaModelSettings
    /// </summary>
    public partial class EditorFileBrowserSchemaModelSettingsBuilder
        
    {
        /// <summary>
        /// The name of the field which acts as an identifier.
        /// </summary>
        /// <param name="value">The value for Id</param>
        public EditorFileBrowserSchemaModelSettingsBuilder Id(string value)
        {
            Container.Id = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configurator">The configurator for the fields setting.</param>
        public EditorFileBrowserSchemaModelSettingsBuilder Fields(Action<EditorFileBrowserSchemaModelFieldsSettingsBuilder> configurator)
        {

            Container.Fields.Editor = Container.Editor;
            configurator(new EditorFileBrowserSchemaModelFieldsSettingsBuilder(Container.Fields));

            return this;
        }

    }
}
