/**  版本信息模板在安装目录下，可自行修改。
* Member.cs
*
* 功 能： N/A
* 类 名： Member
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:18   N/A    初版
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
	/// Member:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Member
	{
		public Member()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _version=0;
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
		private decimal? _balance=0M;
		private string _touchpassword;
		private int? _applystate=1;
		private string _authno;
		private DateTime? _authtime;
		private int? _rolegrade=0;
		private int? _regionidplus=0;
		private int? _superiorsidplus=0;
		private string _gradesequence;
		private string _gradesequencevalue;
		private decimal? _markreducebalance=0M;
		private decimal? _creditlimitbalance=0M;
		private int? _defaultexpressidplus;
		private string _remark;
		private string _shopno;
		private string _shopname;
		private string _shopdesc="七夕打折打的惨无人道，店主一生无怨无悔";
		private string _bannerurl;
		private string _tempcssurl;
		private decimal? _availablemoney=0M;
		private decimal? _holdmoney=0M;
		private decimal? _unavailablemoney=0M;
		private decimal? _withdrawmoney=0M;
		private int? _recommenderidplus=0;
		private int? _isfirst=0;
		private string _qrcodeurl;
		private int? _rolegradetype=0;
		private int? _productpoint=0;
		private int? _isbigshop=0;
		private DateTime? _bigshoptime= Convert.ToDateTime("2000-01-01 00:00:00.000");
		private int? _currentshopcount=0;
		private int? _leijishopcount=0;
		private int? _bigshopcount=0;
		private int? _originalsuperiorsidplus=0;
		private int? _bigshopidplus=0;
		private DateTime? _upgradetime= Convert.ToDateTime("2000-01-01 00:00:00.000");
		private int _shoplisttype=7;
		private int _goodstempletetype=1;
		private int _shopsignstype=5;
		private int _shopcovertype=5;
		private int? _isexperience=0;
		private DateTime? _experienceendtime= Convert.ToDateTime("2000-01-01 00:00:00.000");
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
		/// 逻辑删除标识
		/// </summary>
		public int? Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 添加时间(申请时间)
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
		/// 姓名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 手机号
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 微信号
		/// </summary>
		public string WeixinId
		{
			set{ _weixinid=value;}
			get{return _weixinid;}
		}
		/// <summary>
		/// 头像url
		/// </summary>
		public string HeadUrl
		{
			set{ _headurl=value;}
			get{return _headurl;}
		}
		/// <summary>
		/// 昵称
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
		/// OPENID
		/// </summary>
		public string OpenID
		{
			set{ _openid=value;}
			get{return _openid;}
		}
		/// <summary>
		/// 登录密码
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 余额
		/// </summary>
		public decimal? Balance
		{
			set{ _balance=value;}
			get{return _balance;}
		}
		/// <summary>
		/// 手势密码
		/// </summary>
		public string TouchPassword
		{
			set{ _touchpassword=value;}
			get{return _touchpassword;}
		}
		/// <summary>
		/// 申请状态
		/// </summary>
		public int? ApplyState
		{
			set{ _applystate=value;}
			get{return _applystate;}
		}
		/// <summary>
		/// 代理编号
		/// </summary>
		public string AuthNo
		{
			set{ _authno=value;}
			get{return _authno;}
		}
		/// <summary>
		/// 通过时间
		/// </summary>
		public DateTime? AuthTime
		{
			set{ _authtime=value;}
			get{return _authtime;}
		}
		/// <summary>
		/// 角色ID
		/// </summary>
		public int? RoleGrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
		}
		/// <summary>
		/// 所属大区代理
		/// </summary>
		public int? RegionIDPlus
		{
			set{ _regionidplus=value;}
			get{return _regionidplus;}
		}
		/// <summary>
		/// 上级
		/// </summary>
		public int? SuperiorsIDPlus
		{
			set{ _superiorsidplus=value;}
			get{return _superiorsidplus;}
		}
		/// <summary>
		/// 代理序列
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
		/// 市场价
		/// </summary>
		public decimal? MarkReduceBalance
		{
			set{ _markreducebalance=value;}
			get{return _markreducebalance;}
		}
		/// <summary>
		/// 限额
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
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 店铺名称
		/// </summary>
		public string ShopNo
		{
			set{ _shopno=value;}
			get{return _shopno;}
		}
		/// <summary>
		/// 店铺名称
		/// </summary>
		public string ShopName
		{
			set{ _shopname=value;}
			get{return _shopname;}
		}
		/// <summary>
		/// 店铺介绍
		/// </summary>
		public string ShopDesc
		{
			set{ _shopdesc=value;}
			get{return _shopdesc;}
		}
		/// <summary>
		/// 横幅网址
		/// </summary>
		public string BannerUrl
		{
			set{ _bannerurl=value;}
			get{return _bannerurl;}
		}
		/// <summary>
		/// 模板网址
		/// </summary>
		public string TempCssUrl
		{
			set{ _tempcssurl=value;}
			get{return _tempcssurl;}
		}
		/// <summary>
		/// 可提现金额
		/// </summary>
		public decimal? AvailableMoney
		{
			set{ _availablemoney=value;}
			get{return _availablemoney;}
		}
		/// <summary>
		/// 待结算金额
		/// </summary>
		public decimal? HoldMoney
		{
			set{ _holdmoney=value;}
			get{return _holdmoney;}
		}
		/// <summary>
		/// 提现中金额
		/// </summary>
		public decimal? UnavailableMoney
		{
			set{ _unavailablemoney=value;}
			get{return _unavailablemoney;}
		}
		/// <summary>
		/// 已提现金额
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
		public int GoodsTempleteType
		{
			set{ _goodstempletetype=value;}
			get{return _goodstempletetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ShopSignsType
		{
			set{ _shopsignstype=value;}
			get{return _shopsignstype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ShopCoverType
		{
			set{ _shopcovertype=value;}
			get{return _shopcovertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsExperience
		{
			set{ _isexperience=value;}
			get{return _isexperience;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ExperienceEndTime
		{
			set{ _experienceendtime=value;}
			get{return _experienceendtime;}
		}
		#endregion Model

	}
}

