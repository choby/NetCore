using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorFileBrowserSchemaModelFieldsSettings
    /// </summary>
    public partial class EditorFileBrowserSchemaModelFieldsSettingsBuilder
        
    {
        /// <summary>
        /// The field which contains the name of the file/directory
        /// </summary>
        /// <param name="configurator">The configurator for the name setting.</param>
        public EditorFileBrowserSchemaModelFieldsSettingsBuilder Name(Action<EditorFileBrowserSchemaModelFieldsNameSettingsBuilder> configurator)
        {

            Container.Name.Editor = Container.Editor;
            configurator(new EditorFileBrowserSchemaModelFieldsNameSettingsBuilder(Container.Name));

            return this;
        }

        /// <summary>
        /// The field which contains the type of the entry. Either f for file or d for directory.
        /// </summary>
        /// <param name="configurator">The configurator for the type setting.</param>
        public EditorFileBrowserSchemaModelFieldsSettingsBuilder Type(Action<EditorFileBrowserSchemaModelFieldsTypeSettingsBuilder> configurator)
        {

            Container.Type.Editor = Container.Editor;
            configurator(new EditorFileBrowserSchemaModelFieldsTypeSettingsBuilder(Container.Type));

            return this;
        }

        /// <summary>
        /// The field which contains the size of file.
        /// </summary>
        /// <param name="configurator">The configurator for the size setting.</param>
        public EditorFileBrowserSchemaModelFieldsSettingsBuilder Size(Action<EditorFileBrowserSchemaModelFieldsSizeSettingsBuilder> configurator)
        {

            Container.Size.Editor = Container.Editor;
            configurator(new EditorFileBrowserSchemaModelFieldsSizeSettingsBuilder(Container.Size));

            return this;
        }

    }
}
