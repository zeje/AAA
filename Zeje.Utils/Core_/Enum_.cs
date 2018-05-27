using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeje.Utils
{
    /// <summary>枚举辅助类
    /// </summary>
    public static class Enum_
    {
        /// <summary>
        /// 获取枚举值的详细文本
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string GetEnumDescription(this object e)
        {
            //获取字段信息
            System.Reflection.FieldInfo[] ms = e.GetType().GetFields();

            Type t = e.GetType();
            foreach (System.Reflection.FieldInfo f in ms)
            {
                //判断名称是否相等
                if (f.Name != e.ToString()) continue;

                //反射出自定义属性
                foreach (Attribute attr in f.GetCustomAttributes(true))
                {
                    //类型转换找到一个Description，用Description作为成员名称
                    System.ComponentModel.DescriptionAttribute dscript = attr as System.ComponentModel.DescriptionAttribute;
                    if (dscript != null)
                        return dscript.Description;
                }

            }

            //如果没有检测到合适的注释，则用默认名称
            return e.ToString();
        }
        /// <summary>将枚举以List的形式返回
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <returns></returns>
        public static List<KeyValuePair<int, string>> GetList<TEnum>() where TEnum : struct
        {
            List<KeyValuePair<int, string>> lst = new List<KeyValuePair<int, string>>();
            Type theEnum = typeof(TEnum);
            Array values = Enum.GetValues(theEnum);
            for (int i = 0; i < values.Length; i++)
            {
                object value = values.GetValue(i);
                string Text = ((TEnum)value).GetEnumDescription();
                KeyValuePair<int, string> item = new KeyValuePair<int, string>((int)value, Text);
                lst.Add(item);
            }
            return lst;
        }
    }
}
