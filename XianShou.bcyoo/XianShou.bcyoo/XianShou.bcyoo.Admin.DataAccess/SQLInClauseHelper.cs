using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace XianShou.bcyoo.Admin.DataAccess
{
    public class SQLInClauseHelper
    {
        /// <summary>
        /// 轻量级查询
        /// 适用于查询频率高，数据量少的情况
        /// </summary>
        /// <param name="values"></param>
        /// <param name="dbType"></param>
        /// <param name="collection"></param>
        /// <param name="sqlParameterName"></param>
        /// <returns></returns>
        public static string SQLInLightWeightHelper(string values, SqlDbType dbType, List<SqlParameter> collection, string sqlParameterName = null)
        {
            string sqlTemp = string.Empty;
            if (!string.IsNullOrWhiteSpace(values))
            {
                List<string> value = values.TrimEnd(',').Split(',').ToList();
                if (value != null && value.Count > 0)
                {
                    sqlTemp = "(";
                    int index = 0;
                    char[] charsToTrim = { ' ', '\'' };
                    foreach (var item in value)
                    {
                        index++;
                        string variable = "@" + (string.IsNullOrWhiteSpace(sqlParameterName) ? item.Trim(charsToTrim) : sqlParameterName) + "_" + index.ToString();
                        if (index == value.Count)
                        {
                            sqlTemp += variable;
                        }
                        else
                        {
                            sqlTemp += variable + ",";
                        }
                        collection.Add(new SqlParameter(variable, item.Trim(charsToTrim)));
                    }
                    sqlTemp = sqlTemp + ")";
                }
                else
                {
                    sqlTemp = "(-1)";
                }
            }
            else
            {
                sqlTemp = "(-1)";
            }
            return sqlTemp;
        }

        /// <summary>
        /// 查询语句
        /// 写在语句之前
        /// </summary>
        public static readonly string SelectSql = @"
                    declare @Temp_Variable varchar(max)
                    create table #Temp_Table(Item varchar(max))
                    while(LEN(@Temp_Array) > 0)
                    begin
                        if(CHARINDEX(',',@Temp_Array) = 0)
                        begin
                            set @Temp_Variable = @Temp_Array
                            set @Temp_Array = ''
                        end
                        else
                        begin
                            set @Temp_Variable = LEFT(@Temp_Array,CHARINDEX(',',@Temp_Array)-1)
                            set @Temp_Array = RIGHT(@Temp_Array,LEN(@Temp_Array)-LEN(@Temp_Variable)-1)
                        end    
                    insert into #Temp_Table(Item) values(@Temp_Variable)
                    end ";

        /// <summary>
        /// 删除临时表
        /// 写在SQL语句最后
        /// </summary>
        public static readonly string DropTempTable = " drop table #Temp_Table";

        /// <summary>
        /// 高性能查询
        /// 适用于查询数据多，上千条或者上万条，写在WHERE语句之后
        /// </summary>
        /// <returns></returns>
        public static string SQLInHighPerformanceHelper(string inField)
        {
            string sqlTemp = string.Empty;
            sqlTemp += " exists(select 1 from #Temp_Table WITH(nolock) where #Temp_Table.Item=";
            sqlTemp += inField + ")";

            return sqlTemp;
        }
    }
}
