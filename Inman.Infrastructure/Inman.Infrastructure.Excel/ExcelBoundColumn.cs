using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;


namespace Inman.Infrastructure.Excel
{

    public class ExcelBoundColumn<TModel, TValue> : ExcelColumnBase<TModel>
    {
        public Excel<TModel> Excel { get; private set; }

        public Expression<Func<TModel, TValue>> Expression { get; private set; }

        private Func<TModel, TValue> GetValueFun { get; set; }

        private MemberExpression BodyExpression { get; set; }

        private PropertyInfo PropertyInfo { get; set; }

        private Func<TModel, object> SubGetValueFun { get; set; }

        public ExcelBoundColumn(Excel<TModel> excel, Expression<Func<TModel, TValue>> expression)
        {
            this.Excel = excel;
            this.Expression = expression;

            var member = expression.Body as MemberExpression;
            if (member == null)
            {
                throw new ArgumentException(string.Format(
                    "Expression '{0}' refers to a method, not a property.",
                    expression));
            }

            var propInfo = member.Member as PropertyInfo;
            if (propInfo == null)
            {
                throw new ArgumentException(string.Format(
                       "Expression '{0}' refers to a field, not a property.",
                       expression));
            }


            var viewDataDictionary = new ViewDataDictionary<TModel>(excel.ModelMetadataProvider, new ModelStateDictionary());
            this.Metadata = ExpressionMetadataProvider.FromLambdaExpression(expression, viewDataDictionary, excel.ModelMetadataProvider).Metadata;
            base.Member = ExpressionHelper.GetExpressionText(expression);
            base.MemberType = member.Type;
            base.Title = this.Metadata.DisplayName;
            base.Format = this.Metadata.DisplayFormatString;
            base.Visible = this.Metadata.ShowForDisplay;
            if (string.IsNullOrEmpty(this.Title))
            {
                this.Title = base.Member;
            }
            this.BodyExpression = member;
            this.PropertyInfo = propInfo;
            this.SubGetValueFun = System.Linq.Expressions.Expression
                                    .Lambda<Func<TModel, Object>>(BodyExpression.Expression, Expression.Parameters)
                                    .Compile();
            this.GetValueFun = Expression.Compile();
        }

        //public ModelMetadata Metadata { get; private set; }

        public override object GetColumnValue(TModel model)
        {
            if (Expression != null)
            {
                try
                {
                    if (!this.PropertyInfo.PropertyType.IsEnum)
                    {
                        if (!string.IsNullOrEmpty(this.Format))
                        {
                            try
                            {
                                var objValue = GetValueFun(model);
                                return string.Format(this.Format, objValue);
                            }
                            catch //(Exception e)
                            {

                            }
                        }

                        return GetValueFun(model);

                    }
                    else
                    {
                        var preModel = this.SubGetValueFun(model);
                        object obj = this.PropertyInfo.GetValue(preModel, null);
                        FieldInfo fi = obj.GetType().GetField(obj.ToString());
                        var attributes =
                            fi.GetCustomAttributes(typeof(DisplayAttribute), true).Cast<DisplayAttribute>();
                        if (attributes.Any())
                        {
                            return attributes.First().Name ?? string.Empty;
                        }
                    }

                }
                catch //(Exception e)
                {

                }
            }
            return null;
        }
    }
}
