
using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using XianShou.bcyoo.Common.Helper;
using System.Data.SqlClient;

namespace XianShou.bcyoo.Admin.DataAccess
{
    /// <summary>
    /// 页面查询
    /// </summary>
    public class PageSplitQuery
    {
        /// <summary>
        /// 获取分页查询SQL语句[只支持SQLServer2005或SQLServer2008]
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="keyField">主键字段</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="joinOn">连接查询语句</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderFields">排序</param>
        /// <param name="pageSize">每页查询数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回分页查询SQL语句</returns>
        public static string GetPageSplitSql2005(string tableName, string keyField, string showFields, string joinOn, string where, string orderFields, int pageSize, int pageIndex)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = start + pageSize - 1;
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM (SELECT ROW_NUMBER() OVER (");
            if (string.IsNullOrEmpty(orderFields))
            {
                sql.Append(" order by ");
                sql.Append(tableName + "." + keyField);
            }
            else
            {
                sql.Append(orderFields);
            }
            sql.Append(") AS rowNumber,");
            sql.Append(showFields);
            sql.Append(" from ");
            sql.Append(tableName);
            sql.Append(" with(nolock) ");
            if (!string.IsNullOrEmpty(joinOn))
            {
                sql.Append(joinOn);
            }
            if (!string.IsNullOrEmpty(where))
            {
                sql.Append(" where ");
            }
            sql.Append(where);
            sql.Append(") AS sp WHERE rowNumber BETWEEN ");
            sql.Append(start.ToString());
            sql.Append(" AND ");
            sql.Append(end.ToString());
            return sql.ToString();
        }
        /// <summary>
        /// 获取分页查询SQL语句[只支持SQLServer2000]
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="keyField">主键字段</param>
        /// <param name="showFields">显示字段</param>
        /// <param name="joinOn">连接查询语句</param>
        /// <param name="where">查询条件</param>
        /// <param name="orderFields">排序</param>
        /// <param name="pageSize">每页查询数量</param>
        /// <param name="pageIndex">页面索引</param>
        /// <returns>返回分页查询SQL语句</returns>
        public static string GetPageSplitSql2000(string tableName, string keyField, string showFields, string joinOn, string where, string orderFields, int pageSize, int pageIndex)
        {
            StringBuilder sql = new StringBuilder();
            if (pageIndex == 1)
            {
                sql.Append("select top ");
                sql.Append(pageSize);
                sql.Append(" ");
                sql.Append(showFields);
                sql.Append(" from ");
                sql.Append(tableName);
                sql.Append(" with(nolock) ");
                sql.Append(joinOn);
                if (!string.IsNullOrEmpty(where))
                {
                    sql.Append(" where ");
                }
                sql.Append(where);
                sql.Append(orderFields);
            }
            else
            {
                int start = (pageIndex - 1) * pageSize + 1;
                int end = start + pageSize - 1;
                sql.Append("declare @temp table(rowNumber int PRIMARY KEY IDENTITY(1,1) ,keyId int)");
                sql.Append("insert into @temp (keyId) ");
                sql.Append("select top ");
                sql.Append(end);
                sql.Append(" ");
                sql.Append(tableName + "." + keyField);
                sql.Append(" from ");
                sql.Append(tableName);
                sql.Append(" with(nolock) ");
                sql.Append(joinOn);
                if (!string.IsNullOrEmpty(where))
                {
                    sql.Append(" where ");
                }
                sql.Append(where);
                if (string.IsNullOrEmpty(orderFields))
                {
                    sql.Append(" order by ");
                    sql.Append(tableName + "." + keyField);
                }
                else
                {
                    sql.Append(orderFields);
                }
                sql.AppendLine(" select * from @temp as t inner join (");
                sql.Append(" select top ");
                sql.Append(end);
                sql.Append(" ");
                sql.Append(showFields);
                sql.Append(" from ");
                sql.Append(tableName);
                sql.Append(" with(nolock) ");
                sql.Append(joinOn);
                if (!string.IsNullOrEmpty(where))
                {
                    sql.Append(" where ");
                }
                sql.Append(where);
                if (string.IsNullOrEmpty(orderFields))
                {
                    sql.Append(" order by ");
                    sql.Append(tableName + "." + keyField);
                }
                else
                {
                    sql.Append(orderFields);
                }
                sql.Append(") as z on t.keyId=z." + keyField);
                sql.Append(" where t.rowNumber BETWEEN  ");
                sql.Append(start.ToString());
                sql.Append(" AND ");
                sql.Append(end.ToString());
            }
            return sql.ToString();
        }

        /// <summary>
        /// 通用高效分页
        /// </summary>
        /// <param name="conditionSql">条件sql</param>
        /// <param name="querySql">查询结果sql,需要与虚拟表@indexTabel-别名it 进行关联</param>
        /// <param name="dicParam">虚拟表临时变量,参数1-临时变量名，参数2-临时变量类型</param>
        /// <param name="currPage">当前页</param>
        /// <param name="perCount">每页记录数</param>
        /// <param name="nCount">总页数</param>
        /// <param name="collection">传入参数</param>
        /// <returns>返回查询数据</returns>
        public static DataTable GeneralHighPerformancePager(
            string conditionSql,
            string querySql,
            IDictionary<string, string> dicParam,
            int currPage,
            int perCount,
            ref int nCount,
            SqlParameter[] collection = null)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("DECLARE @indexTabel TABLE(Nid int IDENTITY(1,1) PRIMARY KEY");
            if (dicParam == null || dicParam.Keys.Count == 0)
            {
                return null;
            }
            foreach (string key in dicParam.Keys)
            {
                strSql.AppendFormat(",{0} {1}", key, dicParam[key]);
            }
            strSql.Append(")");
            strSql.Append("INSERT INTO @indexTabel ");
            strSql.AppendFormat("{0}", conditionSql);
            strSql.Append("SELECT @@ROWCOUNT;");
            strSql.AppendFormat("{0}", querySql);
            strSql.AppendFormat(" WHERE  it.Nid>{0} AND  it.Nid< {1} order by it.Nid", (currPage - 1) * perCount, currPage * perCount + 1);

            DataSet ds = collection == null ? SqlHelper.GetDataSet(strSql.ToString()) : SqlHelper.GetDataSet(strSql.ToString(), collection);

            DataTable dtCount = ds.Tables[0];
            DataTable dt = ds.Tables[1];
            nCount = (int)dtCount.Rows[0][0];
            return dt;

        }

        /// <summary>
        /// 分页方法
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="db"></param>
        /// <param name="conditionSql">临时表查询sql</param>
        /// <param name="querySql">数据查询sql</param>
        /// <param name="dicParam">临时表字段</param>
        /// <param name="skip">起始条数</param>
        /// <param name="take">获取条数</param>
        /// <param name="nCount">总条数</param>
        /// <returns></returns>
        public static List<T> PageHelper<T>(IDbConnection db, string conditionSql, string querySql, IDictionary<string, string> dicParam, int currPage, int perCount, ref int nCount) where T : new()
        {
            List<T> list = new List<T>();
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat("DECLARE @indexTabel TABLE(Nid int IDENTITY(1,1) PRIMARY KEY");
            if (dicParam == null || dicParam.Keys.Count == 0)
            {
                return null;
            }
            foreach (string key in dicParam.Keys)
            {
                strSql.AppendFormat(",{0} {1}", key, dicParam[key]);
            }
            strSql.Append(")");
            strSql.Append("INSERT INTO @indexTabel ");
            strSql.AppendFormat("{0}", conditionSql);
            strSql.Append(" SELECT @@ROWCOUNT as Total ;");
            strSql.AppendFormat("{0}", querySql);
            strSql.AppendFormat(" WHERE  it.Nid>{0} AND  it.Nid< ={1} order by it.Nid", (currPage - 1) * perCount, currPage * perCount + 1);

            using (SqlConnection con = new SqlConnection(db.ConnectionString))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(strSql.ToString(), con);
                da.Fill(ds);
                //list = ModelHelper<T>.FillModel(ds.Tables[1]);
                list = EntityUtil.ToList<T>(ds.Tables[1]);
                nCount = (int)ds.Tables[0].Rows[0][0];
            }
            return list;
        }

    }
}
