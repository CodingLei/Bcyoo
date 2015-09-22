using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace XianShou.bcyoo.Admin.Models.DataBinder
{
    /// <summary>
    /// 集合数据提供器
    /// </summary>
    /// <remarks>
    /// 警告：此次版本实现仅支持集合中的值为简单类型的数据
    /// </remarks>
    public class ListValueProvider : IValueProvider
    {
        #region IValueProvider 成员

        public object GetValue(Type type, ComplexValueCollection valueCollection)
        {
            IList ret = null;

            if (valueCollection != null)
            {
                ret = Activator.CreateInstance(type) as IList;
                Type[] typeParams = type.GetGenericArguments();
                PropertyInfo[] valueProperties = typeParams[0].GetProperties();

                foreach (ComplexValueCollection item in valueCollection)
                {
                    object val = Activator.CreateInstance(typeParams[0]);
                    if (val != null)
                    {
                        foreach (PropertyInfo property in valueProperties)
                        {
                            // 仅支持简单类型
                            if (property.CanWrite && !DefaultValueProviderFactory.IsCustomizeType(property.PropertyType))
                            {
                                property.SetValue(val, DefaultValueProviderFactory.ConvertTo(property.PropertyType, item[property.Name].Value), null);
                            }
                        }
                    }

                    ret.Add(val);
                }
            }

            return ret;
        }

        #endregion
    }
}
