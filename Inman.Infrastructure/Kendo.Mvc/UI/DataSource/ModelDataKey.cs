namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq.Expressions;

    using Extensions;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class ModelDataKey<TModel, TValue> : IDataKey<TModel>
        where TModel : class
    {
        public ModelDataKey(Expression<Func<TModel, TValue>> expression)
        {
            RouteKey = "id";

            Expression = expression;
            Name = expression.MemberWithoutInstance();
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

        public Func<TModel, TValue> Value
        {
            get;            
        }

        public Expression<Func<TModel, TValue>> Expression
        {
            get;            
        }
        
        public object GetValue(object dataItem)
        {
            return Value((TModel)dataItem);
        }
        public string HiddenFieldHtml(IHtmlHelper<TModel> htmlHelper)
        {
            return htmlHelper.HiddenFor(Expression, new { id = "" }).ToString();
        }
    }
}
