/**  版本信息模板在安装目录下，可自行修改。
* V_ProductSystem_All.cs
*
* 功 能： N/A
* 类 名： V_ProductSystem_All
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:20   N/A    初版
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
	/// 会员店消费者地址表
	/// </summary>
	[Serializable]
	public partial class V_ProductSystem_All
	{
		public V_ProductSystem_All()
		{}
		#region Model
		private int _idplus;
		private string _id;
		private DateTime? _addtime;
		private int? _delstatus;
		private int? _rolegrade;
		private decimal? _price;
		private string _productsku;
		private int? _displayorder;
		private int? _limit;
		private int? _specidplus;
		private int? _iscollect;
		private int? _issubmitorder;
		private int? _initialcount;
		private int? _maxredpack;
		private int? _minredpack;
		private string _productname;
		private string _imgurl;
		private int? _stock;
		private int? _waitsendstock;
		private string _giftinfo;
		private string _specvalue;
		private int? _speccount;
		private string _rolename;
		/// <summary>
		/// 
		/// </summary>
		public int IDPlus
		{
			set{ _idplus=value;}
			get{return _idplus;}
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
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DelStatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleGrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductSku
		{
			set{ _productsku=value;}
			get{return _productsku;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DisplayOrder
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Limit
		{
			set{ _limit=value;}
			get{return _limit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SpecIDPlus
		{
			set{ _specidplus=value;}
			get{return _specidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsCollect
		{
			set{ _iscollect=value;}
			get{return _iscollect;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsSubmitOrder
		{
			set{ _issubmitorder=value;}
			get{return _issubmitorder;}
		}
		/// <summary>
		/// 
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
		/// <summary>
		/// 
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Stock
		{
			set{ _stock=value;}
			get{return _stock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WaitSendStock
		{
			set{ _waitsendstock=value;}
			get{return _waitsendstock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GiftInfo
		{
			set{ _giftinfo=value;}
			get{return _giftinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SpecValue
		{
			set{ _specvalue=value;}
			get{return _specvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SpecCount
		{
			set{ _speccount=value;}
			get{return _speccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		#endregion Model

	}
}

