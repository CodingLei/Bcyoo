using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace XianShou.bcyoo.Common.Helper
{
    public class ConvertHelper
    {
        #region 转换为int类型 无法转换返回0
        /// <summary>
        /// 字符转数字
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ConvertToInt(object obj)
        {
            return ConvertToInt(obj, 0);
        }
        /// <summary>
        /// 转换为int类型
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue">返回的默认值</param>
        /// <returns></returns>
        public static int ConvertToInt(object obj, int defaultValue)
        {
            return ConvertToInt(obj, defaultValue, NumberStyles.Number);
        }

        /// <summary>
        /// 转换为int类型
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue">返回的默认值</param>
        /// <param name="numStyle">数字格式</param>
        /// <returns></returns>
        public static int ConvertToInt(object obj, int defaultValue, NumberStyles numStyle)
        {
            int result = defaultValue;
            if (obj != null && obj != DBNull.Value)
            {
                if (!int.TryParse(obj.ToString().Trim(), numStyle, null, out result))
                {
                    result = defaultValue;
                }
            }
            return result;
        }
        #endregion
        #region 转换为decimal类型 无法转换返回0
        /// <summary>
        /// 字符转数字
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static decimal ConvertToDecimal(object obj)
        {
            return ConvertToDecimal(obj, 0);
        }
        /// <summary>
        /// 转换为int类型
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue">返回的默认值</param>
        /// <returns></returns>
        public static decimal ConvertToDecimal(object obj, decimal defaultValue)
        {
            return ConvertToDecimal(obj, defaultValue, NumberStyles.Number);
        }

        /// <summary>
        /// 转换为int类型
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="defaultValue">返回的默认值</param>
        /// <param name="numStyle">数字格式</param>
        /// <returns></returns>
        public static decimal ConvertToDecimal(object obj, decimal defaultValue, NumberStyles numStyle)
        {
            decimal result = defaultValue;
            if (obj != null && obj != DBNull.Value)
            {
                if (!decimal.TryParse(obj.ToString().Trim(), numStyle, null, out result))
                {
                    result = defaultValue;
                }
            }
            return result;
        }
        #endregion
        #region 编码转换
        public static string ConvertToGB(string unicodeString)
        {
            string[] strArray = unicodeString.Split(new string[] { @"u" }, StringSplitOptions.None);
            string result = string.Empty;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Trim() == "" || strArray[i].Length < 2 || strArray.Length <= 1)
                {
                    result += i == 0 ? strArray[i] : @"u" + strArray[i]; continue;
                }
                for (int j = strArray[i].Length > 4 ? 4 : strArray[i].Length; j >= 2; j--)
                {
                    try
                    {
                        result += char.ConvertFromUtf32(Convert.ToInt32(strArray[i].Substring(0, j), 16)) + strArray[i].Substring(j);
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }
            } return result;
        }
        public static string ConvertToUnicode(string strGB)
        {
            char[] chs = strGB.ToCharArray(); string result = string.Empty; foreach (char c in chs)
            {
                result += @"u" + char.ConvertToUtf32(c.ToString(), 0).ToString("x");
            }
            return result;
        }
        #endregion
        #region 二进制转换
        public static string StringToByte(string intput)
        {
            byte[] StrRes = Encoding.Default.GetBytes(intput);
            StringBuilder EnText = new StringBuilder();
            foreach (byte Byte in StrRes)
            {
                EnText.AppendFormat("{0:x2}", Byte);
            }
            return EnText.ToString();
        }
        #endregion

        #region 计算销量及收藏个数（实际评论*1.3+333）

        public static double GetVirtualCount(int intput)
        {
            return Math.Round(intput*1.3 + 333);
        }
        #endregion

		// 时间戳转为C#格式时间
		public static DateTime StampToDateTime(string timeStamp)
		{
			DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
			long lTime = long.Parse(timeStamp + "0000000");
			TimeSpan toNow = new TimeSpan(lTime);

			return dateTimeStart.Add(toNow);
		}

        /// <summary>
        /// 转换为bool类型
        /// </summary>
        /// <param name="obj">需要转换的值</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static bool ConvertToBool(object obj, bool defaultValue)
        {
            if (obj == null)
            {
                return defaultValue;
            }
            bool result;
            if (!bool.TryParse(obj.ToString(), out result))
            {
                result = defaultValue;
            }
            return result;
        }

        /// <summary>
        /// 转换为bool类型(默认返回false)
        /// </summary>
        /// <param name="obj">需要转换的值</param>
        /// <returns></returns>
        public static bool ConvertToBool(object obj)
        {
            return ConvertToBool(obj, false);
        }

        /// <summary>
        /// 转换为DateTime类型
        /// </summary>
        /// <param name="obj">需要转换的值</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static DateTime ConvertToDateTime(object obj, DateTime defaultValue)
        {
            if (obj == null)
            {
                return defaultValue;
            }
            DateTime result;
            if (!DateTime.TryParse(obj.ToString(), out result))
            {
                result = defaultValue;
            }
            return result;
        }

        /// <summary>
        /// 转换为DateTime类型（默认值1900-01-01）
        /// </summary>
        /// <param name="obj">需要转换的值</param>
        /// <returns></returns>
        public static DateTime ConvertToDateTime(object obj)
        {
            return ConvertToDateTime(obj, new DateTime(1900, 1, 1));
        }
    }
}
