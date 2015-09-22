using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace XianShou.bcyoo.Common.Helper
{
    public class TokenHelper
    {
        public static string GetTokenKey()
        {
            try
            {
                string strUrl = CommonHelper.GetAppSettings("GetTokenUrl");
                HttpWebRequest wrequest = (HttpWebRequest)WebRequest.Create(strUrl);
                wrequest.UseDefaultCredentials = false;
                WebResponse response = wrequest.GetResponse();
                Stream resStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(resStream, System.Text.Encoding.Default);
                string strTokenKey = sr.ReadToEnd();
                resStream.Close();
                return strTokenKey;
            }
            catch (Exception ex)
            {
                //todo
                return "";
            }
        }
    }
}
