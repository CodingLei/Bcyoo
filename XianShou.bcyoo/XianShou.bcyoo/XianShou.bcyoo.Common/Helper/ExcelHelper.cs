using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Web;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace XianShou.bcyoo.Common.Helper
{
    public static class ExcelHelper
    {
        /// <summary>
        /// Excel读取转换为DataTable
        /// </summary>
        /// <param name="file"></param>
        /// <returns>DataTable</returns>
        public static DataTable ExcelToDataTable(HttpPostedFileBase file)
        {
            DataTable dt = new DataTable();
            try
            {
                Stream stream = file.InputStream;
                IWorkbook workbook = null;
                if (file.FileName.Contains(".xlsx")) // 2007版本
                    workbook = new XSSFWorkbook(stream);
                else if (file.FileName.Contains(".xls")) // 2003版本
                    workbook = new HSSFWorkbook(stream);
                if (workbook != null)
                {
                    ISheet sheet = workbook.GetSheetAt(0);
                    IRow headRow = sheet.GetRow(0);
                    //添加列名
                    foreach (ICell headCell in headRow)
                    {
                        dt.Columns.Add(new DataColumn().ColumnName = headCell.ToString());
                    }
                    for (int i = 1; i <= sheet.LastRowNum; i++)
                    {
                        IRow row = sheet.GetRow(i);
                        DataRow dr = dt.NewRow();
                        for (int j = 0; j < row.LastCellNum; j++)
                        {
                            //if (row.GetCell(j) == null)
                            //{
                            //    continue;
                            //}
                            //ICell cell = row.GetCell(j);
                            //if (cell != null)
                            //{
                            //    cell.SetCellType(CellType.String);
                            //    string cellValue = cell.StringCellValue;
                            //    if (cellValue != null)
                            //    {
                            //        dr[j] = cellValue;
                            //    }
                            //}
                            if (row.GetCell(j) == null)
                            {
                                continue;
                            }
                            switch (row.GetCell(j).CellType)
                            {
                                case CellType.Blank:
                                    dr[j] = "";
                                    break;
                                case CellType.Boolean:
                                    dr[j] = row.GetCell(j).BooleanCellValue;
                                    break;
                                case CellType.Numeric:
                                    if (DateUtil.IsCellDateFormatted(row.GetCell(j))) //日期类型
                                    {
                                        dr[j] = row.GetCell(j).DateCellValue;
                                    }
                                    else //其他数字类型
                                    {
                                        dr[j] = row.GetCell(j).NumericCellValue;
                                    }
                                    break;
                                case CellType.String:
                                case CellType.Formula:
                                    dr[j] = row.GetCell(j).StringCellValue;
                                    break;
                                case CellType.Error:
                                    dr[j] = row.GetCell(j).ErrorCellValue;
                                    break;
                            }
                        }
                        dt.Rows.Add(dr);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
