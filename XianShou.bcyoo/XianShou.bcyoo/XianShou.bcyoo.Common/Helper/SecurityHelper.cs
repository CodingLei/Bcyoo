using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace XianShou.bcyoo.Common.Helper
{
    public class SecurityHelper
    {
        #region MD5加密对象的密钥和偏移量
        public static string SetMD5(string str)
        {

            //把字符串放到byte数组中
            byte[] bytIn = System.Text.Encoding.Default.GetBytes(str);
            //建立加密对象的密钥和偏移量        
            byte[] iv = { 102, 16, 93, 156, 78, 4, 218, 32 };//定义偏移量
            byte[] key = { 55, 103, 246, 79, 36, 99, 167, 3 };//定义密钥
            //实例DES加密类
            DESCryptoServiceProvider mobjCryptoService = new DESCryptoServiceProvider();
            mobjCryptoService.Key = iv;
            mobjCryptoService.IV = key;
            ICryptoTransform encrypto = mobjCryptoService.CreateEncryptor();
            //实例MemoryStream流加密密文件
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();
            return System.Convert.ToBase64String(ms.ToArray());

        }
        public static string DEMD5(string str)
        {
            try
            {
                //将解密字符串转换成字节数组
                byte[] bytIn = System.Convert.FromBase64String(str);
                //给出解密的密钥和偏移量，密钥和偏移量必须与加密时的密钥和偏移量相同
                byte[] iv = { 102, 16, 93, 156, 78, 4, 218, 32 };//定义偏移量
                byte[] key = { 55, 103, 246, 79, 36, 99, 167, 3 };//定义密钥
                DESCryptoServiceProvider mobjCryptoService = new DESCryptoServiceProvider();
                mobjCryptoService.Key = iv;
                mobjCryptoService.IV = key;
                //实例流进行解密
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytIn, 0, bytIn.Length);
                ICryptoTransform encrypto = mobjCryptoService.CreateDecryptor();
                CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);
                StreamReader strd = new StreamReader(cs, Encoding.Default);
                return strd.ReadToEnd();
            }
            catch (Exception ex)
            {
                return "";
            }

        }
        #endregion
        #region 微信MD5加密
        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="intput">输入字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string SHA1Encrypt(string intput)
        {
            byte[] StrRes = Encoding.Default.GetBytes(intput);
            HashAlgorithm mySHA = new SHA1CryptoServiceProvider();
            StrRes = mySHA.ComputeHash(StrRes);
            StringBuilder EnText = new StringBuilder();
            foreach (byte Byte in StrRes)
            {
                EnText.AppendFormat("{0:x2}", Byte);
            }
            return EnText.ToString();
        }

        //对密码进行MD5加密
        static string Md5EncryptStr32(string str)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            // Convert the input string to a byte array and compute the hash.  
            char[] temp = str.ToCharArray();
            byte[] buf = new byte[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                buf[i] = (byte)temp[i];
            }
            byte[] data = md5Hasher.ComputeHash(buf);
            // Create a new Stringbuilder to collect the bytes  
            // and create a string.  
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data   
            // and format each one as a hexadecimal string.  
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.  
            return sBuilder.ToString();
        }
        #endregion
    }
}
