/**  版本信息模板在安装目录下，可自行修改。
* v_Member_Region.cs
*
* 功 能： N/A
* 类 名： v_Member_Region
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:58   N/A    初版
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
	public partial class v_Member_Region
	{
		public v_Member_Region()
		{}
		#region Model
		private int _idplus;
		private string _id;
		private DateTime? _addtime;
		private int? _delstatus;
		private string _weixinid;
		private int? _rolegrade;
		private int? _applystate;
		private string _openid;
		private string _phone;
		private string _province;
		private string _city;
		private string _area;
		private string _address;
		private string _cardid;
		private string _cardimgurl;
		private decimal? _cautionbalance;
		private string _cautionurl;
		private decimal? _balance;
		private string _authno;
		private string _name;
		private int? _regionidplus;
		private string _regionteamname;
		private string _regioncode;
		private string _regioninfo;
		private string _regionlink;
		private int? _regiondisplayorder;
		private int? _regionisdisplay;
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
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WeixinId
		{
			set{ _weixinid=value;}
			get{return _weixinid;}
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
		public int? ApplyState
		{
			set{ _applystate=value;}
			get{return _applystate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OpenID
		{
			set{ _openid=value;}
			get{return _openid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string City
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Area
		{
			set{ _area=value;}
			get{return _area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardImgUrl
		{
			set{ _cardimgurl=value;}
			get{return _cardimgurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CautionBalance
		{
			set{ _cautionbalance=value;}
			get{return _cautionbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CautionUrl
		{
			set{ _cautionurl=value;}
			get{return _cautionurl;}
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
		public string AuthNo
		{
			set{ _authno=value;}
			get{return _authno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		public string RegionTeamName
		{
			set{ _regionteamname=value;}
			get{return _regionteamname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegionCode
		{
			set{ _regioncode=value;}
			get{return _regioncode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegionInfo
		{
			set{ _regioninfo=value;}
			get{return _regioninfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegionLink
		{
			set{ _regionlink=value;}
			get{return _regionlink;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RegionDisplayOrder
		{
			set{ _regiondisplayorder=value;}
			get{return _regiondisplayorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RegionIsDisplay
		{
			set{ _regionisdisplay=value;}
			get{return _regionisdisplay;}
		}
		#endregion Model

	}
}

