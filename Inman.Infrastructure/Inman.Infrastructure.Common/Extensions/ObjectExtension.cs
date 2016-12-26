using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Inman.Infrastructure.Common.Extensions
{
    public static class ObjectExtension
    {
        public static string ToJsonString(this object source)
        {
            //if(source.IsNull())
            //    return string.Empty;
            return JsonConvert.SerializeObject(source);
        }

        public static T ToObject<T>(this string source)
        {
            //if(source.IsNullOrEmpty())
            //    return null;
            return JsonConvert.DeserializeObject<T>(source);
        }

        //public static T ToObject<T>(this RedisValue source)
        //{
        //    return JsonConvert.DeserializeObject<T>(source);
        //}

        public static DateTime ToMinTime(this DateTime date)
        {
            return date.Subtract(date.TimeOfDay);
        }

        public static DateTime ToMaxTime(this DateTime date)
        {
            return date.ToMinTime().Add(new TimeSpan(23, 59, 59));
        }

        #region If

        public static TResult If<T, TResult>(this T source,
                                Func<T, bool> condition,
                                Func<T, TResult> trueResult,
                                Func<T, TResult> falseResult)
                                where T : class
        {
            return condition(source) ? trueResult(source) : falseResult(source);
        }

        public static T If<T>(this T source,
                              Func<T, bool> condition,
                              Func<T, T> trueResult)
                                where T : class
        {
            return condition(source) ? trueResult(source) : source;
        }

        #endregion

        #region IfNull

        public static TResult IfNull<T, TResult>(this T source,
                                                Func<TResult> NullResult,
                                                Func<T, TResult> NotNullResult)
                                                where T : class
        {
            if (source == null)
            {
                return NullResult != null ? NullResult() : default(TResult);
            }
            else
            {
                return NotNullResult != null ? NotNullResult(source) : default(TResult);
            }
        }

        public static T IfNull<T>(this T source, T r) where T : class
        {
            return source ?? r;
        }

        #endregion

        public static TResult IfNotNull<T, TResult>(this T source,
                                      Func<T, TResult> NotNullResult,
                                      Func<TResult> NullResult)
                                      where T : class
        {
            if (source != null)
            {
                return NotNullResult != null ? NotNullResult(source) : default(TResult);
            }
            else
            {
                return NullResult != null ? NullResult() : default(TResult);
            }
        }

        public static void IfNotNull<T>(this T source, Action<T> NotNullResult) where T : class
        {
            if (source != null && NotNullResult != null)
            {
                NotNullResult(source);
            }
        }
    }

    public static class MathExtension
    {
        public static decimal? ToFix(this decimal? value, int digits = 2)
        {
            if (value == 0)
            {
                return 0.0000M;
            }
           
            return value == null ? value : Math.Round(value.Value, digits);
        }

        public static double? ToFix(this double? value, int digits = 2)
        {
            return value == null ? value : Math.Round(value.Value, digits);
        }

        public static decimal ToFix(this decimal value, int digits = 2)
        {
            return Math.Round(value, digits);
        }

        public static double ToFix(this double value, int digits = 2)
        {
            return Math.Round(value, digits);
        }

        public static string ToStringN4(this decimal value)
        {
            return string.Format("{0:0.0000}", value);
        }

        public static string ToStringN4(this decimal? value)
        {
            if (value.HasValue)
            {
                return ToStringN4(value.Value);
            }
            return string.Empty;
        }

        public static string ToStringN2(this decimal value)
        {
            return string.Format("{0:0.00}", value);
        }

        public static string ToStringN2(this decimal? value)
        {
            if (value.HasValue)
            {
                return ToStringN2(value.Value);
            }
            return string.Empty;
        }
    }
}
