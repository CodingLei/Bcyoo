/**  版本信息模板在安装目录下，可自行修改。
* v_Member_Role.cs
*
* 功 能： N/A
* 类 名： v_Member_Role
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:59   N/A    初版
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
	public partial class v_Member_Role
	{
		public v_Member_Role()
		{}
		#region Model
		private int _idplus;
		private string _id;
		private int? _delstatus;
		private DateTime? _addtime;
		private string _name;
		private string _phone;
		private string _weixinid;
		private string _headurl;
		private string _nickname;
		private string _province;
		private string _city;
		private string _area;
		private string _address;
		private string _openid;
		private string _password;
		private decimal? _balance;
		private string _touchpassword;
		private int? _applystate;
		private string _authno;
		private DateTime? _authtime;
		private int? _rolegrade;
		private int? _regionidplus;
		private int? _superiorsidplus;
		private string _gradesequence;
		private string _gradesequencevalue;
		private decimal? _markreducebalance;
		private decimal? _creditlimitbalance;
		private int? _defaultexpressidplus;
		private string _remark;
		private string _shopname;
		private string _shopdesc;
		private string _bannerurl;
		private string _tempcssurl;
		private decimal? _availablemoney;
		private decimal? _holdmoney;
		private decimal? _unavailablemoney;
		private decimal? _withdrawmoney;
		private string _rolename;
		private decimal? _firstpay;
		private decimal? _firstorder;
		private int? _limitagentcount;
		private string _menu;
		private int? _displayorder;
		private int? _canceloperationidplus;
		private string _regionteamname;
		private string _superiorsname;
		private string _superiorsrolename;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		public string WeixinId
		{
			set{ _weixinid=value;}
			get{return _weixinid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeadUrl
		{
			set{ _headurl=value;}
			get{return _headurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
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
		public string OpenID
		{
			set{ _openid=value;}
			get{return _openid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
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
		public string TouchPassword
		{
			set{ _touchpassword=value;}
			get{return _touchpassword;}
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
		public string AuthNo
		{
			set{ _authno=value;}
			get{return _authno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AuthTime
		{
			set{ _authtime=value;}
			get{return _authtime;}
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
		public string GradeSequence
		{
			set{ _gradesequence=value;}
			get{return _gradesequence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GradeSequenceValue
		{
			set{ _gradesequencevalue=value;}
			get{return _gradesequencevalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MarkReduceBalance
		{
			set{ _markreducebalance=value;}
			get{return _markreducebalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CreditLimitBalance
		{
			set{ _creditlimitbalance=value;}
			get{return _creditlimitbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DefaultExpressIDPlus
		{
			set{ _defaultexpressidplus=value;}
			get{return _defaultexpressidplus;}
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
		public string ShopName
		{
			set{ _shopname=value;}
			get{return _shopname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShopDesc
		{
			set{ _shopdesc=value;}
			get{return _shopdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BannerUrl
		{
			set{ _bannerurl=value;}
			get{return _bannerurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TempCssUrl
		{
			set{ _tempcssurl=value;}
			get{return _tempcssurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AvailableMoney
		{
			set{ _availablemoney=value;}
			get{return _availablemoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? HoldMoney
		{
			set{ _holdmoney=value;}
			get{return _holdmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UnavailableMoney
		{
			set{ _unavailablemoney=value;}
			get{return _unavailablemoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WithdrawMoney
		{
			set{ _withdrawmoney=value;}
			get{return _withdrawmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rolename
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FirstPay
		{
			set{ _firstpay=value;}
			get{return _firstpay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FirstOrder
		{
			set{ _firstorder=value;}
			get{return _firstorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LimitAgentCount
		{
			set{ _limitagentcount=value;}
			get{return _limitagentcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Menu
		{
			set{ _menu=value;}
			get{return _menu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DisPlayOrder
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CancelOperationIDPlus
		{
			set{ _canceloperationidplus=value;}
			get{return _canceloperationidplus;}
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
		public string SuperiorsName
		{
			set{ _superiorsname=value;}
			get{return _superiorsname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SuperiorsRoleName
		{
			set{ _superiorsrolename=value;}
			get{return _superiorsrolename;}
		}
		#endregion Model

	}
}

