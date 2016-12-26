using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Engines;

namespace Inman.Infrastructure.Common
{
    /// <summary>
    /// 安全常用工具
    /// </summary>
    /// <remarks>
    /// 修改历史 : 无
    /// </remarks>
    public class SecurityUtil
    {
        #region to core modify
        //默认密钥向量   
        //private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        ///// <summary>   
        ///// DES加密字符串   
        ///// </summary>   
        ///// <param name="encryptString">待加密的字符串</param>   
        ///// <param name="encryptKey">加密密钥,要求为8位</param>   
        ///// <returns>加密成功返回加密后的字符串，失败返回源串</returns>   
        //to core modify
        //public static string EncryptDES(string encryptString, string encryptKey)
        //{
        //    try
        //    {
        //        byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
        //        byte[] rgbIV = Keys;
        //        byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
        //        DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
        //        MemoryStream mStream = new MemoryStream();
        //        CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
        //        cStream.Write(inputByteArray, 0, inputByteArray.Length);
        //        cStream.FlushFinalBlock();
        //        return Convert.ToBase64String(mStream.ToArray());
        //    }
        //    catch
        //    {
        //        return encryptString;
        //    }
        //}

        ///// <summary>   
        ///// DES解密字符串   
        ///// </summary>   
        ///// <param name="decryptString">待解密的字符串</param>   
        ///// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>   
        ///// <returns>解密成功返回解密后的字符串，失败返源串</returns>   
        //public static string DecryptDES(string decryptString, string decryptKey)
        //{
        //    try
        //    {
        //        byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
        //        byte[] rgbIV = Keys;
        //        byte[] inputByteArray = Convert.FromBase64String(decryptString);
        //        DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
        //        MemoryStream mStream = new MemoryStream();
        //        CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
        //        cStream.Write(inputByteArray, 0, inputByteArray.Length);
        //        cStream.FlushFinalBlock();
        //        return Encoding.UTF8.GetString(mStream.ToArray());
        //    }
        //    catch
        //    {
        //        return decryptString;
        //    }
        //}
        #endregion

        #region 新的实现
        //.NET Core上面的DES等加密算法要等到1.2 才支持，我们可是急需这个算法的支持，文章《使用 JavaScriptService 在.NET Core 里实现DES加密算法》需要用Nodejs，
        //很多人觉得这个有点不好，今天就给大家介绍下BouncyCastle （Portable.BouncyCastle）https://www.nuget.org/packages/Portable.BouncyCastle/库为我们提供的原生的.NET Core的支持库的Des算法。
        //BouncyCastle的文档比较少，折腾了好久才写出了.NET 代码等价的一个封装。


        static IBlockCipher engine = new DesEngine();
        /// <summary>   
        /// DES加密字符串   
        /// </summary>   
        /// <param name="cipherText">待加密的字符串</param>   
        /// <param name="keys">加密密钥,要求为8位</param>   
        /// <returns>加密成功返回加密后的字符串，失败返回源串</returns>   
        public static string EncryptDES(string plainText, string keys)
        {
            byte[] ptBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] rv = Encrypt(keys, ptBytes);
            StringBuilder ret = new StringBuilder();
            foreach (byte b in rv)
            {
                ret.AppendFormat("{0:X2}", b);
            }
            return ret.ToString();
        }
        private static byte[] Encrypt(string keys, byte[] ptBytes)
        {
            byte[] key = Encoding.UTF8.GetBytes(keys);
            BufferedBlockCipher cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(engine), new Pkcs7Padding());
            cipher.Init(true, new ParametersWithIV(new DesParameters(key), key));
            byte[] rv = new byte[cipher.GetOutputSize(ptBytes.Length)];
            int tam = cipher.ProcessBytes(ptBytes, 0, ptBytes.Length, rv, 0);
            cipher.DoFinal(rv, tam);
            return rv;
        }

        /// <summary>
                /// 使用DES解密，key输入密码的时候，必须使用英文字符，区分大小写，且字符数量是8个，不能多也不能少
                /// </summary>
                /// <param name="cipherText">需要加密的字符串</param>
                /// <param name="keys">加密字符串的密钥</param>
                /// <returns>解密后的字符串</returns>
        public static string DecryptDES( string cipherText, string keys)
        {
            byte[] inputByteArray = new byte[cipherText.Length / 2];
            for (int x = 0; x < cipherText.Length / 2; x++)
            {
                int i = (Convert.ToInt32(cipherText.Substring(x * 2, 2), 16));
                inputByteArray[x] = (byte)i;
            }
            var rv = Decrypt(keys, inputByteArray);
            return Encoding.UTF8.GetString(rv);
        }
        private static byte[] Decrypt(string keys, byte[] cipherText)
        {
            byte[] key = Encoding.UTF8.GetBytes(keys);
            BufferedBlockCipher cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(engine));
            cipher.Init(false, new ParametersWithIV(new DesParameters(key), key));
            byte[] rv = new byte[cipher.GetOutputSize(cipherText.Length)];
            int tam = cipher.ProcessBytes(cipherText, 0, cipherText.Length, rv, 0);
            cipher.DoFinal(rv, tam);
            return rv;
        }
#endregion
    }
}
