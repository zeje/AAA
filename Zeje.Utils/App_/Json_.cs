using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace Zeje.Utils
{
    /// <summary>Json数据与对象的转换 
    /// <remarks>
    /// install-package Newtonsoft.Json
    /// </remarks>
    /// </summary>
    public class Json_
    {
        /// <summary>获得Json字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetString(object obj)
        {
            //DataContractJsonSerializer json = new DataContractJsonSerializer(obj.GetType());
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    json.WriteObject(stream, obj);
            //    string szJson = Encoding.UTF8.GetString(stream.ToArray()); return szJson;
            //}
            return fastJSON.JSON.ToJSON(obj);
            //return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
        /// <summary>获取Json的Model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strJson"></param>
        /// <returns></returns>
        public static T GetObject<T>(string strJson)
        {
            //T obj = Activator.CreateInstance<T>();
            //using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(szJson)))
            //{
            //    DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            //    return (T)serializer.ReadObject(ms);
            //}
            return fastJSON.JSON.ToObject<T>(strJson);
            //return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(strJson);
        }
    }
}