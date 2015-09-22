using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XianShou.bcyoo.Common.Helper;
using XianShou.bcyoo.Model.SearchModel;
using XianShou.bcyoo.Model.TableModel;

namespace XianShou.bcyoo.Admin.DataAccess.DataAccess
{
    public class DemoDataAccess
    {
        public DemoSearchResultModel GetDemoResult(DemoSearchModel search)
        {
            string formatSql = @"SELECT {0} From {1} B  WITH(NOLOCK)";
            List<SqlParameter> Collection = new List<SqlParameter>();
            Dictionary<string, string> dicParam = new Dictionary<string, string>();
            dicParam.Add("BasicId", "int");

            search.SelectFileds = " B.IDPlus,B.Id,B.Delstatus,B.AddTime,B.BrandName,B.IsDisplay,B.DisplayOrder ";
            StringBuilder strCondictionSql = new StringBuilder(string.Format(formatSql, "B.IDPlus", "Product_Brand"));
            int total = 0;
            string strQuerySql = string.Format(formatSql, search.SelectFileds.Length > 0 ? search.SelectFileds : "B.*",
                                   "Product_Brand");

            strQuerySql += string.Format(" INNER JOIN   @indexTabel it on it.BasicId=B.IDPlus ");

            strCondictionSql.Append(" WHERE 1=1 ");
            if (!string.IsNullOrWhiteSpace(search.BrandName))
            {
                strCondictionSql.Append("AND B.BrandName=@BrandName ");
                Collection.Add(new SqlParameter("@BrandName", search.BrandName));
            }


            strCondictionSql.Append(" ORDER BY B.AddTime DESC ");


            DataTable dt = PageSplitQuery.GeneralHighPerformancePager(strCondictionSql.ToString(), strQuerySql, dicParam, search.PageIndex, search.PageSize, ref total, Collection.ToArray());

            DemoSearchResultModel model = new DemoSearchResultModel
            {
                TotalCount = total,
                ProductBrandList = EntityUtil.ToList<Product_Brand>(dt)
            };
            return model;
        }
    }
}
