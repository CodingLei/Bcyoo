using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.ComponentModel;
using System.Reflection;
using System.Web;
using System.Web.Routing;

namespace XianShou.bcyoo.Admin.Models.DataBinder
{
    /// <summary>
    /// 默认数据提供工厂对象
    /// </summary>
    public sealed class DefaultValueProviderFactory
    {
        private static readonly CultureInfo _staticCulture = CultureInfo.InvariantCulture;

        /// <summary>
        /// 判断类型是否为自定义类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsCustomizeType(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("Type is null!");
            }

            bool ret = false;

            if (type != typeof(String) && type != typeof(DateTime) && type != typeof(Enum))
            {
                if (!type.IsPrimitive)
                {
                    ret = true;
                }
            }

            return ret;
        }

        /// <summary>
        /// 获取实参
        /// </summary>
        /// <param name="param">参数的元数据</param>
        /// <param name="valueCollection">数据集合</param>
        /// <returns>数据对象实例</returns>
        public static object GetParamValue(ParameterInfo param, ComplexValueCollection valueCollection)
        {
            if (param == null || valueCollection == null)
            {
                throw new ArgumentNullException("ParameterInfo or ComplexValueCollection is null!");
            }

            object ret = null;

            if (!IsCustomizeType(param.ParameterType))
            // 若为简单类型
            {
                // 直接从数据集合中获取
                ret = ConvertSimpleType(null, valueCollection[param.Name].Value, param.ParameterType);
            }
            else
            {
                if (param.ParameterType.IsGenericType)
                {
                    string typeName = param.ParameterType.FullName;
                    IValueProvider provider = null;

                    // 仅支持字典和集合两种泛型属性
                    if (typeName.Contains("Dictionary"))
                    {
                        provider = new DictionaryValueProvider();
                    }
                    else if (typeName.Contains("List"))
                    {
                        provider = new ListValueProvider();
                    }

                    if (provider != null)
                    {
                        ret = provider.GetValue(param.ParameterType, valueCollection[param.Name] as ComplexValueCollection);
                    }
                }
                else
                {
                    ret = Activator.CreateInstance(param.ParameterType);
                    if (ret != null)
                    {
                        PackData(ret, valueCollection);
                    }
                }
            }

            if (ret == null)
                // 若没有找到指定的值，则赋予此参数的默认值（若存在的话）
            {
                ret = param.DefaultValue;
            }

            return ret;
        }

        /// <summary>
        /// 封装传入Model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public static T PackModel<T>(HttpRequestBase request) where T : class
        {
            T ret = null;

            Type type = typeof(T);

            ComplexValueCollection valueCollection = ComplexValueCollection.CreateInstance(request);

            if (!IsCustomizeType(type))
            // 若为简单类型
            {
                // 直接从数据集合中获取
                ret = (T)ConvertSimpleType(null, valueCollection[type.Name].Value, type);
            }
            else
            {
                if (type.IsGenericType)
                {
                    string typeName = type.FullName;
                    IValueProvider provider = null;

                    // 仅支持字典和集合两种泛型属性
                    if (typeName.Contains("Dictionary"))
                    {
                        provider = new DictionaryValueProvider();
                    }
                    else if (typeName.Contains("List"))
                    {
                        provider = new ListValueProvider();
                    }

                    if (provider != null)
                    {
                        ret = (T)provider.GetValue(type, valueCollection[type.Name] as ComplexValueCollection);
                    }
                }
                else
                {
                    ret = (T)Activator.CreateInstance(type);
                    if (ret != null)
                    {
                        PackData(ret, valueCollection);
                    }
                }
            }

            return ret;
        }

        /// <summary>
        /// 尝试将对象转换为指定的类型
        /// </summary>
        /// <param name="type">待转换的类型</param>
        /// <param name="type">待转换的数据</param>
        /// <param name="culture">语言区域信息</param>
        /// <returns></returns>
        public static object ConvertTo(Type type, object rawValue, CultureInfo culture = null)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            CultureInfo cultureToUse = culture ?? _staticCulture;
            return UnwrapPossibleArrayType(cultureToUse, rawValue, type);
        }

        /// <summary>
        /// 尝试转换简单对象
        /// </summary>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        private static object ConvertSimpleType(CultureInfo culture, object value, Type destinationType)
        {
            if (value == null || destinationType.IsInstanceOfType(value))
            {
                return value;
            }

            // if this is a user-input value but the user didn't type anything, return no value
            string valueAsString = value as string;
            if (valueAsString != null && valueAsString.Trim().Length == 0)
            {
                return null;
            }

            TypeConverter converter = TypeDescriptor.GetConverter(destinationType);
            bool canConvertFrom = converter.CanConvertFrom(value.GetType());
            if (!canConvertFrom)
            {
                converter = TypeDescriptor.GetConverter(value.GetType());
            }
            if (!(canConvertFrom || converter.CanConvertTo(destinationType)))
            {
                string message = String.Format("错误：无法将类型{0}转换为{1}", value.GetType().FullName, destinationType.FullName);

                throw new InvalidOperationException(message);
            }

            try
            {
                object convertedValue = (canConvertFrom) ?
                     converter.ConvertFrom(null /* context */, culture, value) :
                     converter.ConvertTo(null /* context */, culture, value, destinationType);
                return convertedValue;
            }
            catch (Exception ex)
            {
                string message = String.Format("错误：无法将类型{0}转换为{1}", value.GetType().FullName, destinationType.FullName);

                throw new InvalidOperationException(message, ex);
            }
        }

        /// <summary>
        /// 封装数组
        /// </summary>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        private static object UnwrapPossibleArrayType(CultureInfo culture, object value, Type destinationType)
        {
            if (value == null || destinationType.IsInstanceOfType(value))
            {
                return value;
            }

            // array conversion results in four cases, as below
            Array valueAsArray = value as Array;
            if (destinationType.IsArray)
            {
                Type destinationElementType = destinationType.GetElementType();
                if (valueAsArray != null)
                {
                    // case 1: both destination + source type are arrays, so convert each element
                    IList converted = Array.CreateInstance(destinationElementType, valueAsArray.Length);
                    for (int i = 0; i < valueAsArray.Length; i++)
                    {
                        converted[i] = ConvertSimpleType(culture, valueAsArray.GetValue(i), destinationElementType);
                    }
                    return converted;
                }
                else
                {
                    // case 2: destination type is array but source is single element, so wrap element in array + convert
                    object element = ConvertSimpleType(culture, value, destinationElementType);
                    IList converted = Array.CreateInstance(destinationElementType, 1);
                    converted[0] = element;
                    return converted;
                }
            }
            else if (valueAsArray != null)
            {
                // case 3: destination type is single element but source is array, so extract first element + convert
                if (valueAsArray.Length > 0)
                {
                    value = valueAsArray.GetValue(0);
                    return ConvertSimpleType(culture, value, destinationType);
                }
                else
                {
                    // case 3(a): source is empty array, so can't perform conversion
                    return null;
                }
            }
            // case 4: both destination + source type are single elements, so convert
            return ConvertSimpleType(culture, value, destinationType);
        }

        /// <summary>
        /// 从路由数据中获取值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="routeData"></param>
        /// <returns></returns>
        /// <remarks>
        /// 警告：此处为了忽略参数的大小写因素，搜索算法性能略有下降（O(N)）
        /// </remarks>
        private static object GetValueFromRouteData(string key, RouteData routeData)
        {
            object ret = null;

            if (routeData != null)
            {
                foreach (string tokenKey in routeData.DataTokens.Keys)
                {
                    if (key.Equals(tokenKey, StringComparison.OrdinalIgnoreCase))
                    {
                        ret = routeData.DataTokens[tokenKey];
                        break;
                    }
                }
            }

            return ret;
        }

        /// <summary>
        /// 从客户端提交的数据中获取参数值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <remarks>
        /// 警告：此处为了忽略参数的大小写因素，搜索算法性能略有下降（O(N)）
        /// </remarks>
        private static object GetValueFromRequest(string key, HttpRequestBase request)
        {
            object ret = null;

            foreach (String paramKey in request.Params.Keys)
            {
                if (key.Equals(paramKey, StringComparison.OrdinalIgnoreCase))
                {
                    ret = request[paramKey];
                    break;
                }
            }

            return ret;
        }

        /// <summary>
        /// 为指定的目标对象封装数据
        /// </summary>
        /// <param name="destinationObject">目标对象</param>
        /// <param name="valueCollection">数据源集合</param>
        /// <remarks>
        /// 使用深度优先递归封装数据
        /// </remarks>
        private static void PackData(object destinationObject, ComplexValueCollection valueCollection)
        {
            if (valueCollection != null)
            {
                Type type = destinationObject.GetType();
                PropertyInfo[] properties = type.GetProperties();
                if (properties != null)
                {
                    foreach (PropertyInfo item in properties)
                    {
                        if (item.CanWrite)
                        {
                            if (!IsCustomizeType(item.PropertyType))
                            {
                                item.SetValue(destinationObject, ConvertSimpleType(null, valueCollection[item.Name].Value, item.PropertyType), null);
                            }
                            else if (!item.PropertyType.IsGenericType)
                            {
                                object subObj = Activator.CreateInstance(item.PropertyType);
                                item.SetValue(destinationObject, subObj, null);
                                PackData(subObj, valueCollection[item.Name] as ComplexValueCollection);
                            }
                            else
                            // 若为泛型对象
                            {
                                string typeName = item.PropertyType.FullName;
                                IValueProvider provider = null;

                                // 仅支持字典和集合两种泛型属性
                                if (typeName.Contains("Dictionary"))
                                {
                                    provider = new DictionaryValueProvider();
                                }
                                else if (typeName.Contains("List"))
                                {
                                    provider = new ListValueProvider();
                                }

                                if (provider != null)
                                {
                                    item.SetValue(destinationObject, provider.GetValue(item.PropertyType, valueCollection[item.Name] as ComplexValueCollection), null);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
