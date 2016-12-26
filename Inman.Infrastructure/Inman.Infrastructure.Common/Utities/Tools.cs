using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Reflection;

namespace Inman.Infrastructure.Common
{
    /// <summary>
    /// 常用工具类
    /// </summary>
    public static class Tools
    {
        #region 产生随机字符串

        /// <summary>
        /// 产生随机字符串
        /// </summary>
        /// <param name="length">随机字符串的长度</param>
        /// <param name="strs">从指定的字符产生</param>
        /// <returns>随机字符串</returns>
        private static string MakeRandomString(int length, string strs)
        {
            string randomString = string.Empty;

            var rd = new Random(Convert.ToInt32(DateTime.Now.ToString("HHmmss")));

            for (int i = 0; i < length; i++)
                randomString += strs[rd.Next(strs.Length)];

            return randomString;
        }

        /// <summary>
        /// 产生随机字符串，从"ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"中随机产生
        /// </summary>
        /// <param name="length">随机字符串的长度</param>
        /// <returns>随机字符串</returns>
        public static string MakeRandomString(int length)
        {
            const string strs = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            return MakeRandomString(length, strs);
        }

        /// <summary>
        /// 产生随机数字字符串，从"1234567890"中随机产生
        /// </summary>
        /// <param name="length">随机字符串的长度</param>
        /// <returns>随机数字字符串</returns>
        public static string MakeNumricRandomString(int length)
        {
            const string strs = "1234567890";

            return MakeRandomString(length, strs);
        }

        /// <summary>
        /// 随机产生临时文件名
        /// 规则：YYYYMMDDhhnnss + 6位随机串 + 扩展名
        /// </summary>
        /// <param name="extName">文件扩展名</param>
        public static string MakeRandomFileName(string extName)
        {
            DateTime dt = DateTime.Now;
            string YYYY = dt.Year.ToString();
            string MM = ((dt.Month < 10) ? ("0" + dt.Month.ToString()) : dt.Month.ToString());
            string DD = ((dt.Day < 10) ? ("0" + dt.Day.ToString()) : dt.Day.ToString());
            string hh = ((dt.Hour < 10) ? ("0" + dt.Hour.ToString()) : dt.Hour.ToString());
            string nn = ((dt.Minute < 10) ? ("0" + dt.Minute.ToString()) : dt.Minute.ToString());
            string ss = ((dt.Second < 10) ? ("0" + dt.Second.ToString()) : dt.Second.ToString());
            string ffff = dt.Millisecond.ToString();

            string rndStr = YYYY + MM + DD + hh + nn + ss + ffff + MakeRandomString(6) + extName;
            return rndStr;
        }

        /// <summary> 
        /// 返回随机数组 
        /// </summary> 
        /// <param name="minValue">最小值</param> 
        /// <param name="maxValue">最大值</param> 
        /// <param name="count">个数</param> 
        /// <returns></returns> 
        public static int[] GetRandomUnrepeatArray(int minValue, int maxValue, int count)
        {
            var rnd = new Random();
            int length = maxValue - minValue + 1;
            var keys = new byte[length];
            rnd.NextBytes(keys);
            var items = new int[length];
            for (int i = 0; i < length; i++)
            {
                items[i] = i + minValue;
            }
            Array.Sort(keys, items);
            var result = new int[count];
            Array.Copy(items, result, count);
            return result;
        }

        #endregion

        

        //#region 读写Config
        ///// <summary>
        ///// 获取 web.config 文件中指定 key 的值
        ///// </summary>
        ///// <param name="keyName">key名称</param>
        ///// <returns></returns>
        //public static string GetAppSettings(string keyName)
        //{
        //    return ConfigurationManager.AppSettings[keyName];
        //}

        //#endregion

        //public static DataTable ConvertToTable(IQueryable query)
        //{
        //    var dtList = new DataTable();
        //    bool isAdd = false;
        //    PropertyInfo[] objProterties = null;
        //    foreach (var item in query)
        //    {
        //        if (!isAdd)
        //        {
        //            objProterties = item.GetType().GetProperties();
        //            foreach (var itemProterty in objProterties)
        //            {
        //                Type type;
        //                if (itemProterty.PropertyType != typeof(string) && itemProterty.PropertyType != typeof(int) && itemProterty.PropertyType != typeof(DateTime))
        //                {
        //                    type = typeof(string);
        //                }
        //                else
        //                {
        //                    type = itemProterty.PropertyType;
        //                }
        //                dtList.Columns.Add(itemProterty.Name, type);
        //            }
        //            isAdd = true;
        //        }
        //        var row = dtList.NewRow();
        //        foreach (var pi in objProterties)
        //        {
        //            row[pi.Name] = pi.GetValue(item, null);
        //        }
        //        dtList.Rows.Add(row);
        //    }

        //    return dtList;
        //}

        /// <summary>
        /// 检测是否有Sql危险字符
        /// </summary>
        /// <param name="str">要判断字符串</param>
        /// <returns>判断结果</returns>
        public static bool IsSafeSqlString(string str)
        {

            return !Regex.IsMatch(str, @"[-|;|,|\/|\(|\)|\[|\]|\}|\{|%|@|\*|!|\']");
        }

        /// <summary>
        /// 检测是否有危险的可能用于链接的字符串
        /// </summary>
        /// <param name="str">要判断字符串</param>
        /// <returns>判断结果</returns>
        public static bool IsSafeUserInfoString(string str)
        {
            return !Regex.IsMatch(str, @"^\s*$|^c:\\con\\con$|[%,\*" + "\"" + @"\s\t\<\>\&]|^Guest");
        }


        /// <summary>
        /// 将TexBoxt的文本转换为Html格式表在
        /// </summary>
        /// <param name="text">来自TextBox的文本</param>
        public static string TextToHtml(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return "";
            }

            text = text.Replace("\r\n", "<br />");
            //  Text = Text.Replace("\r", "<br />");
            text = text.Replace("\n", "<br />");
            text = text.Replace("  ", "&nbsp;&nbsp;");
            //Text = Text.Replace("'", "''"); Kevin.Mo  Modify 2010.08.24

            return text.Trim();
        }

        /// <summary>
        /// 将Html格式转换到TextBox的文本显示
        /// </summary>
        /// <param name="html">来自HTML编码</param>
        public static string HtmlToText(string html)
        {
            if (string.IsNullOrWhiteSpace(html))
                return "";
            
            html = html.Replace("<br />", "\r\n");
            html = html.Replace("<br>", "\r\n");
            html = html.Replace("&nbsp;&nbsp;", "  ");

            return html.Trim();
        }
    }
}
