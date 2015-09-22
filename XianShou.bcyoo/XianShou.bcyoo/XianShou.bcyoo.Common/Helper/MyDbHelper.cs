using System;
using System.Data;
using System.Data.Common;
using System.Configuration;

public class MyDbHelper
{
    private static string dbProviderName = ConfigurationManager.AppSettings["provider"];
    private static string dbConnectionString = ConfigurationManager.AppSettings["DbHelperConnectionString"];

    private DbConnection connection;
    public MyDbHelper()
    {
        this.connection = CreateConnection(MyDbHelper.dbConnectionString);
    }
    public MyDbHelper(string connectionString)
    {
        this.connection = CreateConnection(connectionString);
    }
    public static DbConnection CreateConnection()
    {
        DbProviderFactory dbfactory = DbProviderFactories.GetFactory(MyDbHelper.dbProviderName);
        DbConnection dbconn = dbfactory.CreateConnection();
        dbconn.ConnectionString = MyDbHelper.dbConnectionString;
        return dbconn;
    }
    public static DbConnection CreateConnection(string connectionString)
    {
        DbProviderFactory dbfactory = DbProviderFactories.GetFactory(MyDbHelper.dbProviderName);
        DbConnection dbconn = dbfactory.CreateConnection();
        dbconn.ConnectionString = connectionString;
        return dbconn;
    }

    public DbCommand GetStoredProcCommond(string storedProcedure)
    {
        DbCommand dbCommand = connection.CreateCommand();
        dbCommand.CommandText = storedProcedure;
        dbCommand.CommandType = CommandType.StoredProcedure;
        return dbCommand;
    }
    public DbCommand GetSqlStringCommond(string sqlQuery)
    {
        DbCommand dbCommand = connection.CreateCommand();
        dbCommand.CommandText = sqlQuery;
        dbCommand.CommandType = CommandType.Text;
        return dbCommand;
    }


    #region 执行
    public DataSet ExecuteDataSet(DbCommand cmd)
    {
        DbProviderFactory dbfactory = DbProviderFactories.GetFactory(MyDbHelper.dbProviderName);
        DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
        dbDataAdapter.SelectCommand = cmd;
        DataSet ds = new DataSet();
        dbDataAdapter.Fill(ds);
        return ds;
    }

    public DataTable ExecuteDataTable(DbCommand cmd)
    {
        DbProviderFactory dbfactory = DbProviderFactories.GetFactory(MyDbHelper.dbProviderName);
        DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
        dbDataAdapter.SelectCommand = cmd;
        DataTable dataTable = new DataTable();
        dbDataAdapter.Fill(dataTable);
        return dataTable;
    }

    public DbDataReader ExecuteReader(DbCommand cmd)
    {
        cmd.Connection.Open();
        DbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        return reader;
    }
    public int ExecuteNonQuery(DbCommand cmd)
    {
        cmd.Connection.Open();
        int ret = cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        return ret;
    }

    public object ExecuteScalar(DbCommand cmd)
    {
        cmd.Connection.Open();
        object ret = cmd.ExecuteScalar();
        cmd.Connection.Close();
        return ret;
    }
    #endregion

    #region 执行事务
    public DataSet ExecuteDataSet(DbCommand cmd, Trans t)
    {
        cmd.Connection = t.DbConnection;
        cmd.Transaction = t.DbTrans;
        DbProviderFactory dbfactory = DbProviderFactories.GetFactory(MyDbHelper.dbProviderName);
        DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
        dbDataAdapter.SelectCommand = cmd;
        DataSet ds = new DataSet();
        dbDataAdapter.Fill(ds);
        return ds;
    }

    public DataTable ExecuteDataTable(DbCommand cmd, Trans t)
    {
        cmd.Connection = t.DbConnection;
        cmd.Transaction = t.DbTrans;
        DbProviderFactory dbfactory = DbProviderFactories.GetFactory(MyDbHelper.dbProviderName);
        DbDataAdapter dbDataAdapter = dbfactory.CreateDataAdapter();
        dbDataAdapter.SelectCommand = cmd;
        DataTable dataTable = new DataTable();
        dbDataAdapter.Fill(dataTable);
        return dataTable;
    }

    public DbDataReader ExecuteReader(DbCommand cmd, Trans t)
    {
        cmd.Connection.Close();
        cmd.Connection = t.DbConnection;
        cmd.Transaction = t.DbTrans;
        DbDataReader reader = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        return reader;
    }
    public int ExecuteNonQuery(DbCommand cmd, Trans t)
    {
        cmd.Connection.Close();
        cmd.Connection = t.DbConnection;
        cmd.Transaction = t.DbTrans;
        int ret = cmd.ExecuteNonQuery();
        return ret;
    }

    public object ExecuteScalar(DbCommand cmd, Trans t)
    {
        cmd.Connection.Close();
        cmd.Connection = t.DbConnection;
        cmd.Transaction = t.DbTrans;
        object ret = cmd.ExecuteScalar();
        return ret;
    }
    #endregion
}

public class Trans : IDisposable
{
    private DbConnection conn;
    private DbTransaction dbTrans;
    public DbConnection DbConnection
    {
        get { return this.conn; }
    }
    public DbTransaction DbTrans
    {
        get { return this.dbTrans; }
    }

    public Trans()
    {
        conn = MyDbHelper.CreateConnection();
        conn.Open();
        dbTrans = conn.BeginTransaction();
    }
    public Trans(string connectionString)
    {
        conn = MyDbHelper.CreateConnection(connectionString);
        conn.Open();
        dbTrans = conn.BeginTransaction();
    }
    public void Commit()
    {
        dbTrans.Commit();
        this.Colse();
    }

    public void RollBack()
    {
        dbTrans.Rollback();
        this.Colse();
    }

    public void Dispose()
    {
        this.Colse();
    }

    public void Colse()
    {
        if (conn.State == System.Data.ConnectionState.Open)
        {
            conn.Close();
        }
    }
}