using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;

namespace XianShou.bcyoo.Common.Helper
{
    public class StrHelp
    {
        /// <summary>
        /// MD5 32位加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Md532(string str)
        {
            byte[] b = Encoding.Default.GetBytes(str);
            b = new MD5CryptoServiceProvider().ComputeHash(b);
            string ret = "";
            for (int i = 0; i < b.Length; i++)
                ret += b[i].ToString("x").PadLeft(2, '0');
            return ret;
        }

        /// <summary>
        /// MD5 16位加密
        /// </summary>
        /// <param name="ConvertString"></param>
        /// <returns></returns>
        public static string Md516(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(str)), 4, 8);
            t2 = t2.Replace("-", "");
            t2 = t2.ToLower();
            return t2;
        }

        /// <summary>
        /// 统计char出现在string中的次数
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="chr">字符</param>
        /// <returns></returns>
        public static int CharCount(string str, char chr)
        {
            int i = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == chr)
                {
                    i++;
                }
            }

            return i;
        }

        #region 随机字符串
        public static string MakeFileRndName()
        {
            return (DateTime.Now.ToString("ddHHmmss") + MakeRandomString("0123456789", 4));
            //return (DateTime.Now.ToString("yyyyMMddHHmmss") + MakeRandomString("0123456789", 4));
        }

        public static string MakeFolderName()
        {
            return DateTime.Now.ToString("yyyyMM");
        }

        public static string MakeRandomString(int pwdlen)
        {
            return MakeRandomString("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_*", pwdlen);
        }

        public static string MakeRandomString(string pwdchars, int pwdlen)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < pwdlen; i++)
            {
                int num = random.Next(pwdchars.Length);
                builder.Append(pwdchars[num]);
            }
            return builder.ToString();
        }

        public static string RandomNum()
        {
            return RandomNum(4);
        }

        public static string RandomNum(int intlong)
        {
            Random random = new Random();
            StringBuilder builder = new StringBuilder("");
            for (int i = 0; i < intlong; i++)
            {
                builder.Append(random.Next(10));
            }
            return builder.ToString();
        }
        #endregion

        /// <summary>
        /// 获取客户的IP地址
        /// </summary>
        /// <returns>客户的IP地址</returns>
        public static string GetIPAddress()
        {
            #region
            string result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(result))
            {
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            if (string.IsNullOrEmpty(result))
            {
                result = HttpContext.Current.Request.UserHostAddress;
            }

            return result;
            #endregion
        }

        /// <summary>
        /// 生成邮件验证码
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string CreateAuthStr(int len)
        {
            #region
            int number;
            StringBuilder checkCode = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < len; i++)
            {
                number = random.Next();

                if (number % 2 == 0)
                {
                    checkCode.Append((char)('0' + (char)(number % 10)));
                }
                else
                {
                    checkCode.Append((char)('A' + (char)(number % 26)));
                }
            }
            return checkCode.ToString();
            #endregion
        }

        /// <summary>
        /// 截取字符串优化版
        /// </summary>
        /// <param name="str">所要截取的字符串</param>
        /// <param name="length">截取字符串的长度</param>
        /// <returns></returns>
        public static string CutString(string str, int length, bool appendText)
        {
            #region
            Regex regex = new Regex("[\u4e00-\u9fa5]+", RegexOptions.Compiled);
            char[] stringChar = str.ToCharArray();
            StringBuilder sb = new StringBuilder();
            int nLength = 0;
            bool isCut = false;
            for (int i = 0; i < stringChar.Length; i++)
            {
                if (regex.IsMatch((stringChar[i]).ToString()))
                {
                    sb.Append(stringChar[i]);
                    nLength += 2;
                }
                else
                {
                    sb.Append(stringChar[i]);
                    nLength = nLength + 1;
                }

                if (nLength > length)
                {
                    isCut = true;
                    break;
                }
            }
            if (isCut)
                if (appendText)
                {
                    return sb.ToString() + "...";
                }
                else
                {
                    return sb.ToString();
                }
            else
                return sb.ToString();
            #endregion
        }

        /// <summary>
        /// 半角转全角
        /// </summary>
        /// <param name="BJstr"></param>
        /// <returns></returns>
        public static string GetQuanJiao(string BJstr)
        {
            #region
            char[] c = BJstr.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                byte[] b = System.Text.Encoding.Unicode.GetBytes(c, i, 1);
                if (b.Length == 2)
                {
                    if (b[1] == 0)
                    {
                        b[0] = (byte)(b[0] - 32);
                        b[1] = 255;
                        c[i] = System.Text.Encoding.Unicode.GetChars(b)[0];
                    }
                }
            }

            string strNew = new string(c);
            return strNew;

            #endregion
        }

        /// <summary>
        /// 全角转半角
        /// </summary>
        /// <param name="QJstr"></param>
        /// <returns></returns>
        public static string GetBanJiao(string QJstr)
        {
            #region
            char[] c = QJstr.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                byte[] b = System.Text.Encoding.Unicode.GetBytes(c, i, 1);
                if (b.Length == 2)
                {
                    if (b[1] == 255)
                    {
                        b[0] = (byte)(b[0] + 32);
                        b[1] = 0;
                        c[i] = System.Text.Encoding.Unicode.GetChars(b)[0];
                    }
                }
            }
            string strNew = new string(c);
            return strNew;
            #endregion
        }

        /// <summary>
        /// 字符串转换为 html
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StringToHtml(string str)
        {
            #region
            str = str.Replace("&", "&amp;");
            str = str.Replace(" ", "&nbsp;");
            str = str.Replace("'", "''");
            str = str.Replace("\"", "&quot;");
            str = str.Replace(" ", "&nbsp;");
            str = str.Replace("<", "&lt;");
            str = str.Replace(">", "&gt;");
            str = str.Replace("\r\n", "<br>");

            return str;
            #endregion
        }

        /// <summary>
        /// html转换成字符串
        /// </summary>
        /// <param name="strHtml"></param>
        /// <returns></returns>
        public static string HtmlToString(string strHtml)
        {
            #region
            strHtml = strHtml.Replace("<br>", "\r\n");
            strHtml = strHtml.Replace(@"<br />", "\r\n");
            strHtml = strHtml.Replace(@"<br/>", "\r\n");
            strHtml = strHtml.Replace("&gt;", ">");
            strHtml = strHtml.Replace("&lt;", "<");
            strHtml = strHtml.Replace("&nbsp;", " ");
            strHtml = strHtml.Replace("&quot;", "\"");

            strHtml = Regex.Replace(strHtml, @"<\/?[^>]+>", "", RegexOptions.IgnoreCase);

            return strHtml;
            #endregion
        }

        /// <summary>
        /// 来路地址
        /// </summary>
        /// <returns></returns>
        public static string GetReferer()
        {
            return HttpContext.Current.Request.ServerVariables["HTTP_REFERER"];
        }

        /// <summary>
        /// 绝对路径（并非项目所以路径，项目所以路径的上一级目录）
        /// </summary>
        /// <returns></returns>
        public static string GetPhysicalPath()
        {
            string Path = HttpContext.Current.Request.ServerVariables["APPL_PHYSICAL_PATH"];
            //Path = Path.Substring(0, Path.LastIndexOf('\\'));
            //Path = Path.Substring(0, Path.LastIndexOf('\\'));
            return Path;
        }

        public static string ClearHtml(string Html)
        {
            if (Html == string.Empty || string.IsNullOrEmpty(Html))
                return "";
            Regex RegexFrame = new Regex(@"<\/*[^<>]*>", RegexOptions.IgnoreCase);
            return RegexFrame.Replace(Html, string.Empty).Replace("&nbsp;", string.Empty);
        }
    }
}
