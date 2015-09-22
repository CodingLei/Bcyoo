using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Collections.Specialized;

namespace XianShou.bcyoo.Common.Helper
{
    public static class DataGridParamHelper
    {
        public static DataGridParam GetDataGridParam(NameValueCollection postValueCollection)
        {
            var paramValues = new DataGridParam();
            string a = postValueCollection["Page"].ToString();
            paramValues.Page=Convert.ToInt32(postValueCollection["Page"].ToString());
            paramValues.RP = Convert.ToInt32(postValueCollection["RP"]);
            paramValues.SortName = postValueCollection["SortName"];
            paramValues.SortOrder = postValueCollection["SortOrder"];
            return paramValues;
        }
    }
}
