/**  版本信息模板在安装目录下，可自行修改。
* Product_Brand.cs
*
* 功 能： N/A
* 类 名： Product_Brand
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:31   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using ServiceStack.DataAnnotations;
namespace XianShou.bcyoo.Model.TableModel
{
	/// <summary>
	/// 产品表
	/// </summary>
	public partial class Product_Brand
	{
		public Product_Brand()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private byte? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private string _brandname;
        private byte? _isdisplay = 1;
		private int? _displayorder=0;
		/// <summary>
		/// 
		/// </summary>
        [AutoIncrement]
        public int IDPlus
        {
            get;
            set;
        }
		/// <summary>
		/// 
		/// </summary>
		public string Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
        public byte? Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BrandName
		{
			set{ _brandname=value;}
			get{return _brandname;}
		}
		/// <summary>
		/// 
		/// </summary>
        public byte? IsDisplay
		{
			set{ _isdisplay=value;}
			get{return _isdisplay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DisplayOrder
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
		}
		#endregion Model

	}
}

