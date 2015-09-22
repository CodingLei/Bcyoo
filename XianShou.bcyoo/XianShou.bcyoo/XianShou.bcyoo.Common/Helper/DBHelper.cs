using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack.OrmLite;

namespace XianShou.bcyoo.Common.Helper
{
    public class DBHelper
    {
        private static SqlConnection connection;

        private static string connectionString;

        private static SqlConnection Connection
        {
            get
            {
                connectionString = GetCon(ConfigurationManager.ConnectionStrings["xianshou"].ToString());// @"server=192.168.1.242\lz;uid=sa;pwd=111111;database=LZinfo20110517Info";

                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);
                }
                if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
                {
                    connection.Open();
                }
                return connection;
            }
        }
        public static string GetCon(string str)
        {
            string encrypt = ConfigurationManager.AppSettings["encrypt"] == null ? "" : ConfigurationManager.AppSettings["encrypt"].ToString();
            string con = "";
            if (encrypt == "0")
            {
                con = str;
            }
            else
            {
                con = SecurityHelper.DEMD5(str);
            }
            return con;
        }
        public static int ExecuteCommand(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = safeSql;
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }

        public static int ExecuteSqlText(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = safeSql;
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }

        public static int ExecuteCommand(string safeSql, params SqlParameter[] values)
        {

            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = safeSql;
            cmd.Parameters.AddRange(values);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }

        public static object GetScalar(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = safeSql;
            cmd.Connection.Close();
            return cmd.ExecuteScalar();
        }

        public static object GetScalar(string safeSql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = safeSql;
            cmd.Parameters.AddRange(values);
            cmd.Connection.Close();
            return cmd.ExecuteScalar();
        }

        public static SqlDataReader GetReader(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = safeSql;
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            cmd.Connection.Close();
            return reader;
        }

        public static SqlDataReader GetReader(string safeSql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = safeSql;
            cmd.Parameters.AddRange(values);
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            cmd.Connection.Close();
            return reader;
        }

        public static DataSet GetDataSet(string safeSql)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = safeSql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection.Close();
            da.Fill(ds);
            return ds;
        }

        public static DataTable GetDataTable(string safeSql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = safeSql;
            cmd.Parameters.AddRange(values);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.Connection.Close();
            return ds.Tables[0];
        }
        public static DataTable GetDataTable(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = safeSql;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.Connection.Close();
            return ds.Tables[0];
        }

        public static DataSet GetDataSet(string safeSql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = safeSql;
            cmd.Parameters.AddRange(values);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.Connection.Close();
            return ds;
        }

        //返回一个数据表
        public static DataSet Getcommodityiscomid(string sql)
        {
            SqlCommand cmd = new SqlCommand("select * from commodity where commodityid in (" + sql + ")", Connection);
            string s = cmd.CommandText;
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet das = new DataSet();
            dr.Fill(das);
            cmd.Connection.Close();
            return das;
        }


        //public static List<AddressEntity> GetAddressList(int ParentID)
        //{
        //    List<AddressEntity> list = new List<AddressEntity>();
        //    DataTable dt = GetDataTable("select * from web_area where ParentID = " + ParentID);
        //    if (dt != null)
        //    {
        //        if (dt.Rows.Count > 0)
        //        {
        //            int i = 0;
        //            while (i < dt.Rows.Count)
        //            {
        //                AddressEntity entity = new AddressEntity();
        //                entity.Id = int.Parse(dt.Rows[i]["ID"].ToString());
        //                entity.AddrName = dt.Rows[i]["Name"].ToString();
        //                list.Add(entity);
        //                i++;
        //            }
        //        }
        //    }

        //    return list;
        //}


        public static IDbConnection Db
        {
            get { return new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["xianshou"].ConnectionString, new ServiceStack.OrmLite.SqlServer.SqlServerOrmLiteDialectProvider()).Open(); }
        }

    }
}


 