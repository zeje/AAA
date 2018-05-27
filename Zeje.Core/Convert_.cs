using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Zeje.Core
{
    /// <summary>类型转换
    /// </summary>
    public static partial class Convert_
    {
        #region 可空类型转换
        /// <summary>将可空类型转换为字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="p_Object"></param>
        /// <returns></returns>
        public static string ToString_<T>(this Nullable<T> p_Object) where T : struct
        {
            return p_Object == null ? string.Empty : p_Object.ToString();
        }
        /// <summary>将对象内容装换为字符串
        /// </summary>
        /// <param name="p_Object"></param>
        /// <returns></returns>
        public static string ToString_(this object p_Object)
        {
            return p_Object == null ? string.Empty : p_Object.ToString();
        }

        #endregion

        #region 转换为具体类型
        /// <summary>
        /// </summary>
        /// <param name="p_Object"></param>
        /// <returns></returns>
        public static bool? ToBool_(this object p_Object)
        {
            if (p_Object != null && !string.IsNullOrWhiteSpace(p_Object.ToString()))
            {
                return Convert.ToBoolean(p_Object);
            }
            return null;
        }
        /// <summary>
        /// </summary>
        /// <param name="p_Object"></param>
        /// <returns></returns>
        public static byte? ToByte_(this object p_Object)
        {
            if (p_Object != null && !string.IsNullOrWhiteSpace(p_Object.ToString()))
            {
                return Convert.ToByte(p_Object);
            }
            return null;
        }
        /// <summary>
        /// </summary>
        /// <param name="p_Object"></param>
        /// <returns></returns>
        public static int? ToInt_(this object p_Object)
        {
            if (p_Object != null && !string.IsNullOrWhiteSpace(p_Object.ToString()))
            {
                return Convert.ToInt32(p_Object);
            }
            return null;
        }
        /// <summary>
        /// </summary>
        /// <param name="p_Object"></param>
        /// <returns></returns>
        public static long? ToLong_(this object p_Object)
        {
            if (p_Object != null && !string.IsNullOrWhiteSpace(p_Object.ToString()))
            {
                return Convert.ToInt64(p_Object);
            }
            return null;
        }
        /// <summary>
        /// </summary>
        /// <param name="p_Object"></param>
        /// <returns></returns>
        public static decimal? ToDecimal_(this object p_Object)
        {
            if (p_Object != null && !string.IsNullOrWhiteSpace(p_Object.ToString()))
            {
                return Convert.ToDecimal(p_Object);
            }
            return null;
        }
        /// <summary>
        /// </summary>
        /// <param name="p_Object"></param>
        /// <returns></returns>
        public static DateTime? ToDateTime_(this object p_Object)
        {
            if (p_Object != null && !string.IsNullOrWhiteSpace(p_Object.ToString()))
            {
                return Convert.ToDateTime(p_Object);
            }
            return null;
        }
        #endregion

        #region ID串&字符串

        /// <summary>转换为字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="p_List"></param>
        /// <param name="p_Separator"></param>
        /// <returns></returns>
        public static string ToString_<T>(this IEnumerable<T> p_List, string p_Separator = ",") where T : struct
        {
            return (p_List != null && p_List.Count() > 0) ? string.Join(p_Separator, p_List) : string.Empty;
        }
        /// <summary>
        /// </summary>
        /// <param name="p_Str"></param>
        /// <param name="chrSplit"></param>
        /// <returns></returns>
        public static IEnumerable<int> ToIntList_(this string p_Str, char chrSplit)
        {
            if (string.IsNullOrWhiteSpace(p_Str))
            {
                return new List<int>();
            }
            else
            {
                return p_Str.Split(chrSplit).Select(it => Convert.ToInt32(it));
            }
        }
        /// <summary>
        /// </summary>
        /// <param name="p_Str"></param>
        /// <param name="chrSplit"></param>
        /// <returns></returns>
        public static IEnumerable<long> ToLongList_(this string p_Str, char chrSplit)
        {
            if (string.IsNullOrWhiteSpace(p_Str))
            {
                return new List<long>();
            }
            else
            {
                return p_Str.Split(chrSplit).Select(it => Convert.ToInt64(it));
            }
        }
        #endregion
    }
}
