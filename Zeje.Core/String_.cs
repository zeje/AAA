using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace Zeje
{
    /// <summary>类型转换
    /// </summary>
    public static partial class String_
    {
        /// <summary>替换数据库中的换行符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToBRString_(this string str)
        {
            return str == null ? "" : str.Replace("\r\n", "<br />").Replace("\n", "<br />");
        }
        /// <summary>返回字符串真实长度, 1个汉字长度为2
        /// </summary>
        /// <returns></returns>
        public static int TrueLength_(this string str)
        {
            return Encoding.Default.GetBytes(str).Length;
        }
        /// <summary>替换第一个符合条件的字符
        /// </summary>
        /// <param name="str"></param>
        /// <param name="search"></param>
        /// <param name="replace"></param>
        /// <returns></returns>
        public static string ReplaceFirst_(this string str, string search, string replace)
        {
            int intPositon = str.IndexOf(search);
            if (intPositon < 0)
            {
                return str;
            }
            return str.Substring(0, intPositon) + replace + str.Substring(intPositon + search.Length);
        }

        /// <summary>是否为ip
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsIP_(this string str)
        {
            return Regex.IsMatch(str, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }
    }
}
