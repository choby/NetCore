namespace Kendo.Mvc.Extensions
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;

    internal static class MemberExpressionExtensions
    {
        internal static Type Type(this MemberExpression memberExpression)
        {
            if (memberExpression == null)
            {
                return null;
            }

            MemberInfo memberInfo = memberExpression.Member;

            if (memberInfo is PropertyInfo)
            {
                return ((PropertyInfo)memberInfo).PropertyType;
            }

            if (memberInfo is FieldInfo)
            {
                return ((FieldInfo)memberInfo).FieldType;
            }

            throw new NotSupportedException();
        }
    }
}