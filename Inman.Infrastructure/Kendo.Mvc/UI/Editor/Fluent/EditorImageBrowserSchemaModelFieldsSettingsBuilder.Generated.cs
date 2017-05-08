using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorImageBrowserSchemaModelFieldsSettings
    /// </summary>
    public partial class EditorImageBrowserSchemaModelFieldsSettingsBuilder
        
    {
        /// <summary>
        /// The field which contains the name of the image/directory
        /// </summary>
        /// <param name="configurator">The configurator for the name setting.</param>
        public EditorImageBrowserSchemaModelFieldsSettingsBuilder Name(Action<EditorImageBrowserSchemaModelFieldsNameSettingsBuilder> configurator)
        {

            Container.Name.Editor = Container.Editor;
            configurator(new EditorImageBrowserSchemaModelFieldsNameSettingsBuilder(Container.Name));

            return this;
        }

        /// <summary>
        /// The field which contains the type of the entry. Either f for image or d for directory.
        /// </summary>
        /// <param name="configurator">The configurator for the type setting.</param>
        public EditorImageBrowserSchemaModelFieldsSettingsBuilder Type(Action<EditorImageBrowserSchemaModelFieldsTypeSettingsBuilder> configurator)
        {

            Container.Type.Editor = Container.Editor;
            configurator(new EditorImageBrowserSchemaModelFieldsTypeSettingsBuilder(Container.Type));

            return this;
        }

        /// <summary>
        /// The field which contains the size of image.
        /// </summary>
        /// <param name="configurator">The configurator for the size setting.</param>
        public EditorImageBrowserSchemaModelFieldsSettingsBuilder Size(Action<EditorImageBrowserSchemaModelFieldsSizeSettingsBuilder> configurator)
        {

            Container.Size.Editor = Container.Editor;
            configurator(new EditorImageBrowserSchemaModelFieldsSizeSettingsBuilder(Container.Size));

            return this;
        }

    }
}
