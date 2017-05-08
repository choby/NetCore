namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.AspNetCore.Mvc.Rendering;

    internal class ModelDynamicDataKey : IDataKey<object>
    {
        public ModelDynamicDataKey(string memberName, Expression<Func<object , object>> expression)
        {
            RouteKey = "id";
            Name = memberName;
            Expression = expression;
            Value = expression.Compile();
        }

        public string Name
        {
            get;            
        }

        public string RouteKey
        {
            get;
            set;
        }

        public Func<object, object> Value
        {
            get;            
        }

        public Expression<Func<object , object>> Expression
        {
            get;            
        }

        public object GetValue(object dataItem)
        {
            try
            {
                return Value(dataItem);
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
            {
                return null;
            }
        }

        public string HiddenFieldHtml(IHtmlHelper<object> htmlHelper)
        {
            return htmlHelper.Hidden(Name, null, new { id = "" }).ToString();
        }
    }
}