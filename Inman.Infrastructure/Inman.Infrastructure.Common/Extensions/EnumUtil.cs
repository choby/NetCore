using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Inman.Infrastructure.Common.Extensions
{
    public static class EnumUtil
    {
        private static Dictionary<string, string> _cacheEnumDescDic = new Dictionary<string, string>();
        private static Dictionary<object, Dictionary<object, object>> _cacheEnumToKeyAndValue = new Dictionary<object, Dictionary<object, object>>();
        private static Dictionary<object, Dictionary<object, object>> _cacheEnumToDescAndValue = new Dictionary<object, Dictionary<object, object>>();
        private static Dictionary<object, Dictionary<object, object>> _cacheEnumToDescAndName = new Dictionary<object, Dictionary<object, object>>();

        private static Dictionary<string, string> _cacheToDesc = new Dictionary<string, string>();


        /// <summary>
        /// 获取枚举的全名
        /// </summary>
        /// <param name="en">枚举名</param>
        /// <returns></returns>
        private static string GetEnumFullName(Enum en)
        {
            return en.GetType().FullName + "." + en.ToString();
        }


        

        /// <summary>
        /// 输出枚举的ShowName，需要枚举声明EnumShowNameAttribute
        /// </summary>
        /// <param name="en">待输出的枚举</param>
        /// <param name="exceptionIfNotSuccess">未成功是否抛出异常</param>
        /// <param name="flagsSeparator">Flags类型输出时的间隔符</param>
        /// <returns></returns>
       

        public static IEnumerable<SelectListItem> GetSelectListItem<T>()
        {
            return EoKeyAndValue<T>().Select(d => new SelectListItem { Text = d.Key.ToString(), Value = d.Value.ToString() });
        }
        /// <summary>
        /// 将枚举转换成Name/Value字典
        /// </summary>
        /// <typeparam name="T">枚举</typeparam>
        /// <returns></returns>
        public static Dictionary<object, object> EoKeyAndValue<T>()
        {
            Dictionary<object, object> dic = null;
            var type = typeof(T);
            if (!_cacheEnumToKeyAndValue.TryGetValue(type.ToString(), out dic))
            {
                dic = new Dictionary<object, object>();
                var values = Enum.GetValues(type);

                foreach (Enum Item in values)
                {
                    dic.Add(Item.ToString(), Convert.ToInt32(Item));
                }

                lock (_cacheEnumToKeyAndValue)
                {
                    _cacheEnumToKeyAndValue.Add(type.ToString(), dic);
                }
            }
            return dic;
        }

        

       


       

       

        /// <summary>
        ///枚举的对应数据库值的简单转换（用于数据列输出）
        /// </summary>
        /// <param name="id">数据库值</param>
        /// <param name="name">中文说明</param>
        /// <returns></returns>
        public static Dictionary<string, string> GetListToDic(string id, string name)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("id", id);
            dic.Add("text", name);

            return dic;
        }

        public static string GetDescription(this Enum en)
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {

                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute),
                false);

                if (attrs != null && attrs.Length > 0)

                    return ((DescriptionAttribute)attrs[0]).Description;

            }

            return en.ToString();
        }

        public static IEnumerable<SelectListItem> GetSelectListItem<TEnum>(this TEnum en) where TEnum : struct
        {
            IList<SelectListItem> list = new List<SelectListItem>();

            foreach (var e in Enum.GetValues(typeof(TEnum)))
            {
                SelectListItem m = new SelectListItem();
                object[] objArr = e.GetType().GetField(e.ToString()).GetCustomAttributes(typeof(DisplayAttribute), true);
                if (objArr != null && objArr.Length > 0)
                {
                    DisplayAttribute da = objArr[0] as DisplayAttribute;
                    m.Text = da.Name;
                }
                m.Value = Convert.ToInt32(e).ToString();
               
                list.Add(m);
            }
            return list;
        }

        public static string GetEnumDescription<TEnum>(this TEnum value) where TEnum : struct
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            if (fi == null)
                return string.Empty;
            var attribute = fi.GetCustomAttributes(
                typeof(DisplayAttribute), false)
                              .Cast<DisplayAttribute>()
                              .FirstOrDefault();
            if (attribute != null)
                return attribute.Name;
            return value.ToString();
        }

        public static string GetEnumText<TEnum>(this TEnum value) where TEnum : struct
        {
            return GetEnumDescription(value);
        }
    }
}
