using System.Security.Cryptography;
using System.Text;

namespace Zeje.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Encrypt_
    {
        #region MD5函数
        /// <summary>
        /// MD5函数,需引用：using System.Security.Cryptography;
        /// </summary>
        /// <param name="str">原始字符串</param>
        /// <returns>MD5结果</returns>
        public static string MD5(string str)
        {
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(str);//Encoding.Default.GetBytes(str);
            bs = new MD5CryptoServiceProvider().ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToUpper
());
            }
            return s.ToString();
        }

        public static string MD5_X(string str)
        {
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(str);//Encoding.Default.GetBytes(str);
            bs = new MD5CryptoServiceProvider().ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x").ToUpper
());
            }
            return s.ToString();
        }
        #endregion
    }
}
