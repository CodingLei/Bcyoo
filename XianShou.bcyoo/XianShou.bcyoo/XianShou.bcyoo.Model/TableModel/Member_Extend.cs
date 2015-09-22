/**  版本信息模板在安装目录下，可自行修改。
* Member_Extend.cs
*
* 功 能： N/A
* 类 名： Member_Extend
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:21   N/A    初版
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
	/// 代理申请资料表
	/// </summary>
	[Serializable]
	public partial class Member_Extend
	{
		public Member_Extend()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
        private DateTime? _datetime;
		private int? _delstatus=0;
		private int? _memberidplus;
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
		private int? _canceloperationidplus;
		private string _cancelagentpictrue;
		private int? _upgradeoperationidplus;
		private int? _upgraderoleidplus;
		private decimal? _cautionbalance=0M;
		private string _cautionurl;
		private int? _isignorecaution=0;
		private int? _teamnum;
		private int? _ignorecautioncount=0;
		private int _isfirstshopsigns=0;
		private int _isfirstshoplist=0;
		private decimal? _upgradecautionbalance;
		private string _upgradecautionurl;
		private int _viewcount=0;
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
		public DateTime? DateTime
		{
			set{ _datetime=value;}
			get{return _datetime;}
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
		/// 代理商IDPlus
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 是否有推荐人
		/// </summary>
		public string IsCommender
		{
			set{ _iscommender=value;}
			get{return _iscommender;}
		}
		/// <summary>
		/// 做微商时间
		/// </summary>
		public string Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 之前销售情况
		/// </summary>
		public string Sell
		{
			set{ _sell=value;}
			get{return _sell;}
		}
		/// <summary>
		/// 做的品牌
		/// </summary>
		public string Category
		{
			set{ _category=value;}
			get{return _category;}
		}
		/// <summary>
		/// 从哪里了解到OSM微商
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
		public int? CancelOperationIDPlus
		{
			set{ _canceloperationidplus=value;}
			get{return _canceloperationidplus;}
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
		public int? IsIgnoreCaution
		{
			set{ _isignorecaution=value;}
			get{return _isignorecaution;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TeamNum
		{
			set{ _teamnum=value;}
			get{return _teamnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IgnoreCautionCount
		{
			set{ _ignorecautioncount=value;}
			get{return _ignorecautioncount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsFirstShopSigns
		{
			set{ _isfirstshopsigns=value;}
			get{return _isfirstshopsigns;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsFirstShopList
		{
			set{ _isfirstshoplist=value;}
			get{return _isfirstshoplist;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UpgradeCautionBalance
		{
			set{ _upgradecautionbalance=value;}
			get{return _upgradecautionbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpgradeCautionUrl
		{
			set{ _upgradecautionurl=value;}
			get{return _upgradecautionurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ViewCount
		{
			set{ _viewcount=value;}
			get{return _viewcount;}
		}
		#endregion Model

	}
}

