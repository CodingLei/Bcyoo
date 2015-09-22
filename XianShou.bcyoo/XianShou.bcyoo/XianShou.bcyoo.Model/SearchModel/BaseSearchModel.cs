
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using XianShou.bcyoo.Model.Enum;

namespace XianShou.bcyoo.Model.SearchModel
{
    [Serializable]
    public class BaseSearchModel
    {
        private int _pageindex = 1;

        /// <summary>
        /// 当前第几页
        /// </summary>
        public int PageIndex
        {
            get { return _pageindex; }
            set { _pageindex = value; }
        }

        private int _pageSize = 10;//每页显示条数，默认10

        /// <summary>
        /// 每页显示条数
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }

        /// <summary>
        /// 需要检索的字段，
        /// </summary>
        public string SelectFileds { get; set; }

        /// <summary>
        /// 排序字段，可多个
        /// </summary>
        public Dictionary<string, OrderType> OrderByFields { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        public int TotalCount { get; set; }


    }
}
