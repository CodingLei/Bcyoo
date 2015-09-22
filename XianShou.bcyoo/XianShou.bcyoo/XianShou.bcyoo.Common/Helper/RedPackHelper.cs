
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;

namespace XianShou.bcyoo.Common.Helper
{
    public class RedPackHelper
    {
        public string PostPage(string posturl, string postData)
        {
            Stream outstream = null;
            Stream instream = null;
            StreamReader sr = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            Encoding encoding = Encoding.UTF8;
            byte[] data = encoding.GetBytes(postData);
            // 准备请求...  
            try
            {
                //CerPath证书路径
                string certPath = @"D:\apiclient_cert.p12";//@"C:\Users\jie\Desktop\apiclient_cert.p12";
                //证书密码
                string password = "1230897902";
                X509Certificate2 cert = new System.Security.Cryptography.X509Certificates.X509Certificate2(certPath, password, X509KeyStorageFlags.MachineKeySet);
                //X509Certificate cer = new X509Certificate(cert, password);
                // 设置参数  
                request = WebRequest.Create(posturl) as HttpWebRequest;
                CookieContainer cookieContainer = new CookieContainer();
                request.CookieContainer = cookieContainer;
                request.AllowAutoRedirect = true;
                request.Method = "POST";
                request.ContentType = "text/xml";
                request.ContentLength = data.Length;
                request.ClientCertificates.Add(cert);
                outstream = request.GetRequestStream();
                outstream.Write(data, 0, data.Length);
                outstream.Close();
                //发送请求并获取相应回应数据  
                response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求  
                instream = response.GetResponseStream();
                sr = new StreamReader(instream, encoding);
                //返回结果网页（html）代码  
                string content = sr.ReadToEnd();
                string err = string.Empty;
                return content;

            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return string.Empty;
            }
        }
        public string SendRedPack(string openId,  int value, string act_name, int act_id, string mch_billno,string clientIp)
        {
           return SendRedPack(openId, value, act_name, act_id, mch_billno, clientIp, "美白第一欧诗漫，感谢您的支持");
        }
        public string SendRedPack(string openId, int value, string act_name, int act_id, string mch_billno, string clientIp,string wishing)
        {
            string mch_id = "1230897902";
            string appid = CommonHelper.GetAppSettings("AppID"); ;
            string nick_name = "欧诗漫微商";
            string send_name = "欧诗漫微商";
            string[] Nu = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string number = string.Empty;
            Random rd = new Random();
            number = rd.Next(1, 9).ToString() + System.DateTime.Now.ToString("hhmmssfff");
            int total_amount = value;
            int min_value = value;
            int max_value = value;
            int total_num = 1;
            
            string remark = "欧诗漫 美白第一，关注公众账号osmws2015更多惊喜！";
            string nonce_str = RandString();
            string stringA = string.Format("act_id={15}&act_name={1}&client_ip={2}&max_value={4}&mch_billno={5}&mch_id={13}&min_value={3}&nick_name={6}&nonce_str={7}&re_openid={8}&remark={9}&send_name={10}&total_amount={11}&total_num={12}&wishing={14}&wxappid={0}", appid, act_name, clientIp, min_value, max_value, mch_billno, nick_name, nonce_str, openId, remark, send_name, total_amount, total_num, mch_id, wishing, act_id);
            string stringSignTemp = stringA + "&key=aaaaaaaa134998651349986513499865";
            string sign = md5(stringSignTemp).ToUpper();
            string temp = "<xml><act_id>" + act_id + "</act_id><act_name>" + act_name + "</act_name><client_ip>" + clientIp + "</client_ip><max_value>" + max_value + "</max_value><mch_billno>" + mch_billno + "</mch_billno><mch_id>" + mch_id + "</mch_id><min_value>" + min_value + "</min_value><nick_name>" + nick_name + "</nick_name><nonce_str>" + nonce_str + "</nonce_str><re_openid>" + openId + "</re_openid><remark>" + remark + "</remark><send_name>" + send_name + "</send_name><total_amount>" + total_amount + "</total_amount><total_num>" + total_num + "</total_num><wishing>" + wishing + "</wishing><wxappid>" + appid + "</wxappid><sign>" + sign + "</sign></xml>";
            return PostPage("https://api.mch.weixin.qq.com/mmpaymkttransfers/sendredpack", temp);
        }
        protected string RandString()
        {
            string str = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ~!@#$%^&*()_+";//75个字符
            Random r = new Random();
            string result = string.Empty;

            //生成一个16位长的随机字符，具体长度可以自己更改
            for (int i = 0; i < 16; i++)
            {
                int m = r.Next(0, 75);//这里下界是0，随机数可以取到，上界应该是75，因为随机数取不到上界，也就是最大74，符合我们的题意
                string s = str.Substring(m, 1);
                result += s;
            }

            return result;
        }

        public string md5(string s)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.UTF8.GetBytes(s);
            byte[] md5data = md5.ComputeHash(data);
            md5.Clear();
            string str = "";
            for (int i = 0; i < md5data.Length; i++)
            {
                str += md5data[i].ToString("x").PadLeft(2, '0');
            }
            return str;
        }
       
    }
}
