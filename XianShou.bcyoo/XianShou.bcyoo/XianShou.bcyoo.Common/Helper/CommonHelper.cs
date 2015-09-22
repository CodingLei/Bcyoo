using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Web;
using System.Net;
using System.Configuration;
//using System.Runtime.Serialization.Json;
using System.Collections.Specialized;
using System.Net.Mail;
using System.Globalization;


namespace XianShou.bcyoo.Common.Helper
{
    public class CommonHelper
    {
        #region 配置文件
        public static String GetAppSettings(String KeyName)
        {
            return ConfigurationManager.AppSettings[KeyName] != null ? ConfigurationManager.AppSettings[KeyName].ToString() : "";
        }
        #endregion
        #region 生成编码
        public static string GetCode(String BillType)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter();
            para[0].ParameterName = "@BillType";
            para[0].SqlDbType = SqlDbType.NVarChar;

            para[1] = new SqlParameter();
            para[1].ParameterName = "@BillCode";
            para[1].SqlDbType = SqlDbType.NVarChar;
            para[1].Size = 20;
            para[1].Direction = ParameterDirection.Output;
            para[0].Value = BillType;
            DBHelper.ExecuteCommand("GetCodeValue", para);
            return para[1].Value.ToString();
        }
        #endregion


        public enum RandomType
        {

            Number = 1,
            Letter = 2,
            NumberAndLetter = 3
        }

        #region 生成随机号
        /// <summary>
        /// 生成随机号
        /// </summary>
        /// <param name="length">长度</param>
        /// <param name="randomType">类型</param>
        /// <returns></returns>
        public static string GenRandomNumber(int length, RandomType randomType)
        {
            string[] source = null;
            string code = "";
            switch (randomType)
            {
                case RandomType.Number:
                    source = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                    break;
                case RandomType.Letter:
                    source = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                    break;
                case RandomType.NumberAndLetter:
                    source = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                    break;
                default:
                    source = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                    break;
            }
            Random rd = new Random();
            for (int i = 0; i < length; i++)
            {
                code += source[rd.Next(0, source.Length)];
            }
            return code;
        }
        #endregion
        #region DataGridParam
        /// <summary>
        /// 获取post传值，并返回DataGridParam类型
        /// </summary>
        /// <param name="postValueCollection"></param>
        /// <returns></returns>
        public static DataGridParam GetDataGridParam(NameValueCollection postValueCollection)
        {
            var paramValues = new DataGridParam();
            paramValues.Page = Convert.ToInt32(postValueCollection["Page"].Split(',')[0]);
            paramValues.RP = Convert.ToInt32(postValueCollection["RP"]);
            paramValues.SortName = postValueCollection["sort"];
            paramValues.SortOrder = postValueCollection["order"];
            if (!string.IsNullOrEmpty(postValueCollection["Query"]))
            {
                paramValues.Query = postValueCollection["Query"];
            }
            return paramValues;
        }
        #endregion
        #region 将String转换为Dictionary类型
        /// <summary>
        /// 将String转换为Dictionary类型，过滤掉为空的值，首先 6 分割，再 7 分割:&
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Dictionary<string, string> StringToDictionary(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                Dictionary<string, string> queryDictionary = new Dictionary<string, string>();
                string[] s = value.Split('^');
                for (int i = 0; i < s.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(s[i]) && !s[i].Contains("undefined") && !s[i].Contains("null"))
                    {
                        var ss = s[i].Split('&');
                        if ((!string.IsNullOrEmpty(ss[0])) && (!string.IsNullOrEmpty(ss[1])))
                        {
                            queryDictionary.Add(ss[0], ss[1]);
                        }
                    }

                }
                return queryDictionary;
            }
            return null;
        }


        public static Dictionary<string, string> StringToDictionary2(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                Dictionary<string, string> queryDictionary = new Dictionary<string, string>();
                string[] s = value.Split('^');
                for (int i = 0; i < s.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(s[i]) && !s[i].Contains("undefined") && !s[i].Contains("null"))
                    {
                        var ss = s[i].Split('~');
                        if ((!string.IsNullOrEmpty(ss[0])) && (!string.IsNullOrEmpty(ss[1])))
                        {
                            queryDictionary.Add(ss[0], ss[1]);
                        }
                    }

                }
                return queryDictionary;
            }
            return null;
        }
        #endregion
        #region 模糊替换
        public static string FuzzyReplace(string str)
        {
            return FuzzyReplace(str, "*");
        }
        public static string FuzzyReplace(string str, string symbol)
        {
            string strBefore = string.Empty;
            string strAfter = string.Empty;
            if (str.Contains('@'))
            {
                strBefore = str.Substring(0, str.IndexOf("@"));
            }
            else
            {
                strBefore = str;
            }
            int length = strBefore.Length;
            if (length <= 3)
            {
                strAfter = strBefore.Substring(0, 1) + "**" ;
            }
            else if (length <= 6 && length > 3)
            {
                strAfter = strBefore.Substring(0, 1) + "**" + strBefore.Substring(3, strBefore.Length - 3);
            }
            else if (length <= 12)
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
            return strAfter;
        }
        #endregion


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


        /// <summary>
        /// DataTable转化html select类型字符串
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="strValue"></param>
        /// <param name="strText"></param>
        /// <returns></returns>
        public static string DataTableToHtmlSelectString(DataTable dt, string strValue, string strText)
        {
            StringBuilder sb = new StringBuilder("");
            if (dt.Rows.Count < 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    sb.AppendFormat("<option value='{0}'>{1}</option>", item[strValue].ToString(), item[strText].ToString());
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 插入测试消息记录
        /// </summary>
        /// <param name="info"></param>
        public static void InsertTextMessage(string info)
        {
            SqlHelper.ExecSql(string.Format("insert into textmessage(info) values('{0}')", info.Replace("'", "''")));
        }

    }
}
