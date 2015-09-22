using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XianShou.bcyoo.Admin.Models.DataBinder
{
    /// <summary>
    /// 数据提供器接口
    /// </summary>
    public interface IValueProvider
    {
        /// <summary>
        /// 根据指定数据类型获取数据对象，并使用数据源填充数据对象
        /// </summary>
        /// <param name="type">目标数据类型</param>
        /// <param name="valueCollection">数据源集合</param>
        /// <returns>指定type类型的数据对象实例</returns>
        object GetValue(Type type, ComplexValueCollection valueCollection);
    }
}
