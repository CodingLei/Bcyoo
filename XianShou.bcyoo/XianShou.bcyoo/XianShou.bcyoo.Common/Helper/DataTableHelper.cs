using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace XianShou.bcyoo.Common.Helper
{
    public  class DataTableHelper
    {
        /// <summary>
        /// 根据传入的枚举获取到的Dictionary获取到新的DataTable,比之前方法更加有效,且能防止因特殊符号出错
        /// </summary>
        /// <param name="state">传入的状态值,与Key比较</param>
        /// <param name="stateval">新加列,传出的状态名,Value</param>
        /// <param name="dic">根据枚举获取到的Dictionary</param>
        /// <param name="dt">传入的DataTable</param>
        /// <returns>产生新的DataTable表</returns>
        public static DataTable DictionaryGetTable(DataTable dt, string state, Dictionary<string, string> dic)
        {
            string val = state + "val";
            dt.Columns.Add(val);
            foreach (DataRow row in dt.Rows)
            {
                foreach (KeyValuePair<string, string> r in dic)
                {
                    if (dic.Keys.Contains(row[state].ToString()))
                    {
                        if (r.Key.ToString() == row[state].ToString())
                        {
                            row[val] = r.Value.ToString();
                        }
                    }
                    else
                    {
                        row[val] = "无";
                    }
                }
            }
            return dt;
        }
        /// <summary>
        /// 根据传入的枚举获取到的Dictionary获取到新的DataTable,可以含有两个类型的枚举
        /// </summary>
        /// <param name="dt">传入的DataTable</param>
        /// <param name="state1">传入的第一个类型</param>
        /// <param name="dic1">传入的第一个枚举Dictionary</param>
        /// <param name="state2">传入的第二个类型</param>
        /// <param name="dic2">传入的第二个枚举Dictionary</param>
        /// <returns>返回新DataTable</returns>
        public static DataTable DictionaryGetTable(DataTable dt, string state1, Dictionary<string, string> dic1, string state2, Dictionary<string, string> dic2)
        {
            dt = DictionaryGetTable(dt, state1, dic1);
            dt = DictionaryGetTable(dt, state2, dic2);
            return dt;
        }
        /// <summary>
        /// 根据传入的Dictionary(Dictionary<string, Dictionary<string, string>>类型)获取到的Dictionary获取到新的DataTable
        /// </summary>
        /// <param name="dt">传入的DataTable</param>
        /// <param name="dic">传入的Dictionary(Dictionary<string, Dictionary<string, string>>类型)包含多个枚举</param>
        /// <returns>返回新DataTable</returns>
        public static DataTable DictionaryGetTable(DataTable dt, Dictionary<string, Dictionary<string, string>> dic)
        {
            DataRow ro;
            ro = dt.NewRow();
            foreach (KeyValuePair<string, Dictionary<string, string>> r in dic)
            {
                dt = DictionaryGetTable(dt, r.Key.ToString(), r.Value);
            }
            return dt;
        }
        public static DataTable GetStrByGradeSequence(DataTable dt)
        {
            dt.Columns.Add("GradeSequenceval");
            
            foreach (DataRow ro in dt.Rows)
            {
                string strs = ro["GradeSequence"].ToString();
                if (strs.Length > 0 && strs.Contains(":"))
                {
                    var sbstr = new StringBuilder();
                    //foreach (var se in strs.Split(',').Select(seq => seq.Split(':')))
                    //{
                    //    sbstr.AppendFormat("{0}:{1}|",
                    //        //(from p in dtRole.AsEnumerable() where p["GradeTag"].ToString().Trim() == se[0].Trim() select p).ToList().Single()["RoleName"].ToString(),
                    //        //(from p in dtAllApplySuccessMember.AsEnumerable() where p["IDPlus"].ToString().Trim() == se[1].Trim() select p).ToList().Single()["Name"].ToString()

                    //    );
                    //}
                    //sbstr.ToString().Trim('|');
                    //StringBuilder gradestr = new StringBuilder();
                    StringBuilder memberstr = new StringBuilder();
                    foreach (var se in strs.Split(',').Select(seq => seq.Split(':')))
                    {
                        //gradestr.AppendFormat(se[0].ToString()+",");
                        memberstr.AppendFormat(se[1].ToString() + ",");
                    }
                    DataTable td = SqlHelper.GetDataTable(string.Format("SELECT RoleName,Name FROM dbo.Member m LEFT JOIN dbo.Member_Role mr ON mr.Grade=m.RoleIDPlus WHERE m.IDPlus IN ({0}) ORDER BY mr.Grade ASC ",memberstr.ToString().Substring(0,memberstr.Length-1)));
                    foreach(DataRow r in td.Rows)
                    {
                        sbstr.AppendFormat("{0}:{1}|",r["RoleName"].ToString(),r["Name"].ToString());
                    }
                    ro["GradeSequenceval"] = sbstr;
                }
                else
                {
                    ro["GradeSequenceval"] = "";
                }
            }
            return dt;
        }
    }
}
