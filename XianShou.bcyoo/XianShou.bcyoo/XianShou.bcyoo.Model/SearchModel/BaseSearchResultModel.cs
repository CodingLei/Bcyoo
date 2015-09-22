
namespace XianShou.bcyoo.Model.SearchModel
{
    using System;
    using System.Data;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 在此描述BaseResultModel的说明
    /// </summary>
    public class BaseSearchResultModel
    {
        /// <summary>
        /// 当前第几页
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页显示条数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        public int TotalCount { get; set; }
    }
}
