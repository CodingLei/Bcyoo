using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Reflection;
using System.Data;

namespace XianShou.bcyoo.Common.Helper
{
    [DataContract]
    public class JqueryGridRow
    {
     
        [DataMember]
        public Dictionary<string, string> cc = new Dictionary<string, string>();
        [OperationContract]
        public static List<string> GetPropertyList(object obj, int MySeq)
        {
            List<string> propertyList = new List<string>();
            Dictionary<string, string> propertyName = new Dictionary<string, string>();
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (PropertyInfo property in properties)
            {
                object o = property.GetValue(obj, null);
                if (!string.IsNullOrEmpty(property.Name) && o != null)
                {
                    propertyName.Add(property.Name, o.ToString());
                }
            }
         
            return propertyList;
        }
    }
    /// <summary>
    /// 将数据转换成Flaxigrid认识格式
    /// </summary>
    [DataContract]
    public class JqueryGridObject
    {
       
        public DataGridParam DataGridParam { get; set; }
        [DataMember]
        public List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
        [DataMember]
        public int page = 1;
        [DataMember]
        public int total { get; set; }
        [DataMember]
        public List<Dictionary<string,string>> footer=new List<Dictionary<string, string>>();
        
        /// <summary>
        /// 数据源
        /// </summary>
        /// 
 
        [DataMember]
        public IEnumerable<dynamic> Query
        {
            set
            {
                if (value != null)
                {
                    int MySeq = 1;
                    page = DataGridParam.Page;
                    if (page > 1)
                    {
                        MySeq = (page - 1) * DataGridParam.RP + 1;
                    }

                    foreach (dynamic item in value)
                    {
                        Dictionary<string, string> row = new Dictionary<string, string>();
                        row = this.GetPropertyList(item, MySeq);
                        rows.Add(row);
                        MySeq++;
                    }
                }
            }
        }

        [DataMember]
        public DataTable QueryDataTable
        {
            set
            {
                if (value != null)
                {
                    int MySeq = 1;
                    page = DataGridParam.Page;
                    if (page > 1)
                    {
                        MySeq = (page - 1) * DataGridParam.RP + 1;
                    }

                    foreach (DataRow item in value.Rows)
                    {

                        Dictionary<string, string> row = new Dictionary<string, string>();
                        for (int i = 0; i < value.Columns.Count; i++)
                        {
                            row.Add(value.Columns[i].Caption, item[i].ToString());
                        }
                        rows.Add(row);
                        MySeq++;
                    }
                }
            }
        }

        [OperationContract]
        public  Dictionary<string, string> GetPropertyList(object obj, int MySeq)
        {
           // List<string> propertyList = new List<string>();
            Dictionary<string, string> propertyName = new Dictionary<string, string>();
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (PropertyInfo property in properties)
            {
                    object o = property.GetValue(obj, null);
                    if (!string.IsNullOrEmpty(property.Name) && o != null)
                    {
                        propertyName.Add(property.Name, o.ToString());
                    }
            }

            return propertyName;
        }

    }

    [DataContract]
    public class JqueryGridTreeObject
    {

        public DataGridParam DataGridParam { get; set; }
        [DataMember]
        public List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
        [DataMember]
        public int page = 1;
        [DataMember]
        public int total { get; set; }



        /// <summary>
        /// 数据源
        /// </summary>
        /// 

        [DataMember]
        public IEnumerable<dynamic> Query
        {
            set
            {
                if (value != null)
                {
                    int MySeq = 1;
                    page = DataGridParam.Page;
                    if (page > 1)
                    {
                        MySeq = (page - 1) * DataGridParam.RP + 1;
                    }

                    foreach (dynamic item in value)
                    {

                        Dictionary<string, string> row = new Dictionary<string, string>();
                        row = this.GetPropertyList(item, MySeq);
                        rows.Add(row);
                        MySeq++;
                    }
                }
            }
        }




        [OperationContract]
        public Dictionary<string, string> GetPropertyList(object obj, int MySeq)
        {
            // List<string> propertyList = new List<string>();
            Dictionary<string, string> propertyName = new Dictionary<string, string>();
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (PropertyInfo property in properties)
            {
                // string proStr = property.GetString();
                // if(proStr.Contains("jiuweiCRM.DBLinq"))
                // {

                // }
                //if (property.GetString().Contains("SysContact"))
                //{
                object o = property.GetValue(obj, null);
                if (!string.IsNullOrEmpty(property.Name) && o != null)
                {
                    propertyName.Add(property.Name, o.ToString());
                }
                // }
            }

            return propertyName;
        }

    }
    /// <summary>
    ///  flexigrid与后台传输的对象
    /// </summary>
    [DataContract]
    public class DataGridParam
    {
        /*  js中 参数使用
         var param = [
					 { name : 'page', value : p.newp }
					,{ name : 'rp', value : p.rp }
					,{ name : 'sortname', value : p.sortname}
					,{ name : 'sortorder', value : p.sortorder }
					,{ name : 'query', value : p.query}
					,{ name : 'qtype', value : p.qtype}
				];							 
         */
        [DataMember]
        public int Page { get; set; }
        [DataMember]
        public int RP { get; set; }
        [DataMember]
        public string SortName { get; set; }
        [DataMember]
        public string SortOrder { get; set; }
        [DataMember]
        public string Query { get; set; }
        [DataMember]
        public string QType { get; set; }
        [DataMember]
        public string Cols { get; set; }
      
       
    }
}
