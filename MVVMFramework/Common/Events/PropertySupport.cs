using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Common.Events
{
    public static class PropertySupport
    {
        // Method ExtractPropertyName with token 060003D0
        public static string ExtractPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null)
                throw new ArgumentNullException("propertyExpression");
            MemberExpression memberExpression = propertyExpression.Body as MemberExpression;
            if (memberExpression == null)
                throw new ArgumentException(Resources.PropertySupport_NotMemberAccessExpression_Exception, "propertyExpression");
            PropertyInfo propertyInfo = memberExpression.Member as PropertyInfo;
            if (propertyInfo == (PropertyInfo)null)
                throw new ArgumentException(Resources.PropertySupport_ExpressionNotProperty_Exception, "propertyExpression");
            if (propertyInfo.GetGetMethod(true).IsStatic)
                throw new ArgumentException(Resources.PropertySupport_StaticExpression_Exception, "propertyExpression");
            return memberExpression.Member.Name;
        }
    }
}
