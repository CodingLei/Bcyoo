using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Text;

//using log4net;
//using Microsoft.VisualBasic.Logging;

namespace XianShou.bcyoo.Common.Helper
{
    public class HtmlHelper
    {
        //protected static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private string _referer = "";
        private string _cookie = "";
        private string _url = "";
        private string _encoding = "utf-8";

        #region 初始化
        public HtmlHelper() { }

        public HtmlHelper(string url, string cookie, string referer, string encoding)
        {
            _url = url;
            _cookie = cookie;
            _referer = referer;
            _encoding = encoding;
        }
        #endregion

        #region 异步方式获取网页源代码
        /// <summary>
        /// 异步方式获取网页源代码
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetHtmlByAsync()
        {
            var htUrl = new Hashtable();
            var sbHtml = new StringBuilder();

            var client = new WebClient { Encoding = Encoding.GetEncoding(_encoding) };
            client.Headers.Add(HttpRequestHeader.Cookie, _cookie);
            client.Headers.Add(HttpRequestHeader.Referer, _referer);
            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)");

            #region 网址列表
            var m = Regex.Match(_url, @"\((\d+),(\d+)\)", RegexOptions.Compiled);
            if (m.Success)
            {
                var start = Utils.StrToInt(m.Groups[1].Value, 0);
                var end = Utils.StrToInt(m.Groups[2].Value, 0);

                for (var i = start; i <= end; i++)
                    htUrl.Add(i, Regex.Replace(_url, @"\((\d+),(\d+)\)", i.ToString(), RegexOptions.Compiled));
            }
            else
                htUrl.Add(1, _url);
            #endregion

            #region 网址源码
            foreach (DictionaryEntry de in htUrl)
            {
                var urlHtml = string.Empty;
                try
                {
                    urlHtml = await client.DownloadStringTaskAsync(de.Value.ToString());
                }
                catch (Exception ex)
                {
                    urlHtml = ex.ToString();
                    //Log.DebugFormat("采集出错{0},{1}", de.Value, ex.ToString());
                    //var o = new GetRemoteObj();
                    //urlHtml = GetHtmlByUrl(de.Value.ToString(), "utf-8");
                }

                sbHtml.Append(urlHtml);
            }
            #endregion

            var html = sbHtml.ToString();
            if (!string.IsNullOrWhiteSpace(html)) html = html.Replace("\"", "'").Replace("\r", "").Replace("\n", "");
            return html;
        }
        #endregion

        #region 获取网页源代码
        /// <summary>
        /// 获取网页源代码
        /// </summary>
        /// <param name="url"></param>
        /// <param name="post"></param>
        /// <returns></returns>
        public string GetHtmlByPostUrl(string url, string post)
        {
            var cookieContainer = new CookieContainer();
            // 将提交的字符串数据转换成字节数组  
            byte[] postData = Encoding.UTF8.GetBytes(post);
            // 设置提交的相关参数  
            var myEncoding = Encoding.GetEncoding("utf-8");
            var request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.KeepAlive = false;
            request.AllowAutoRedirect = true;
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)";
            request.CookieContainer = cookieContainer;
            request.ContentLength = postData.Length;

            // 提交请求数据  
            var outputStream = request.GetRequestStream();
            outputStream.Write(postData, 0, postData.Length);
            outputStream.Close();

            var response = request.GetResponse() as HttpWebResponse;
            var responseStream = response.GetResponseStream();
            var reader = new StreamReader(responseStream, Encoding.UTF8);
            var html = reader.ReadToEnd();
            html = ReplaceEnter(html);
            reader.Close();
            return html;
        }
        #endregion

        /// <summary>
        /// GetHtml
        /// </summary>
        /// <param name="url"></param>
        /// <param name="encode"></param>
        /// <returns></returns>
        public string GetHtml(string url, string encode)
        {
            WebClient myWebClient = new WebClient();
            byte[] myDataBuffer = myWebClient.DownloadData(url);
            var html = Encoding.GetEncoding(encode).GetString(myDataBuffer);
            html = ReplaceEnter(html);
            return html;
        }

        #region 替换网页中的换行和引号
        /// <summary>
        /// 替换网页中的换行和引号
        /// </summary>
        /// <param name="html">HTML源代码</param>
        /// <returns></returns>
        public string ReplaceEnter(string html)
        {
            var s = "";
            s = string.IsNullOrEmpty(html)
                ? ""
                : html.Replace("\"", "'");
            s = s.Replace("\r", "").Replace("\n", "");
            return s;
        }
        #endregion

        public string RemoveStyle(string html)
        {
            var s = "";
            s = string.IsNullOrEmpty(html)
                ? ""
                : Regex.Replace(html, @" style='(.*?)'", "", RegexOptions.IgnoreCase | RegexOptions.Multiline);

            return s;
        }
    }
}