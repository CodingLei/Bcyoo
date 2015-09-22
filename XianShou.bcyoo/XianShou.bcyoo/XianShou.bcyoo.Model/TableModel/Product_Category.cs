using ServiceStack.DataAnnotations;
/**  版本信息模板在安装目录下，可自行修改。
* Product_Category.cs
*
* 功 能： N/A
* 类 名： Product_Category
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:32   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace XianShou.bcyoo.Model.TableModel
{
	/// <summary>
	/// 产品表
	/// </summary>
	
	public partial class Product_Category
	{
		public Product_Category()
		{
            AddTime = DateTime.Now;
        }
		#region Model

        [PrimaryKey]
        [AutoIncrement]
        public int? IDPlus
        {
            get;
            set;
        }
		/// <summary>
		/// 
		/// </summary>
        public string Id
        {
            get;
            set;
        }
		/// <summary>
		/// 
		/// </summary>
        public int? Delstatus
        {
            get;
            set;
        }
		/// <summary>
		/// 
		/// </summary>
        public DateTime? AddTime
        {
            get;
            set;
        }
		/// <summary>
		/// 
		/// </summary>
		public string CategoryName
		{
            get;
            set;
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsDisplay
		{
            get;
            set;
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DisplayOrder
		{
            get;
            set;
		}
		#endregion Model

	}
}

