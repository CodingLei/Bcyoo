/**  版本信息模板在安装目录下，可自行修改。
* Product_PriceSystem.cs
*
* 功 能： N/A
* 类 名： Product_PriceSystem
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:34   N/A    初版
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
	/// 产品价格系统表
	/// </summary>
	[Serializable]
	public partial class Product_PriceSystem
	{
		public Product_PriceSystem()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private DateTime? _addtime= DateTime.Now;
		private int? _delstatus=0;
		private int? _rolegrade;
		private decimal? _price;
		private string _productsku;
		private int? _displayorder=0;
		private int? _limit;
		private int? _specidplus;
		private int? _iscollect;
		private int? _issubmitorder;
		private int? _initialcount=1;
		private int? _maxredpack;
		private int? _minredpack;
		/// <summary>
		/// 主键
		/// </summary>
		public int IDPlus
		{
			set{ _idplus=value;}
			get{return _idplus;}
		}
		/// <summary>
		/// 唯一标识
		/// </summary>
		public string Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 逻辑删除标识
		/// </summary>
		public int? DelStatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 角色等级IDPlus
		/// </summary>
		public int? RoleGrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
		}
		/// <summary>
		/// 价格
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 产品IDPlus
		/// </summary>
		public string ProductSku
		{
			set{ _productsku=value;}
			get{return _productsku;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int? DisplayOrder
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
		}
		/// <summary>
		/// 限制数量
		/// </summary>
		public int? Limit
		{
			set{ _limit=value;}
			get{return _limit;}
		}
		/// <summary>
		/// 规格IDplus
		/// </summary>
		public int? SpecIDPlus
		{
			set{ _specidplus=value;}
			get{return _specidplus;}
		}
		/// <summary>
		/// 允许汇总
		/// </summary>
		public int? IsCollect
		{
			set{ _iscollect=value;}
			get{return _iscollect;}
		}
		/// <summary>
		/// 允许下单
		/// </summary>
		public int? IsSubmitOrder
		{
			set{ _issubmitorder=value;}
			get{return _issubmitorder;}
		}
		/// <summary>
		/// 起订数量
		/// </summary>
		public int? InitialCount
		{
			set{ _initialcount=value;}
			get{return _initialcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MaxRedPack
		{
			set{ _maxredpack=value;}
			get{return _maxredpack;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MinRedPack
		{
			set{ _minredpack=value;}
			get{return _minredpack;}
		}
		#endregion Model

	}
}

