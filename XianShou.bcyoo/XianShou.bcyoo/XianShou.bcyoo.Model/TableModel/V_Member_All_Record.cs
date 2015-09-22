/**  版本信息模板在安装目录下，可自行修改。
* V_Member_All_Record.cs
*
* 功 能： N/A
* 类 名： V_Member_All_Record
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:52   N/A    初版
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
	public partial class V_Member_All_Record
	{
		public V_Member_All_Record()
		{}
		#region Model
		private int _idplus;
		private string _id;
		private int? _delstatus;
		private DateTime? _addtime;
		private int? _version;
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
		private string _shopno;
		private string _shopname;
		private string _shopdesc;
		private string _bannerurl;
		private string _tempcssurl;
		private decimal? _availablemoney;
		private decimal? _holdmoney;
		private decimal? _unavailablemoney;
		private decimal? _withdrawmoney;
		private int? _recommenderidplus;
		private int? _isfirst;
		private string _qrcodeurl;
		private int? _rolegradetype;
		private int? _productpoint;
		private int? _isbigshop;
		private DateTime? _bigshoptime;
		private int? _currentshopcount;
		private int? _leijishopcount;
		private int? _bigshopcount;
		private int? _originalsuperiorsidplus;
		private int? _bigshopidplus;
		private DateTime? _upgradetime;
		private int _shoplisttype;
		private string _iscommender;
		private string _time;
		private string _sell;
		private string _category;
		private string _readfrom;
		private string _cardid;
		private string _cardimgurl;
		private string _email;
		private string _payimgurl;
		private string _failreason;
		private string _applyreason;
		private string _cancelagentpictrue;
		private int? _canceloperationidplus;
		private int? _upgradeoperationidplus;
		private int? _upgraderoleidplus;
		private string _cautionurl;
		private decimal? _cautionbalance;
		private int? _isignorecaution;
		private string _rolename;
		private decimal? _firstpay;
		private decimal? _firstorder;
		private int? _limitagentcount;
		private string _menu;
		private string _superiorsname;
		private string _superiorsweixinid;
		private string _superiorsphone;
		private string _superiorsrolename;
		private int? _superiorsrolegrade;
		private string _regionname;
		private string _regionweixinid;
		private string _regionphone;
		private string _regionteamname;
		private string _regioncode;
		private string _recommendername;
		private string _recommenderphone;
		private string _recommenderrolename;
		private DateTime? _addrecordtime;
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
		public string ShopNo
		{
			set{ _shopno=value;}
			get{return _shopno;}
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
		public int? RecommenderIDPlus
		{
			set{ _recommenderidplus=value;}
			get{return _recommenderidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsFirst
		{
			set{ _isfirst=value;}
			get{return _isfirst;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QRCodeUrl
		{
			set{ _qrcodeurl=value;}
			get{return _qrcodeurl;}
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
		public int? ProductPoint
		{
			set{ _productpoint=value;}
			get{return _productpoint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsBigShop
		{
			set{ _isbigshop=value;}
			get{return _isbigshop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BigShopTime
		{
			set{ _bigshoptime=value;}
			get{return _bigshoptime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CurrentShopCount
		{
			set{ _currentshopcount=value;}
			get{return _currentshopcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LeijiShopCount
		{
			set{ _leijishopcount=value;}
			get{return _leijishopcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BigShopCount
		{
			set{ _bigshopcount=value;}
			get{return _bigshopcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OriginalSuperiorsIDPlus
		{
			set{ _originalsuperiorsidplus=value;}
			get{return _originalsuperiorsidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BigShopIDPlus
		{
			set{ _bigshopidplus=value;}
			get{return _bigshopidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpgradeTime
		{
			set{ _upgradetime=value;}
			get{return _upgradetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ShopListType
		{
			set{ _shoplisttype=value;}
			get{return _shoplisttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsCommender
		{
			set{ _iscommender=value;}
			get{return _iscommender;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sell
		{
			set{ _sell=value;}
			get{return _sell;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Category
		{
			set{ _category=value;}
			get{return _category;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReadFrom
		{
			set{ _readfrom=value;}
			get{return _readfrom;}
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
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayImgUrl
		{
			set{ _payimgurl=value;}
			get{return _payimgurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FailReason
		{
			set{ _failreason=value;}
			get{return _failreason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ApplyReason
		{
			set{ _applyreason=value;}
			get{return _applyreason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CancelAgentPictrue
		{
			set{ _cancelagentpictrue=value;}
			get{return _cancelagentpictrue;}
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
		public int? UpgradeOperationIDPlus
		{
			set{ _upgradeoperationidplus=value;}
			get{return _upgradeoperationidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UpgradeRoleIDPlus
		{
			set{ _upgraderoleidplus=value;}
			get{return _upgraderoleidplus;}
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
		public decimal? CautionBalance
		{
			set{ _cautionbalance=value;}
			get{return _cautionbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsIgnoreCaution
		{
			set{ _isignorecaution=value;}
			get{return _isignorecaution;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleName
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
		public string SuperiorsName
		{
			set{ _superiorsname=value;}
			get{return _superiorsname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SuperiorsWeixinId
		{
			set{ _superiorsweixinid=value;}
			get{return _superiorsweixinid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SuperiorsPhone
		{
			set{ _superiorsphone=value;}
			get{return _superiorsphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SuperiorsRoleName
		{
			set{ _superiorsrolename=value;}
			get{return _superiorsrolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SuperiorsRoleGrade
		{
			set{ _superiorsrolegrade=value;}
			get{return _superiorsrolegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegionName
		{
			set{ _regionname=value;}
			get{return _regionname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegionWeixinId
		{
			set{ _regionweixinid=value;}
			get{return _regionweixinid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegionPhone
		{
			set{ _regionphone=value;}
			get{return _regionphone;}
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
		public string RecommenderName
		{
			set{ _recommendername=value;}
			get{return _recommendername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RecommenderPhone
		{
			set{ _recommenderphone=value;}
			get{return _recommenderphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RecommenderRoleName
		{
			set{ _recommenderrolename=value;}
			get{return _recommenderrolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddRecordTime
		{
			set{ _addrecordtime=value;}
			get{return _addrecordtime;}
		}
		#endregion Model

	}
}

