using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace XianShou.bcyoo.Common.Helper
{
    public static class EDBHelper
    {
        public static string EDBHttpPost(string method, string xmlValues)
        {
            string url = ConfigurationManager.AppSettings["EDBServiceUrl"];
            string dbhost = ConfigurationManager.AppSettings["EDBdbhost"];
            string appkey = ConfigurationManager.AppSettings["EDBAppkey"];
            string appscret = ConfigurationManager.AppSettings["EDBappscret"];
            string token = ConfigurationManager.AppSettings["EDBtoken"];
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmm");

            string ip = "";
            IPHostEntry IpEntry = Dns.GetHostEntry(Dns.GetHostName());
            for (int i = 0; i < IpEntry.AddressList.Length; i++)
            {
                //从IP地址列表中筛选出IPv4类型的IP地址
                //AddressFamily.InterNetwork表示此IP为IPv4,
                //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    ip = IpEntry.AddressList[i].ToString();
                }
            }

            string signstr = appkey + "appkey" + appkey + "appscret" + appscret + "edbhost" + dbhost + "formatXMLip" + ip + "method" + method + "slencry0timestamp" + timestamp + "token" + token + "v2.0xmlValues" + xmlValues;
            string sign = MD5Helper.GetMD5Hash(signstr);

            string xml = HttpUtility.UrlEncode(xmlValues);

            StringBuilder postdata = new StringBuilder();
            postdata.AppendFormat("dbhost={0}", dbhost);
            postdata.AppendFormat("&appkey={0}", appkey);
            postdata.AppendFormat("&format={0}", "XML");
            postdata.AppendFormat("&method={0}", method);
            postdata.AppendFormat("&timestamp={0}", timestamp);
            postdata.AppendFormat("&v={0}", "2.0");
            postdata.AppendFormat("&slencry={0}", "0");
            postdata.AppendFormat("&ip={0}", ip);
            postdata.AppendFormat("&sign={0}", sign);
            postdata.AppendFormat("&xmlValues={0}", xml);

            //string resultstr = RequestHelper.SendPost(url, postdata.ToString());

            //XmlDocument xdoc = new XmlDocument();
            //xdoc.LoadXml(resultstr);
            //returnInfo.IsSuccess = Convert.ToBoolean(xdoc.SelectSingleNode("is_success").Value);
            //returnInfo.Message = xdoc.SelectSingleNode("response_Msg").Value;

            return RequestHelper.SendPost(url, postdata.ToString());
        }

    }
}
