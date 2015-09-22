/**  版本信息模板在安装目录下，可自行修改。
* v_MemberOrder.cs
*
* 功 能： N/A
* 类 名： v_MemberOrder
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:02   N/A    初版
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
	public partial class v_MemberOrder
	{
		public v_MemberOrder()
		{}
		#region Model
		private int _idplus;
		private string _id;
		private int? _delstatus;
		private DateTime? _addtime;
		private string _orderno;
		private decimal? _ordermoney;
		private int? _rolegrade;
		private int? _orderstate;
		private int? _onmemberidplus;
		private string _expressno;
		private DateTime? _sendtime;
		private int? _regionidplus;
		private int? _expressidplus;
		private int? _superiorsidplus;
		private string _systemremark;
		private int? _submitidplus;
		private int? _sendidplus;
		private int? _ordertype;
		private int? _memberidplus;
		private DateTime? _collecttime;
		private string _receivename;
		private string _receivephone;
		private string _receiveaddressall;
		private string _payno;
		private int? _paystate;
		private decimal? _paymoney;
		private DateTime? _paytime;
		private int? _defaultexpressidplus;
		private string _expresscompany;
		private string _gradesequence;
		private string _gradesequencevalue;
		private string _name;
		private string _phone;
		private string _weixinid;
		private string _alladdress;
		private string _memberrolename;
		private string _regionname;
		private string _regionphone;
		private string _regionweixinid;
		private string _superiorsname;
		private string _superiorsrolename;
		private string _superiorsphone;
		private string _superiorsweixinid;
		private string _submitname;
		private string _submitphone;
		private string _submitweixinid;
		private string _submitrolename;
		private string _sendname;
		private string _sendphone;
		private string _sendweixinid;
		private string _remark;
		private string _sendrolename;
		private string _onmembername;
		private string _onmemberphone;
		private string _onmemberrolename;
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
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
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
		public decimal? OrderMoney
		{
			set{ _ordermoney=value;}
			get{return _ordermoney;}
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
		public int? OrderState
		{
			set{ _orderstate=value;}
			get{return _orderstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OnMemberIDPlus
		{
			set{ _onmemberidplus=value;}
			get{return _onmemberidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExpressNo
		{
			set{ _expressno=value;}
			get{return _expressno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SendTime
		{
			set{ _sendtime=value;}
			get{return _sendtime;}
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
		public int? ExpressIDPlus
		{
			set{ _expressidplus=value;}
			get{return _expressidplus;}
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
		public string SystemRemark
		{
			set{ _systemremark=value;}
			get{return _systemremark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SubmitIDPlus
		{
			set{ _submitidplus=value;}
			get{return _submitidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SendIDPlus
		{
			set{ _sendidplus=value;}
			get{return _sendidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrderType
		{
			set{ _ordertype=value;}
			get{return _ordertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MemberIDplus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CollectTime
		{
			set{ _collecttime=value;}
			get{return _collecttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveName
		{
			set{ _receivename=value;}
			get{return _receivename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceivePhone
		{
			set{ _receivephone=value;}
			get{return _receivephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveAddressAll
		{
			set{ _receiveaddressall=value;}
			get{return _receiveaddressall;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayNo
		{
			set{ _payno=value;}
			get{return _payno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PayState
		{
			set{ _paystate=value;}
			get{return _paystate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PayMoney
		{
			set{ _paymoney=value;}
			get{return _paymoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PayTime
		{
			set{ _paytime=value;}
			get{return _paytime;}
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
		public string ExpressCompany
		{
			set{ _expresscompany=value;}
			get{return _expresscompany;}
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
		public string AllAddress
		{
			set{ _alladdress=value;}
			get{return _alladdress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MemberRoleName
		{
			set{ _memberrolename=value;}
			get{return _memberrolename;}
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
		public string RegionPhone
		{
			set{ _regionphone=value;}
			get{return _regionphone;}
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
		public string SuperiorsWeixinId
		{
			set{ _superiorsweixinid=value;}
			get{return _superiorsweixinid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SubmitName
		{
			set{ _submitname=value;}
			get{return _submitname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SubmitPhone
		{
			set{ _submitphone=value;}
			get{return _submitphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SubmitWeixinId
		{
			set{ _submitweixinid=value;}
			get{return _submitweixinid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SubmitRoleName
		{
			set{ _submitrolename=value;}
			get{return _submitrolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SendName
		{
			set{ _sendname=value;}
			get{return _sendname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SendPhone
		{
			set{ _sendphone=value;}
			get{return _sendphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SendWeixinId
		{
			set{ _sendweixinid=value;}
			get{return _sendweixinid;}
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
		public string SendRoleName
		{
			set{ _sendrolename=value;}
			get{return _sendrolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string onmembername
		{
			set{ _onmembername=value;}
			get{return _onmembername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string onmemberphone
		{
			set{ _onmemberphone=value;}
			get{return _onmemberphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OnMemberRoleName
		{
			set{ _onmemberrolename=value;}
			get{return _onmemberrolename;}
		}
		#endregion Model

	}
}

