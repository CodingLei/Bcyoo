
using System;
using System.Linq;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using System.Web.Mvc;


namespace XianShou.bcyoo.Common.Helper
{
    public static class EnumUtil
    {
        /// <summary>
        /// 获取枚举的数据源
        /// </summary>
        /// <returns>数据源</returns>
        public static List<EnumDataModel> GetEnumDataList<T>()
        {
            return EnumUtilData<T>.enumDataList;
        }

        /// <summary>
        /// 通过枚举获取描述信息
        /// </summary>
        /// <param name="value">枚举字段</param>
        /// <returns>描述信息</returns>
        public static string GetDescriptionByValue<T>(object value)
        {
            return GetDescriptionByName<T>(value.ToString());
        }

        /// <summary>
        /// 通过枚举获取描述信息
        /// </summary>
        /// <param name="name">枚举字段</param>
        /// <returns>描述信息</returns>
        public static string GetDescriptionByName<T>(string name)
        {
            T t = GetEnumByName<T>(name);
            return GetDescriptionByEnum(t);
        }

        /// <summary>
        /// 通过枚举获取描述信息
        /// </summary>
        /// <param name="enumInstance">枚举</param>
        /// <returns>描述信息</returns>
        public static string GetDescriptionByEnum<T>(T enumInstance)
        {
            List<EnumDataModel> enumDataList = GetEnumDataList<T>();
            EnumDataModel enumData = enumDataList.Find(m => m.Value == enumInstance.GetHashCode());
            return enumData != null ? Convert.ToString(enumData.Description) : string.Empty;
        }

        /// <summary>
        /// 通过枚举值得到枚举
        /// </summary>
        /// <param name="value">枚举值</param>
        /// <returns>枚举</returns>
        public static T GetEnumByValue<T>(int value)
        {
            return GetEnumByName<T>(value.ToString());
        }

        /// <summary>
        /// 获取枚举类子项描述信息 
        /// </summary>
        /// <param name="enumtype">枚举类型</param>
        /// <param name="strVlaue">值</param>        
        public static string GetEnumDescriptionByValue(Type enumtype, string strVlaue)
        {
            foreach (Enum enumValue in Enum.GetValues(enumtype))
            {
                FieldInfo fi = enumtype.GetField((enumValue.ToString()));
                DescriptionAttribute da = (DescriptionAttribute)Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute));
                if (da != null && Convert.ToString(strVlaue).Equals(enumValue.ToString("d")))
                {
                    return Convert.ToString(da.Description);
                }
            }
            return string.Empty;
        }


        /// <summary>
        /// 根据特定的枚举值名称获得枚举值的Description特性的值
        /// </summary>
        /// <param name="value">枚举类型</param>
        /// <param name="name">枚举值的名称</param>
        /// <returns>返回查找到的Description特性的值，如果没有，就返回.ToString()</returns>
        public static string GetEnumDescription(Type value, string name)
        {
            if (string.IsNullOrEmpty(name)) return "";

            FieldInfo fi = value.GetField(name);
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : name;
        }

        /// <summary>
        /// 通过枚举值得到枚举
        /// </summary>
        /// <param name="name">枚举值</param>
        /// <returns>枚举</returns>
        public static T GetEnumByName<T>(string name)
        {
            Type t = typeof(T);
            return (T)Enum.Parse(t, name);
        }

        /// <summary>
        /// 尝试转换枚举，失败则返回false
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="parsed"></param>
        /// <returns></returns>
        public static bool TryToEnum<T>(object value, out T parsed) where T : struct
        {
            bool isParsed = false;
            if (Enum.IsDefined(typeof(T), value))
            {
                parsed = (T)Enum.Parse(typeof(T), value.ToString());
                isParsed = true;
            }
            else
            {
                parsed = (T)Enum.Parse(typeof(T), Enum.GetNames(typeof(T))[0]);
            }
            return isParsed;
        }

        /// <summary>
        /// 根据枚举Description获取下拉框,没有Description将直接取Name
        /// </summary>
        /// <typeparam name="T">枚举类型</typeparam>
        /// <param name="defaultValue">默认选中值</param>
        /// <param name="addChoose">是否添加，请选择</param>
        /// <param name="chooseValue">请选择的Value值，默认-1-</param>
        /// <returns>SelectListItem 集合</returns>
        public static List<SelectListItem> SelectListEnum<T>(int? defaultValue = null, bool addChoose = true, string chooseValue = "-1") where T : struct
        {
            var enumSelectListItem = new List<SelectListItem>();
            if (addChoose)
            {
                var listItem = new SelectListItem { Text = "请选择", Value = chooseValue };
                enumSelectListItem.Add(listItem);
            }
            var enumDataList = GetEnumDataList<T>();

            enumSelectListItem.AddRange(from item in enumDataList
                                        let bl = defaultValue != null && item.Value == defaultValue
                                        select new SelectListItem { Text = item.Description, Value = item.Value.ToString(), Selected = bl });
            return enumSelectListItem;

        }

        /// <summary>
        /// 将枚举类型的所有值转换成一个List集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetEnumList<T>() where T : struct
         {
            var enumType = typeof(T);
            var list = Enum.GetNames(enumType).Select(statusName => (T)Enum.Parse(enumType, statusName)).ToList();
            return list;
        }

        /// <summary>
        /// 内部实现类，缓存
        /// </summary>
        /// <typeparam name="Tenum">枚举类型</typeparam>
        private static class EnumUtilData<Tenum>
        {
            /// <summary>
            /// 缓存数据
            /// </summary>
            internal static readonly List<EnumDataModel> enumDataList;

            static EnumUtilData()
            {
                enumDataList = InitData();
            }

            /// <summary>
            /// 初始化数据，生成枚举和描述的数据表
            /// </summary>
            private static List<EnumDataModel> InitData()
            {
                List<EnumDataModel> dataList = new List<EnumDataModel>();

                Type t = typeof(Tenum);
                FieldInfo[] fieldInfoList = t.GetFields();
                foreach (FieldInfo tField in fieldInfoList)
                {
                    if (!tField.IsSpecialName)
                    {
                        EnumDataModel enumData = new EnumDataModel();
                        enumData.Name = tField.Name;
                        enumData.Value = ((Tenum)Enum.Parse(t, enumData.Name)).GetHashCode();

                        DescriptionAttribute[] enumAttributelist = (DescriptionAttribute[])tField.GetCustomAttributes(typeof(DescriptionAttribute), false);
                        enumData.Description = enumAttributelist.Length > 0 ? enumAttributelist[0].Description : tField.Name;
                        dataList.Add(enumData);
                    }
                }
                return dataList;
            }
        }

        /// <summary>
        /// 枚举数据实体
        /// </summary>
        public class EnumDataModel
        {
            /// <summary>
            /// get or set 枚举名称
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// get or set 枚举值
            /// </summary>
            public int Value { get; set; }

            /// <summary>
            /// get or set 枚举描述
            /// </summary>
            public string Description { get; set; }
        }

        /// <summary>
        /// 获得枚举值的Description特性的值，一般是消息的搜索码
        /// </summary>
        /// <param name="value">要查找特性的枚举值</param>
        /// <returns>返回查找到的Description特性的值，如果没有，就返回.ToString()</returns>
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes =
              (DescriptionAttribute[])fi.GetCustomAttributes(
              typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }
    }
}
