using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace XianShou.bcyoo.Common.Helper
{
    public class EnumHelper<TEnum>
    {
        private static DataTable GetDataTable()
        {
            Type enumType = typeof(TEnum);  // 获取类型对象
            FieldInfo[] enumFields = enumType.GetFields();

            DataTable table = new DataTable();
            table.Columns.Add("Name", Type.GetType("System.String"));
            table.Columns.Add("Value", Type.GetType("System.Int32"));
            //遍历集合
            foreach (FieldInfo field in enumFields)
            {
                if (!field.IsSpecialName)
                {
                    DataRow row = table.NewRow();
                    row[0] = field.Name;
                    row[1] = Convert.ToInt32(field.GetRawConstantValue());
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        public static string GetValue(int value)
        {
            return Enum.GetName(typeof(TEnum), value);
        }
        public static void SetListControl(ListControl list)
        {
            list.DataSource = GetDataTable();
            list.DataTextField = "Name";
            list.DataValueField = "Value";
            list.DataBind();
        }

        public static void SetHtmlSelect(HtmlSelect list)
        {
            list.DataSource = GetDataTable();
            list.DataTextField = "Name";
            list.DataValueField = "Value";
            list.DataBind();
        }

        public static Dictionary<String, String> GetDicEnum()
        {
            Type enumType = typeof(TEnum);  // 获取类型对象
            FieldInfo[] enumFields = enumType.GetFields();
            Dictionary<String, String> dic = new Dictionary<string, string>();
            foreach (FieldInfo field in enumFields)
            {
                if (!field.IsSpecialName)
                {
                    dic.Add(field.GetRawConstantValue().ToString(), field.Name);
                }
            }
            return dic;
        }
    }
}
