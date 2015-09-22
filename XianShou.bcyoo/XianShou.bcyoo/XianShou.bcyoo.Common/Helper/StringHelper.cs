using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XianShou.bcyoo.Common.Helper
{
    public class StringHelper
    {
        public static string SubStringLength(string str, int length)
        {
            if (str.Length > length)
            {
                return str.Substring(0, length-1);
            }
            else
            {
                return str;
            }
        }
        #region 模糊替换
        public static string FuzzyReplace(string str)
        {
            return FuzzyReplace(str, "*");
        }
        public static string FuzzyReplace(string str, string symbol)
        {
            string strAfter = string.Empty;
            if (!String.IsNullOrEmpty(str))
            {
                string strBefore = string.Empty;
                if (str.Contains('@'))
                {
                    strBefore = str.Substring(0, str.IndexOf("@"));
                }
                else
                {
                    strBefore = str;
                }
                int length = strBefore.Length;
                if (length < 6 && length > 3)
                {
                    strAfter = strBefore.Substring(0, 1) + "**" + strBefore.Substring(3, strBefore.Length - 3);
                }
                else if (length < 12)
                {
                    strAfter = strBefore.Substring(0, 3) + "****" + strBefore.Substring(7, strBefore.Length - 7);
                }
                else if (length > 12)
                {
                    strAfter = strBefore.Substring(0, 3) + "*****" + strBefore.Substring(8, strBefore.Length - 8);
                }
                else
                {
                    strAfter = strBefore;
                }
                if (str.Contains('@'))
                {
                    strAfter += str.Substring(str.IndexOf("@"), (str.Length - strBefore.Length));
                }
            }
            return strAfter;
        }
        #endregion
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
    }
}
