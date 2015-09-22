using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.Util;

namespace XianShou.bcyoo.Common.Helper
{


    /// <summary>
    /// 导出excel公用类
    /// </summary>
    public class ExportToExcelHelper<T>
    {
        public static void DataTableToExcelFile(DataTable dt)
        {
            DataTableToExcelFile(dt, DateTime.Now.ToString("yyyyMMddhhmmss"));
        }

        public static void DataTableToExcelFile(DataTable dt, string FileName)
        {
            if (!FileName.Contains(".xls"))
            {
                FileName += ".xls";
            }

            StringBuilder excelStr = new StringBuilder();
            excelStr.Append("<table>");
            excelStr.Append("<tr>");
            DataRow[] myRow = dt.Select(); //可以类似dt.Select("id>10")之形式达到数据筛选目的
            int cl = dt.Columns.Count;
            //导出表头(在中间位置)
            for (int i = 0; i < cl; i++)
            {
                excelStr.Append("<td style= 'vnd.ms-excel.numberformat:@ '>");
                excelStr.Append(dt.Columns[i].Caption.ToString());
                excelStr.Append("</td>");
            }
            excelStr.Append("</tr>");
            // sw.Write(colHeaders);
            //向HTTP输出流中写入取得的数据信息 
            //逐行处理数据   
            foreach (DataRow row in myRow)
            {
                excelStr.Append("<tr>");
                //当前行数据写入HTTP输出流，并且置空ls_item以便下行数据     
                for (int i = 0; i < cl; i++)
                {
                    excelStr.Append("<td style= 'vnd.ms-excel.numberformat:@ '>");
                    excelStr.Append(row[i].ToString());
                    excelStr.Append("</td>");

                }
                excelStr.Append("</tr>");
            }

            excelStr.Append("</table>");
            HttpResponse rs = System.Web.HttpContext.Current.Response;
            rs.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
            rs.AppendHeader("Content-Disposition", "attachment;filename=" + FileName);
            rs.ContentType = "application/vnd.ms-excel";
            rs.Write("<html><head><meta http-equiv=\"Content-Type\" content=\"text/html\" charset=\"GB2312\">" +
                     SetStyle() + " </head><body>");
            rs.Write(excelStr.ToString());
            rs.Write("</body></html>");

        }

        /// <summary>
        /// 样式
        /// </summary>
        /// <returns></returns>
        private static string SetStyle()
        {
            string style = null;
            style = @"<style>
                   <!--table
                     tr
	                {mso-height-source:auto;
	                mso-ruby-visibility:none;}
                col
	                {mso-width-source:auto;
	                mso-ruby-visibility:none;}
                br
	                {mso-data-placement:same-cell;}
                .style0
	                {mso-number-format:General;
	                text-align:general;
	                vertical-align:middle;
	                white-space:nowrap;
	                mso-rotate:0;
	                mso-pattern:auto;
	                color:windowtext;
	                font-size:12.0pt;
	                font-weight:400;
	                font-style:normal;
	                text-decoration:none;
	                font-family:宋体;
	                mso-generic-font-family:auto;
	                mso-font-charset:134;
	                border:.5pt solid black;
	                mso-protection:locked visible;
	                mso-style-name:常规;
	                mso-style-id:0;}
                td
	                {mso-style-parent:style0;
	                padding-top:1px;
	                padding-right:1px;
	                padding-left:1px;
	                mso-ignore:padding;
	                color:windowtext;
	                font-size:12.0pt;
	                font-weight:400;
	                font-style:normal;
	                text-decoration:none;
	                font-family:宋体;
	                mso-generic-font-family:auto;
	                mso-font-charset:134;
	                mso-number-format:General;
	                text-align:general;
	                vertical-align:middle;
	                border:.5pt solid black;
	                mso-pattern:auto;
	                mso-protection:locked visible;
	                white-space:nowrap;
	                mso-rotate:0;}
                -->
               </style>";
            return style;
        }

        /// <summary>
        /// 导出excel
        /// </summary>
        /// <param name="list">传入自定义model结合</param>
        /// <param name="showField">需要展示的字段结合，key：字段名 ，value：对应的中文列名</param>
        /// <param name="fileName">文件名,缺省参数</param>
        /// <param name="sheetCount">每个工作表最大数据行数（最大值为65535）,缺省参数</param>
        public void ExportToExcel(IList<T> list, Dictionary<string, string> showField, string fileName = null,
            int sheetCount = 0)
        {
            RenderToExcel(list.ToList(), showField, fileName, sheetCount);
        }


        /// <summary>
        /// 使用NPOI进行导出操作
        /// </summary>
        /// <param name="lists">需要导出的LIST</param>
        /// <param name="showfield">需要展示的字段结合，key：字段名 ，value：对应的中文列名</param>
        /// <param name="strFileName">文件名,缺省参数</param>
        /// <param name="sheetCount">每个工作表最大数据行数（最大值为65535）,缺省参数</param>
        public void RenderToExcel(List<T> lists, Dictionary<string, string> showfield, string strFileName = null,
            int sheetCount = 0)
        {
            if (showfield == null || showfield.Count == 0)
            {
                return;
            }
            if (lists == null || lists.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(strFileName))
            {
                strFileName = DateTime.Now.ToString("yyyyMMddHHmmss");
            }

            if (sheetCount <= 0)
            {
                sheetCount = 10000;
            }

            IWorkbook workbook = new HSSFWorkbook();
            MemoryStream ms = new MemoryStream();
            ISheet sheet = workbook.CreateSheet();
            IRow headerRow = sheet.CreateRow(0);
            headerRow.HeightInPoints = 20;
            Type myType = typeof(T);
            List<PropertyInfo> myPro = new List<PropertyInfo>();
            int i = 0;
            int j = 1;
            int[] arrColWidth = new int[showfield.Count];
            //获取列的宽度并根据反射从传递进来的属性名信息得到要显示的属性
            foreach (string key in showfield.Keys)
            {
                PropertyInfo p = myType.GetProperty(key);
                myPro.Add(p);
                arrColWidth[i] = showfield[key].Length * 2;
                i++;
            }
            i = 0;
            foreach (T item in lists)
            {
                int k = 0;
                foreach (PropertyInfo p in myPro)
                {
                    int intTemp = p == null ? 0 : Convert.ToString(p.GetValue(item, null)).Length * 2;
                    if (intTemp > arrColWidth[k])
                    {
                        arrColWidth[k] = intTemp;
                    }
                    k++;
                }
            }
            //设置列的宽度 将第一行作为列名填入列名
            foreach (string key in showfield.Keys)
            {
                if ((arrColWidth[i] + 1) < 80)
                {
                    sheet.SetColumnWidth(i, (arrColWidth[i] + 1) * 256);
                }
                else
                {
                    sheet.SetColumnWidth(i, 80 * 256);
                }
                headerRow.CreateCell(i).SetCellValue(showfield[key].ToString());
                i++;
            }
            //填充数据
            foreach (T item in lists)
            {
                //若数据超过10000行再次创建工作表
                if (j > sheetCount)
                {
                    sheet = workbook.CreateSheet();
                    j = 1;
                    i = 0;
                    headerRow = sheet.CreateRow(0);
                    //将第一行作为列名填入列名 设置列的宽度
                    foreach (string key in showfield.Keys)
                    {
                        if ((arrColWidth[i] + 1) < 80)
                        {
                            sheet.SetColumnWidth(i, (arrColWidth[i] + 1) * 256);
                        }
                        else
                        {
                            sheet.SetColumnWidth(i, 80 * 256);
                        }
                        headerRow.CreateCell(i).SetCellValue(showfield[key].ToString());
                        i++;
                    }
                }
                IRow dataRow = sheet.CreateRow(j);
                dataRow.HeightInPoints = 20;
                int index = 0;
                foreach (PropertyInfo p in myPro)
                {
                    dataRow.CreateCell(index)
                        .SetCellValue(p == null ? "" : Convert.ToString(p.GetValue(item, null)));
                    index++;
                }
                j++;
            }
            workbook.Write(ms);
            ms.Flush();
            ms.Position = 0;
            HttpContext curContext = HttpContext.Current;

            // 设置编码和附件格式
            curContext.Response.ContentType = "application/vnd.ms-excel";
            curContext.Response.ContentEncoding = Encoding.UTF8;
            curContext.Response.Charset = "";
            curContext.Response.AppendHeader("Content-Disposition",
                "attachment;filename=" + HttpUtility.UrlEncode(strFileName + ".xls", Encoding.UTF8));

            curContext.Response.BinaryWrite(ms.GetBuffer());
            curContext.Response.End();
        }

        

    }
}
