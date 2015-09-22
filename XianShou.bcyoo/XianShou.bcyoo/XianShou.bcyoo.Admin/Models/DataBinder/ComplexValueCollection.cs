using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace XianShou.bcyoo.Admin.Models.DataBinder
{
    /// <summary>
    /// 复杂数据模型值集合
    /// </summary>
    public class ComplexValueCollection : ComplexValue, IEnumerable<ComplexValue>
    {
        /// <summary>
        /// 复杂类型数据名称分隔符
        /// </summary>
        public static readonly char DEFAULT_SPLITER = '.';

        /// <summary>
        /// 默认编码方式为UTF-8
        /// </summary>
        public static readonly Encoding DEFAULT_CHAR_ENCODING = new UTF8Encoding();

        private List<ComplexValue> collection = null;

        public ComplexValueCollection()
        {
            collection = new List<ComplexValue>();
        }

        public ComplexValueCollection(string name)
            : this()
        {
            Name = name;
        }

        /// <summary>
        /// 通过执行器上下文环境创建值集合
        /// </summary>
        /// <param name="request">业务逻辑执行上下文环境</param>
        /// <returns></returns>
        public static ComplexValueCollection CreateInstance(HttpRequestBase request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            ComplexValueCollection instance = new ComplexValueCollection();

            #region 创建客户端提交的数据

            foreach (string key in request.Params.Keys)
            {
                if (key.IndexOf(DEFAULT_SPLITER) > 0)
                {
                    string[] nameArray = key.Split(new char[] { DEFAULT_SPLITER }, StringSplitOptions.RemoveEmptyEntries);
                    int depth = nameArray.Length;

                    // 获取首个集合
                    ComplexValueCollection obj = instance[nameArray[0]] as ComplexValueCollection;
                    if (obj == null)
                    {
                        obj = new ComplexValueCollection(nameArray[0]);
                        instance.Add(obj);
                    }

                    ComplexValueCollection subObj = obj;
                    for (int i = 1; i < depth - 1; i++)
                    {
                        ComplexValueCollection temp = subObj[nameArray[i]] as ComplexValueCollection;
                        if (temp == null)
                        {
                            temp = new ComplexValueCollection(nameArray[i]);
                            subObj.Add(temp);
                        }

                        subObj = temp;
                    }

                    ComplexValue valObj = new ComplexValue(nameArray[depth - 1], HttpUtility.UrlDecode(request[key], DEFAULT_CHAR_ENCODING));
                    subObj.Add(valObj);
                }
                else
                {
                    ComplexValue obj = new ComplexValue(key, HttpUtility.UrlDecode(request[key], DEFAULT_CHAR_ENCODING));
                    instance.Add(obj);
                }
            }

            #endregion

            return instance;
        }

        /// <summary>
        /// 获取复杂数据模型值
        /// </summary>
        /// <param name="name">值对应的字段名</param>
        /// <returns></returns>
        public ComplexValue this[string name]
        {
            get
            {
                ComplexValue ret = ComplexValue.Empty;

                if (!String.IsNullOrEmpty(name))
                {
                    foreach (ComplexValue item in collection)
                    {
                        if (name.Equals(item.Name, StringComparison.OrdinalIgnoreCase))
                        {
                            ret = item;
                            break;
                        }
                    }
                }

                return ret;
            }
        }

        /// <summary>
        /// 获取复杂数据模型值
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns></returns>
        public ComplexValue this[int index]
        {
            get
            {
                ComplexValue ret = null;

                if (0 <= index && index < collection.Count)
                {
                    ret = collection[index];
                }

                return ret;
            }
        }

        /// <summary>
        /// 获取集合中的数量
        /// </summary>
        public int Count
        {
            get
            {
                return collection.Count;
            }
        }

        /// <summary>
        /// 添加一个复杂数据模型值
        /// </summary>
        /// <param name="val"></param>
        public void Add(ComplexValue val)
        {
            if (val != null)
            {
                collection.Add(val);
            }
        }

        /// <summary>
        /// 清空集合
        /// </summary>
        public void Clear()
        {
            collection.Clear();
        }

        #region IEnumerable<ComplexValue> 成员

        public IEnumerator<ComplexValue> GetEnumerator()
        {
            return collection.GetEnumerator();
        }

        #endregion

        #region IEnumerable 成员

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
