
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Web.Script.Serialization;
using System;
using System.Text.RegularExpressions;

namespace XianShou.bcyoo.Common.Helper
{
    public static class JSONHelper
    {
        /// <summary>
        /// 对象转为JSON格式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string ToJson<T>(T t)
        {
            return new JavaScriptSerializer().Serialize(t);
        }

        /// <summary>
        /// JSON格式转换为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static T FromJson<T>(string str)
        {
            return new JavaScriptSerializer().Deserialize<T>(str);
        }
        /// <summary>
        /// 将json转换为DataTable
        /// </summary>
        /// <param name="strJson">得到的json</param>
        /// <returns></returns>
        public static DataTable JsonToDataTable(string strJson)
        {
            //转换json格式
            strJson = strJson.Replace(",\"", "~\"").Replace("\":", "\"#").ToString();
            //取出表名   
            var rg = new Regex(@"(?<={)[^:]+(?=:\[)", RegexOptions.IgnoreCase);
            string strName = rg.Match(strJson).Value;
            DataTable tb = null;
            //去除表名   
            strJson = strJson.Substring(strJson.IndexOf("[") + 1);
            strJson = strJson.Substring(0, strJson.IndexOf("]"));

            //获取数据   
            rg = new Regex(@"(?<={)[^}]+(?=})");
            MatchCollection mc = rg.Matches(strJson);
            for (int i = 0; i < mc.Count; i++)
            {
                string strRow = mc[i].Value;
                string[] strRows = strRow.Split('~');

                //创建表   
                if (tb == null)
                {
                    tb = new DataTable();
                    tb.TableName = strName;
                    foreach (string str in strRows)
                    {
                        var dc = new DataColumn();
                        string[] strCell = str.Split('#');

                        if (strCell[0].Substring(0, 1) == "\"")
                        {
                            int a = strCell[0].Length;
                            dc.ColumnName = strCell[0].Substring(1, a - 2);
                        }
                        else
                        {
                            dc.ColumnName = strCell[0];
                        }
                        tb.Columns.Add(dc);
                    }
                    tb.AcceptChanges();
                }

                //增加内容   
                DataRow dr = tb.NewRow();
                for (int r = 0; r < strRows.Length; r++)
                {
                    dr[r] = strRows[r].Split('#')[1].Trim().Replace("，", ",").Replace("：", ":").Replace("\"", "");
                }
                tb.Rows.Add(dr);
                tb.AcceptChanges();
            }

            return tb;
        }
       
        /// <summary>
        /// 格式化EASYUI DATAGRID JSON
        /// </summary>
        /// <param name="recordcount">总记录数</param>
        /// <param name="rows">每页记录的JSON格式</param>
        /// <returns></returns>
        public static string FormatJSONForEasyuiDataGrid(int recordcount, object rowsList)
        {
            return ToJson(new { total = recordcount, rows = rowsList });
        }

        /// <summary>
        /// 获取树格式对象
        /// </summary>
        /// <param name="list">线性数据</param>
        /// <param name="id">ID的字段名</param>
        /// <param name="pid">PID的字段名</param>
        /// <returns></returns>
        public static object ArrayToTreeData(IList<Hashtable> list, string id, string pid)
        {
            var h = new Hashtable(); //数据索引 
            var r = new List<Hashtable>(); //数据池,要返回的 
            foreach (var item in list)
            {
                if (!item.ContainsKey(id)) continue;
                h[item[id].ToString()] = item;
            }
            foreach (var item in list)
            {
                if (!item.ContainsKey(id)) continue;
                if (!item.ContainsKey(pid) || item[pid] == null || !h.ContainsKey(item[pid].ToString()))
                {
                    r.Add(item);
                }
                else
                {
                    var pitem = h[item[pid].ToString()] as Hashtable;
                    if (!pitem.ContainsKey("children"))
                        pitem["children"] = new List<Hashtable>();
                    var children = pitem["children"] as List<Hashtable>;
                    children.Add(item);
                }
            }
            return r;
        }

        /// <summary>
        /// 获取树格式对象
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <param name="id">ID的字段名</param>
        /// <param name="pid">pid的字段名</param>
        /// <returns></returns>
        public static object DataTableToTreeData(DataTable dt, string id, string pid)
        {
            IList<Hashtable> list = DbTableToHash(dt);

            return ArrayToTreeData(list, id, pid);

        }


        public static string DataTableToTreeDataString(DataTable dt, string id, string pid)
        {
            return new JavaScriptSerializer().Serialize(DataTableToTreeData(dt, id, pid));
        }

        /// <summary>
        /// 将db reader转换为Hashtable列表
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static IList<Hashtable> DbReaderToHash(IDataReader reader)
        {
            using (reader)
            {
                var list = new List<Hashtable>();
                while (reader.Read())
                {
                    var item = new Hashtable();

                    for (var i = 0; i < reader.FieldCount; i++)
                    {
                        var name = reader.GetName(i);
                        var value = reader[i];
                        item[name] = value;
                    }
                    list.Add(item);
                }
                return list;
            }
        }

        /// <summary>
        /// 将DataTable转换为Hashtable列表
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static IList<Hashtable> DbTableToHash(DataTable dt)
        {
            IList<Hashtable> list = new List<Hashtable>();



            foreach (DataRow row in dt.Rows)
            {
                Hashtable item = new Hashtable();

                for (int i = 0, len = dt.Columns.Count; i < len; i++)
                {
                    item[dt.Columns[i].ColumnName] = row[i];
                }
                list.Add(item);

            }

            return list;
        }

        /// <summary>
        /// 把DataTable表中的数据转换为JSON格式数据
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTableToJson(DataTable dt)
        {
            IList<Hashtable> list = DbTableToHash(dt);

            return ToJson<IList<Hashtable>>(list);
        }

        /// <summary>
        /// DataTable转为JSON格式，通过拼接字符串方法
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTable2Json(DataTable dt)
        {
            if (dt.Rows.Count < 1)
                return "";
            StringBuilder sb = new StringBuilder("[");

            int iCols = dt.Columns.Count;

            //表字段存放的数组
            string[] aColName = new string[iCols];
            for (int i = 0; i < iCols; i++)
                aColName[i] = dt.Columns[i].ColumnName;

            foreach (DataRow row in dt.Rows)
            {
                sb.Append("{");

                for (int i = 0; i < iCols - 1; i++)
                {
                    sb.AppendFormat("\"{0}\":\"{1}\",", aColName[i], row[i].ToString());
                }
                sb.AppendFormat("\"{0}\":\"{1}\"", aColName[iCols - 1], row[iCols - 1].ToString());

                sb.Append("},");
            }
            return sb.ToString().TrimEnd(',') + "]";
        }
        /// <summary>
        /// DataTable转为JSON格式，处理枚举字段
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTable2Json(DataTable dt, String columnName, Dictionary<String, String> dicEnum)
        {
            if (dt.Rows.Count < 1)
                return "";
            StringBuilder sb = new StringBuilder("[");

            int iCols = dt.Columns.Count;

            //表字段存放的数组
            string[] aColName = new string[iCols];
            for (int i = 0; i < iCols; i++)
                aColName[i] = dt.Columns[i].ColumnName;

            foreach (DataRow row in dt.Rows)
            {
                sb.Append("{");
                string text = string.Empty;
                for (int i = 0; i < iCols; i++)
                {
                    sb.AppendFormat("\"{0}\":\"{1}\",", aColName[i], row[aColName[i]].ToString());
                }
                string extendText = string.Empty;
                if (dicEnum.ContainsKey(row[columnName].ToString()))
                {
                    extendText = dicEnum[row[columnName].ToString()].ToString();
                }
                sb.AppendFormat("\"{0}val\":\"{1}\"", columnName, extendText);
                sb.Append("},");
            }
            return sb.ToString().TrimEnd(',') + "]";
        }

        /// <summary>
        /// DataTable转为JSON格式，处理2个枚举字段
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTable2Json(DataTable dt, String columnName, Dictionary<String, String> dicEnum, string columnName2, Dictionary<String, String> dicEnum2)
        {
            if (dt.Rows.Count < 1)
                return "";
            StringBuilder sb = new StringBuilder("[");

            int iCols = dt.Columns.Count;

            //表字段存放的数组
            string[] aColName = new string[iCols];
            for (int i = 0; i < iCols; i++)
                aColName[i] = dt.Columns[i].ColumnName;

            foreach (DataRow row in dt.Rows)
            {
                sb.Append("{");
                string text = string.Empty;
                for (int i = 0; i < iCols; i++)
                {
                    sb.AppendFormat("\"{0}\":\"{1}\",", aColName[i], row[aColName[i]].ToString());
                }
                string extendText = string.Empty;
                if (dicEnum.ContainsKey(row[columnName].ToString()))
                {
                    extendText = dicEnum[row[columnName].ToString()].ToString();
                }
                sb.AppendFormat("\"{0}val\":\"{1}\",", columnName, extendText);

                string extendText2 = string.Empty;
                if (dicEnum2.ContainsKey(row[columnName2].ToString()))
                {
                    extendText2 = dicEnum2[row[columnName2].ToString()].ToString();
                }
                sb.AppendFormat("\"{0}val\":\"{1}\"", columnName2, extendText2);
                sb.Append("},");
            }
            return sb.ToString().TrimEnd(',') + "]";
        }

        /// <summary>
        /// DataTable转为JSON格式，处理2个枚举字段
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTable2Json(DataTable dt, Dictionary<String, Dictionary<String,String>> dicEnum)
        {
            if (dt.Rows.Count < 1)
                return "";
            StringBuilder sb = new StringBuilder("[");

            int iCols = dt.Columns.Count;

            //表字段存放的数组
            string[] aColName = new string[iCols];
            for (int i = 0; i < iCols; i++)
                aColName[i] = dt.Columns[i].ColumnName;

            foreach (DataRow row in dt.Rows)
            {
                sb.Append("{");
                string text = string.Empty;
                for (int i = 0; i < iCols; i++)
                {
                    sb.AppendFormat("\"{0}\":\"{1}\",", aColName[i], row[aColName[i]].ToString());
                    if (dicEnum.ContainsKey(aColName[i]))
                    {
                        if (dicEnum[aColName[i]].ContainsKey(row[aColName[i]].ToString()))
                        {
                            sb.AppendFormat("\"{0}val\":\"{1}\",", aColName[i], dicEnum[aColName[i]][row[aColName[i]].ToString()]);
                        }
                        else
                        {
                            sb.AppendFormat("\"{0}val\":\"{1}\",", aColName[i], "暂无数据");
                        }
                    }
                }
                sb.Append("},");
            }
            return sb.ToString().TrimEnd(',') + "]";
        }




        /// <summary>
        /// DataTable转为JSON格式，处理某个字段
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTable2Json(DataTable dt, String columnName, Func<String, String> funcResult)
        {
            if (dt.Rows.Count < 1)
                return "";
            StringBuilder sb = new StringBuilder("[");

            int iCols = dt.Columns.Count;

            //表字段存放的数组
            string[] aColName = new string[iCols];
            for (int i = 0; i < iCols; i++)
                aColName[i] = dt.Columns[i].ColumnName;

            foreach (DataRow row in dt.Rows)
            {
                sb.Append("{");
                string text = string.Empty;
                for (int i = 0; i < iCols; i++)
                {
                    sb.AppendFormat("\"{0}\":\"{1}\",", aColName[i], row[aColName[i]].ToString());
                }
                string extendText = string.Empty;
                extendText = funcResult(row[columnName].ToString());
                sb.AppendFormat("\"{0}val\":\"{1}\"", columnName, extendText);
                sb.Append("},");
            }
            return sb.ToString().TrimEnd(',') + "]";
        }
   
        /// <summary>
        /// 返回EasyUI中DataGrid格式数据
        /// </summary>
        /// <param name="total"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ToDataGrid(int total, string data)
        {
            return null;
        }

        /// <summary>
        /// 将 JqueryGridObject转化为json
        /// </summary>
        /// <param name="jgObject"></param>
        /// <returns></returns>
        public static string JqueryGridObjectToJson(JqueryGridObject jgObject)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(jgObject);
        }

        /// <summary>
        /// 将object类型转化为json
        /// </summary>
        /// <param name="Obj"></param>
        /// <returns></returns>
        public static string ObjectToJson(object Obj)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(Obj);
        }

    }
}
