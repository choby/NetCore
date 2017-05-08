using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Editor
    /// </summary>
    public partial class EditorBuilder : WidgetBuilderBase<Editor, EditorBuilder>

    {
        public EditorBuilder(Editor component) : base(component)
        {
        }

        // Place custom settings here

        /// <summary>
        /// Sets the HTML content that will show initially in the editor.
        /// </summary>
        /// <param name="value">The action which renders the HTML content.</param>
        /// <code lang="CS">
        /// @(Html.Kendo().Editor()
        ///            .Name("Editor")
        ///            .Value(() => { );
        ///                &lt;blockquote&gt;
        ///                    According to Deep Thought, the answer to the ultimate question of
        ///                    life, the universe and everything is &lt;strong&gt;42&lt;/strong&gt;.
        ///                &lt;/blockquote&gt;
        ///            @(})
        ///            .Render();
        /// );
        /// </code>
        public EditorBuilder Value(Action value)
        {
            Component.ValueAction = value;

            return this;
        }

        /// <summary>
        /// Sets the HTML content that will show initially in the editor.
        /// </summary>
        /// <param name="value">The predicate which renders the HTML content.</param>
        /// <code lang="CS">
        /// @(Html.Kendo().Editor()
        ///            .Name("Editor")
        ///            .Value(@&lt;blockquote&gt;
        ///                    According to Deep Thought, the answer to the ultimate question of
        ///                    life, the universe and everything is &lt;strong&gt;42&lt;/strong&gt;.
        ///                &lt;/blockquote&gt;)
        ///            .Render();
        /// );
        /// </code>
        public EditorBuilder Value(Func<object, object> value)
        {
            Component.ValueHandler = value;

            return this;
        }
        
        /// <summary>
        /// Sets the CSS files that will be registered in the Editor's iframe
        /// </summary>
        /// <code lang="CS">
        /// @(Html.Kendo().Editor()
        ///             .Name("Editor")
        ///             .StyleSheets(styleSheets => styleSheets.Add("editorStyles.css"))
        /// );
        /// </code>        
        public EditorBuilder StyleSheets(Action<EditorStyleSheetBuilder> configurator)
        {
            configurator(new EditorStyleSheetBuilder(Component.StyleSheets));

            return this;
        }
    }
}

