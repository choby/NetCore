using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorImageBrowserSchemaModelSettings
    /// </summary>
    public partial class EditorImageBrowserSchemaModelSettingsBuilder
        
    {
        /// <summary>
        /// The name of the field which acts as an identifier.
        /// </summary>
        /// <param name="value">The value for Id</param>
        public EditorImageBrowserSchemaModelSettingsBuilder Id(string value)
        {
            Container.Id = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configurator">The configurator for the fields setting.</param>
        public EditorImageBrowserSchemaModelSettingsBuilder Fields(Action<EditorImageBrowserSchemaModelFieldsSettingsBuilder> configurator)
        {

            Container.Fields.Editor = Container.Editor;
            configurator(new EditorImageBrowserSchemaModelFieldsSettingsBuilder(Container.Fields));

            return this;
        }

    }
}
