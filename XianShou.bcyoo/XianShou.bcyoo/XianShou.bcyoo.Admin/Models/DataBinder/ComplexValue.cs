using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XianShou.bcyoo.Admin.Models.DataBinder
{
    /// <summary>
    /// 复杂数据模型值表示对象
    /// </summary>
    public class ComplexValue
    {
        /// <summary>
        /// Null对象模式，标识是个空值
        /// </summary>
        public static readonly ComplexValue Empty = new ComplexValue();

        protected ComplexValue()
        {
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">数据的字段名称</param>
        public ComplexValue(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name is empty!");
            }

            Name = name;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name">数据的字段名称</param>
        /// <param name="value">数据值</param>
        public ComplexValue(string name, object value)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name is empty!");
            }

            Name = name;
            Value = value;
        }

        /// <summary>
        /// 数据的字段名称
        /// </summary>
        public string Name
        {
            get;
            protected set;
        }

        /// <summary>
        /// 数据值
        /// </summary>
        public Object Value
        {
            get;
            set;
        }

        /// <summary>
        /// 获取复杂数据模型的数据项最终名称
        /// </summary>
        /// <returns></returns>
        //public string GetFullName()
        //{
        //    string ret = Name; 

        //    if (Value != null && Value.GetType() == typeof(ComplexValue))
        //    {
        //        ComplexValue temp = Value as ComplexValue;
        //        ret = ret + DEFAULT_SPLITER + temp.GetFullName();
        //    }

        //    return ret;
        //}
    }
}
