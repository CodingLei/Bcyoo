using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace XianShou.bcyoo.Common.Helper
{
    public class EnumHelperTwo<TEnum>
    {
        public static int GetNumberByEnum(TEnum e)
        {
            return Convert.ToInt32(Enum.Parse(typeof(TEnum), e.ToString()));
        }


        public static TEnum GetEnumbyNumber(int number)
        {
            return (TEnum)Enum.Parse(typeof(TEnum), number.ToString());
        }
        /// <summary>
        /// 根据输入枚举的Key获得返回值，当不包含时传出输入的result
        /// </summary>
        /// <param name="number">传入的key</param>
        /// <param name="result">传入的result，当不包含时返回result</param>
        /// <returns>传出的枚举value值</returns>
        public static string GetEnumbyNumberHave(int number,string result)
        {
            return GetEnumbyNumber(number).ToString() == number.ToString() ? result : GetEnumbyNumber(number).ToString();
        }
        public static Dictionary<String, String> GetDict()
        {
            Type enumType = typeof(TEnum);  // 获取类型对象
            var enumFields = enumType.GetFields();
            return enumFields.Where(field => !field.IsSpecialName).ToDictionary(field => field.GetRawConstantValue().ToString(), field => field.Name);
        }
    }
}
