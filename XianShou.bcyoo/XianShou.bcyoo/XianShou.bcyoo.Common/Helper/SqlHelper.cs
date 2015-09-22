using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace XianShou.bcyoo.Common.Helper
{
    public class SqlHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConStr());
        }
        public static SqlConnection GetLogConnection()
        {
            return new SqlConnection(GetLogConStr());
        }
        public static string GetConStr()
        {
            String str = ConfigurationManager.ConnectionStrings["xianshou"].ToString();
            string encrypt = ConfigurationManager.AppSettings["encrypt"] == null ? "" : ConfigurationManager.AppSettings["encrypt"].ToString();
            string con = "";
            if (encrypt == "0")
            {
                con = str;
            }
            else
            {
                con =SecurityHelper.DEMD5(str);
            }
            return con;
        }
        public static string GetLogConStr()
        {
            String str = ConfigurationManager.AppSettings["logconstring"].ToString();
            return str;
        }
        public static DataTable GetDataTable(string safeSql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(safeSql, GetConnection());
            DataTable DT = null;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = safeSql;
            cmd.Parameters.AddRange(values);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                cmd.Connection.Close();
                DT = ds.Tables[0];
            }
            catch (Exception e)
            {
                string s = e.Message;
                throw e;
            }
            return DT;
        }

        public static DataSet GetDataSet(string safeSql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(safeSql, GetConnection());
            
            cmd.CommandText = safeSql;
            cmd.Parameters.AddRange(values);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                cmd.Connection.Close();
            }
            catch (Exception e)
            {
                string s = e.Message;
                throw e;
            }
            return ds;
        }

        public static DataTable GetDataTable(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection conn = GetConnection();
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dt);
                conn.Close();
                sda.Dispose();
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception("数据库操作失败！" + e.Message);
            }
        }

        public static DataSet GetDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection conn = GetConnection();
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(ds);
                conn.Close();
                sda.Dispose();
                return ds;
            }
            catch (Exception e)
            {
                throw new Exception("数据库操作失败！" + e.Message);
            }
        }

        public static DataTable GetLogDataTable(String sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection conn = GetLogConnection();
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dt);
                conn.Close();
                sda.Dispose();
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception("数据库操作失败！" + e.Message);
            }
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        public static void ExecSql(String sql)
        {
            try
            {
                SqlConnection conn = GetConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("数据库操作失败！" + e.Message);
            }
        }

        /// <summary>
        /// 执行事务sql语句
        /// </summary>
        /// <param name="sql"></param>
        public static void ExecTranSql(string sql)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                SqlTransaction transaction = conn.BeginTransaction("OrderTransaction");
                command.Connection = conn;
                command.Transaction = transaction;
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                try
                {
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("数据库操作失败！" + ex.Message);
                }
            }

        }


        /// <summary>
        /// 获取单值
        /// </summary>
        /// <param name="sql"></param>
        public static string ExecuteGetScalar(string sql)
        {
            try
            {
                SqlConnection conn = GetConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                object result = cmd.ExecuteScalar();
                conn.Close();
                return result.ToString();
            }
            catch (Exception e)
            {
                throw new Exception("数据库操作失败！" + e.Message);
            }
        }



        public static int RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
            catch (Exception e)
            {
                throw new Exception("存储过程操作失败！" + e.Message);
            }
        }

        /// <summary>
        /// 构建 SqlCommand 对象(用来返回一个结果集，而不是一个整数值)
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand</returns>
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                if (parameter != null)
                {
                    // 检查未分配值的输出参数,将其分配以DBNull.Value.
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parameter);
                }
            }
            return command;
        }

        public static void ExecLogSql(String sql)
        {
            try
            {
                SqlConnection conn = new SqlConnection(GetLogConStr());
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                throw new Exception("数据库操作失败！" + e.Message);
            }
        }

        //分页datatable
        public static DataTable GetPageTable(out int pageNum, out int totalCount, PagingInfo pagingInfo)
        {
            totalCount = 0;//返回数据总个数
            pageNum = 0;
            int sortType = 2;//排序规则 1:正序asc 2:倒序desc 3:多列排序方法 如果为3 排序要加上主键排序
            if (!String.IsNullOrEmpty(pagingInfo.Order))
            {
                pagingInfo.Order += String.Format(" ,{0} desc ", pagingInfo.PrimaryKey);
                sortType = 3;
            }
            else
            {
                pagingInfo.Order = String.Format(" {0} desc ", pagingInfo.PrimaryKey);
            }
            int recorderCount = 0;//字段集合
            SqlParameter[] paras = 
            {
                new SqlParameter("@TableName",pagingInfo.TableName),
                new SqlParameter("@FieldList",pagingInfo.Fields),
                new SqlParameter("@TotalPageCount",SqlDbType.Int),
                //用来存返回值，ReturnValue随便写都可以，但类型一定是整型（因为数据库只能返回整型）
                new SqlParameter("@TotalCount",SqlDbType.Int),
                new SqlParameter("@PrimaryKey",pagingInfo.PrimaryKey),
                new SqlParameter("@Where",pagingInfo.Where),
                new SqlParameter("@Order",pagingInfo.Order),
                new SqlParameter("@SortType",sortType),
                new SqlParameter("@RecorderCount",recorderCount),
                new SqlParameter("@PageSize",pagingInfo.PageSize),
                new SqlParameter("@PageIndex",pagingInfo.PageIndex)
            };
            paras[2].Direction = ParameterDirection.InputOutput;//设置 传入并传出
            paras[2].Value = 0;
            paras[3].Direction = ParameterDirection.InputOutput;//设置 返回值
            paras[3].Value = 0;
            DataTable dt = new DataTable();

            dt = GetDataTable("P_viewPage", paras);
            if (dt != null && dt.Rows.Count > 0)
            {
                pageNum = Convert.ToInt32(paras[2].Value);
                totalCount = Convert.ToInt32(paras[3].Value);
            }
            return dt;
        }
        public static DataTable GetPageTable(out int totalCount, PagingInfo pagingInfo)
        {
            int pageNum = 0;//返回数据总个数
            DataTable dt = GetPageTable(out pageNum, out totalCount, pagingInfo);
            return dt;
        }

        //分页datatable
        public static DataTable GetLogPageTable(out int pageNum, out int totalCount, PagingInfo pagingInfo)
        {
            totalCount = 0;//返回数据总个数
            pageNum = 0;
            int sortType = 2;//排序规则 1:正序asc 2:倒序desc 3:多列排序方法 如果为3 排序要加上主键排序
            if (!String.IsNullOrEmpty(pagingInfo.Order))
            {
                pagingInfo.Order += String.Format(" ,{0} desc ", pagingInfo.PrimaryKey);
                sortType = 3;
            }
            else
            {
                pagingInfo.Order = String.Format(" {0} desc ", pagingInfo.PrimaryKey);
            }
            int recorderCount = 0;//字段集合
            SqlParameter[] paras = 
            {
                new SqlParameter("@TableName",pagingInfo.TableName),
                new SqlParameter("@FieldList",pagingInfo.Fields),
                new SqlParameter("@TotalPageCount",SqlDbType.Int),
                //用来存返回值，ReturnValue随便写都可以，但类型一定是整型（因为数据库只能返回整型）
                new SqlParameter("@TotalCount",SqlDbType.Int),
                new SqlParameter("@PrimaryKey",pagingInfo.PrimaryKey),
                new SqlParameter("@Where",pagingInfo.Where),
                new SqlParameter("@Order",pagingInfo.Order),
                new SqlParameter("@SortType",sortType),
                new SqlParameter("@RecorderCount",recorderCount),
                new SqlParameter("@PageSize",pagingInfo.PageSize),
                new SqlParameter("@PageIndex",pagingInfo.PageIndex)
            };
            paras[2].Direction = ParameterDirection.InputOutput;//设置 传入并传出
            paras[2].Value = 0;
            paras[3].Direction = ParameterDirection.InputOutput;//设置 返回值
            paras[3].Value = 0;
            DataTable dt = new DataTable();

            dt = GetLogDataTable("P_viewPage", paras);
            if (dt != null && dt.Rows.Count > 0)
            {
                pageNum = Convert.ToInt32(paras[2].Value);
                totalCount = Convert.ToInt32(paras[3].Value);
            }
            return dt;
        }

        public static DataTable GetLogPageTable(out int totalCount, PagingInfo pagingInfo)
        {
            int pageNum = 0;//返回数据总个数
            DataTable dt = GetLogPageTable(out pageNum, out totalCount, pagingInfo);
            return dt;
        }

        public static DataTable GetLogDataTable(string safeSql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(safeSql, GetLogConnection());
            DataTable DT = null;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = safeSql;
            cmd.Parameters.AddRange(values);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                cmd.Connection.Close();
                DT = ds.Tables[0];
            }
            catch (Exception e)
            {
                string s = e.Message;
                throw e;
            }
            return DT;
        }

        //固定分页HTML的json
        public static string GetTablejson(PagingInfo pagingInfo)
        {
            StringBuilder sb = new StringBuilder();
            int totalCount = 0;
            int pageNum = 0;
            DataTable dt = GetPageTable(out pageNum, out totalCount, pagingInfo);
            if (dt != null && dt.Rows.Count > 0)
            {
                string temp = "{{\"result\":\"success\",\"List\":{0},\"TotalCount\":{1},\"Pager\":\"{2}\"}}";
                sb.AppendFormat(temp, JSONHelper.DataTableToJson(dt), totalCount, GetPages(pageNum, pagingInfo.PageIndex, "GetList"));
            }
            return sb.ToString();
        }
        //不固定分页HTML的json
        public static string GetTablejson(PagingInfo pagingInfo, string functionName)
        {
            StringBuilder sb = new StringBuilder();
            int totalCount = 0;
            int pageNum = 0;
            DataTable dt = GetPageTable(out pageNum, out totalCount, pagingInfo);
            if (dt != null && dt.Rows.Count > 0)
            {
                string temp = "{{\"result\":\"success\",\"List\":{0},\"TotalCount\":{1},\"Pager\":\"{2}\"}}";
                sb.AppendFormat(temp, JSONHelper.DataTableToJson(dt), totalCount, GetPages(pageNum, pagingInfo.PageIndex, functionName));
            }
            return sb.ToString();
        }
        //不带分页的json
        public static string GetTablejson(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string temp = "{{\"result\":\"success\",\"List\":{0},\"TotalCount\":{1}}}";
                sb.AppendFormat(temp, JSONHelper.DataTableToJson(dt), dt.Rows.Count);
            }
            return sb.ToString();
        }

        //对应列有枚举数据的
        public static string GetTablejson(PagingInfo pagingInfo, String columnName, Dictionary<String, String> dicEnum)
        {
            StringBuilder sb = new StringBuilder();
            int totalCount = 0;
            int pageNum = 0;
            DataTable dt = GetPageTable(out pageNum, out totalCount, pagingInfo);
            if (dt != null && dt.Rows.Count > 0)
            {
                string temp = "{{\"result\":\"success\",\"List\":{0},\"TotalCount\":{1},\"Pager\":\"{2}\"}}";
                sb.AppendFormat(temp, JSONHelper.DataTable2Json(dt, columnName, dicEnum), totalCount, GetPages(pageNum, pagingInfo.PageIndex, "GetList"));
            }
            else
            {
                sb.Append("{\"state\":\"0\",\"info\":\"暂无记录\"}");
            }
            return sb.ToString();
        }

        //对应列有枚举数据的
        public static string GetTablejson(PagingInfo pagingInfo, String columnName, Dictionary<String, String> dicEnum,out int tbTotalCount)
        {
            StringBuilder sb = new StringBuilder();
            int totalCount = 0;
            int pageNum = 0;
            DataTable dt = GetPageTable(out pageNum, out totalCount, pagingInfo);
            if (dt != null && dt.Rows.Count > 0)
            {
                string temp = "{{\"result\":\"success\",\"List\":{0},\"TotalCount\":{1},\"Pager\":\"{2}\"}}";
                sb.AppendFormat(temp, JSONHelper.DataTable2Json(dt, columnName, dicEnum), totalCount, GetPages(pageNum, pagingInfo.PageIndex, "GetList"));
            }
            else
            {
                sb.Append("{\"state\":\"0\",\"info\":\"暂无记录\"}");
            }
            tbTotalCount = totalCount;
            return sb.ToString();
        }


        //对应列有枚举数据的
        public static string GetTablejson(PagingInfo pagingInfo, String columnName, Dictionary<String, String> dicEnum, string columnName2, Dictionary<String, String> dicEnum2)
        {
            StringBuilder sb = new StringBuilder();
            int totalCount = 0;
            int pageNum = 0;
            DataTable dt = GetPageTable(out pageNum, out totalCount, pagingInfo);
            if (dt != null && dt.Rows.Count > 0)
            {
                string temp = "{{\"result\":\"success\",\"List\":{0},\"TotalCount\":{1},\"Pager\":\"{2}\"}}";
                sb.AppendFormat(temp, JSONHelper.DataTable2Json(dt, columnName, dicEnum, columnName2, dicEnum2), totalCount, GetPages(pageNum, pagingInfo.PageIndex, "GetList"));
            }
            else
            {
                sb.Append("{\"state\":\"0\",\"info\":\"暂无记录\"}");
            }
            return sb.ToString();
        }


        //对应列需要处理的
        public static string GetTablejson(PagingInfo pagingInfo, String columnName, Func<String, String> funcResult)
        {
            StringBuilder sb = new StringBuilder();
            int totalCount = 0;
            int pageNum = 0;
            DataTable dt = GetPageTable(out pageNum, out totalCount, pagingInfo);
            if (dt != null && dt.Rows.Count > 0)
            {
                string temp = "{{\"result\":\"success\",\"List\":{0},\"TotalCount\":{1},\"Pager\":\"{2}\"}}";
                sb.AppendFormat(temp, JSONHelper.DataTable2Json(dt, columnName, funcResult), totalCount, GetPages(pageNum, pagingInfo.PageIndex, "GetList"));
            }
            else
            {
                sb.Append("{\"state\":\"0\",\"info\":\"暂无记录\"}");
            }
            return sb.ToString();
        }

        //对应列有多个枚举数据的
        public static string GetTablejson(PagingInfo pagingInfo, Dictionary<String, Dictionary<String,String>> dicEnum)
        {
            StringBuilder sb = new StringBuilder();
            int totalCount = 0;
            int pageNum = 0;
            DataTable dt = GetPageTable(out pageNum, out totalCount, pagingInfo);
            if (dt != null && dt.Rows.Count > 0)
            {
                string temp = "{{\"result\":\"success\",\"List\":{0},\"TotalCount\":{1},\"Pager\":\"{2}\"}}";
                sb.AppendFormat(temp, JSONHelper.DataTable2Json(dt, dicEnum), totalCount, GetPages(pageNum, pagingInfo.PageIndex, "GetList"));
            }
            else
            {
                sb.Append("{\"state\":\"0\",\"info\":\"暂无记录\"}");
            }
            return sb.ToString();
        }

        public static StringBuilder GetPages(int pageNum, int pageIndex, string functionName)
        {
            StringBuilder SBPage = new StringBuilder();
            if (pageNum >= 0)
            {
                #region 分页显示
                string strFirstTemp = String.Format("<span onclick='return {0}(1);'>首页</span>", functionName);//拼接url
                string strLastTemp = String.Format("<span  onclick='return {1}({0});'>尾页</span>", (pageNum).ToString(), functionName);
                string strFrontTemp = String.Format("<span class='prePager' onclick='return {1}({0});'>上一页</span>", (pageIndex - 1).ToString(), functionName);
                string strNextTemp = String.Format("<span class='nextPager' onclick='return {1}({0});'>下一页</span>", (pageIndex + 1).ToString(), functionName);
                string strCurrentTemp = "<span  class='currentPager'>{0}</span>";
                string strPageTemp = "<span  onclick='return " + functionName + "({0});' >{0}</span>";
                //若页数=1
                if (pageNum == 1)
                {
                    SBPage.Append("<span class='currentPager'>第一页</span>");
                }
                else//若页数大于1
                {
                    if (pageIndex == 1)//若当前页=1
                    {
                        SBPage.AppendFormat(strCurrentTemp, 1);
                        if (pageNum <= 10)//若总页数小于等于10
                        {
                            for (int i = 2; i <= pageNum; i++)
                            {
                                SBPage.AppendFormat(strPageTemp, i);
                            }
                        }
                        else//若总页数大于10
                        {
                            for (int i = 2; i <= 10; i++)
                            {
                                SBPage.AppendFormat(strPageTemp, i);
                            }
                            SBPage.Append(strNextTemp);
                            SBPage.Append(strLastTemp);
                        }

                    }
                    else if (pageIndex == pageNum)//若当前页等于总页数
                    {

                        if (pageNum <= 10)//若总页数小于等于10
                        {
                            for (int i = 1; i < pageNum; i++)
                            {
                                SBPage.AppendFormat(strPageTemp, i);
                            }
                        }
                        else//若总页数大于10
                        {
                            SBPage.Append(strFirstTemp);
                            SBPage.Append(strFrontTemp);
                            for (int i = (pageNum - 9); i < pageNum; i++)
                            {
                                SBPage.AppendFormat(strPageTemp, i);
                            }
                        }
                        SBPage.AppendFormat(strCurrentTemp, pageNum);

                    }
                    else//若当前页数不等于1且不等于总页数
                    {
                        if (1 < pageNum && pageNum <= 10)//若总页数大于1小于等于10
                        {

                            for (int i = 1; i <= pageNum; i++)
                            {
                                if (pageIndex == i)
                                {
                                    SBPage.AppendFormat(strCurrentTemp, i);
                                }
                                else
                                {
                                    SBPage.AppendFormat(strPageTemp, i);
                                }
                            }

                        }
                        else//若总页数大于10
                        {
                            if (1 < pageIndex && pageIndex <= 5)//若当前页数大于1且小于等于5
                            {
                                SBPage.Append(strFirstTemp);
                                SBPage.Append(strFrontTemp);
                                for (int i = 1; i <= 10; i++)
                                {
                                    if (pageIndex == i)
                                    {
                                        SBPage.AppendFormat(strCurrentTemp, i);
                                    }
                                    else
                                    {
                                        SBPage.AppendFormat(strPageTemp, i);
                                    }
                                }
                                SBPage.Append(strNextTemp);
                                SBPage.Append(strLastTemp);

                            }
                            else//若当前页数大于5
                            {
                                if (5 < pageIndex && pageIndex <= (pageNum - 5))//若当前页数大于5且小于总页数-5
                                {
                                    SBPage.Append(strFirstTemp);
                                    SBPage.Append(strFrontTemp);
                                    for (int i = (pageIndex - 4); i <= (pageIndex + 5); i++)
                                    {
                                        if (pageIndex == i)
                                        {
                                            SBPage.AppendFormat(strCurrentTemp, i);
                                        }
                                        else
                                        {
                                            SBPage.AppendFormat(strPageTemp, i);
                                        }
                                    }
                                    SBPage.Append(strNextTemp);
                                    SBPage.Append(strLastTemp);

                                }
                                else//若当前页数小于总页数-5
                                {
                                    SBPage.Append(strFirstTemp);
                                    SBPage.Append(strFrontTemp);
                                    for (int i = (pageNum - 9); i <= pageNum; i++)
                                    {
                                        if (pageIndex == i)
                                        {
                                            SBPage.AppendFormat(strCurrentTemp, i);
                                        }
                                        else
                                        {
                                            SBPage.AppendFormat(strPageTemp, i);
                                        }
                                    }
                                    SBPage.Append(strNextTemp);
                                    SBPage.Append(strLastTemp);
                                }
                            }
                        }
                    }
                }
                #endregion
            }
            return SBPage;
        }

    }
    public class PagingInfo
    {
        public string TableName { get; set; }
        public string Fields { get; set; }
        public string PrimaryKey { get; set; }
        public string Where { get; set; }
        public string Order { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
    }
}
