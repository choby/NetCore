using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace Inman.Infrastructure.Common
{
    public class GenericListTypeConverter<T> : TypeConverter
    {
        protected readonly TypeConverter typeConverter;

        public GenericListTypeConverter()
        {
            typeConverter = TypeDescriptor.GetConverter(typeof(T));
            if (typeConverter == null)
                throw new InvalidOperationException("No type converter exists for type " + typeof(T).FullName);
        }

        protected virtual string[] GetStringArray(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                string[] result = input.Split(',');
                //Array.ForEach(result, s => s.Trim());
                foreach (var s in result)
                {
                    s.Trim();
                }
                return result;
            }
            else
                return new string[0];

        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                string[] items = GetStringArray(sourceType.ToString());
                return items.Any();
            }
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                string[] items = GetStringArray((string)value);
                var result = new List<T>();
                foreach (var s in items)
                {
                    object item = typeConverter.ConvertFromInvariantString(s);
                    if (item != null)
                    {
                        result.Add((T)item);
                    }
                }
                //Array.ForEach(items, s =>
                //    {
                //        object item = typeConverter.ConvertFromInvariantString(s);
                //        if (item != null)
                //        {
                //            result.Add((T)item);
                //        }
                //    });
                return result;
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                string result = string.Empty;
                if (((IList<T>)value) != null)
                {
                    for (int i = 0; i < ((IList<T>)value).Count; i++)
                    {
                        var str1 = Convert.ToString(((IList<T>)value)[i], CultureInfo.InvariantCulture);
                        result += str1;
                        //don't add comma after the last element
                        if (i != ((IList<T>)value).Count - 1)
                            result += ",";
                    }
                }
                return result;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
