/**  版本信息模板在安装目录下，可自行修改。
* V_MemberOrder_Commission_Product_Detail.cs
*
* 功 能： N/A
* 类 名： V_MemberOrder_Commission_Product_Detail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:04   N/A    初版
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
	public partial class V_MemberOrder_Commission_Product_Detail
	{
		public V_MemberOrder_Commission_Product_Detail()
		{}
		#region Model
		private int _idplus;
		private string _id;
		private int? _delstatus;
		private DateTime? _addtime;
		private int? _version;
		private int? _memberidplus;
		private string _orderno;
		private decimal? _balance;
		private int? _state;
		private string _remark;
		private int? _regionidplus;
		private int? _superiorsidplus;
		private int? _rolegrade;
		private int? _rolegradetype;
		private int? _relationidplus;
		private int? _commissiontype;
		private decimal? _commissionbasebalance;
		private decimal? _commissionrate;
		private string _descrip;
		private decimal? _productprice;
		private int? _productcount;
		private string _productname;
		private string _imgurl;
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
		public int? Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Version
		{
			set{ _version=value;}
			get{return _version;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Balance
		{
			set{ _balance=value;}
			get{return _balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RegionIDPlus
		{
			set{ _regionidplus=value;}
			get{return _regionidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SuperiorsIDPlus
		{
			set{ _superiorsidplus=value;}
			get{return _superiorsidplus;}
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
		public int? RoleGradeType
		{
			set{ _rolegradetype=value;}
			get{return _rolegradetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RelationIDPlus
		{
			set{ _relationidplus=value;}
			get{return _relationidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CommissionType
		{
			set{ _commissiontype=value;}
			get{return _commissiontype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CommissionBaseBalance
		{
			set{ _commissionbasebalance=value;}
			get{return _commissionbasebalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CommissionRate
		{
			set{ _commissionrate=value;}
			get{return _commissionrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Descrip
		{
			set{ _descrip=value;}
			get{return _descrip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ProductPrice
		{
			set{ _productprice=value;}
			get{return _productprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProductCount
		{
			set{ _productcount=value;}
			get{return _productcount;}
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
		#endregion Model

	}
}

