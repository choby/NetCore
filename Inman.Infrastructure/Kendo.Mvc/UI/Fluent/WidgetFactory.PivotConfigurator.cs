using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="PivotConfigurator"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PivotConfigurator()
        ///             .Name("PivotConfigurator")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual PivotConfiguratorBuilder PivotConfigurator()
        {
            return new PivotConfiguratorBuilder(new PivotConfigurator(HtmlHelper.ViewContext));
        }


    }
}