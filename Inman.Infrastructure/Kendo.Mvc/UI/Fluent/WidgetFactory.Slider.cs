using System;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual SliderBuilder<T> Slider<T>() where T : struct, IComparable
        {
            return new SliderBuilder<T>(new Slider<T>(HtmlHelper.ViewContext));
        }

        public virtual SliderBuilder<double> Slider()
        {
            return new SliderBuilder<double>(new Slider<double>(HtmlHelper.ViewContext));
        }
    }
}