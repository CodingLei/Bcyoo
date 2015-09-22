/**  版本信息模板在安装目录下，可自行修改。
* V_MemberOrder_MemberOrder_Commission.cs
*
* 功 能： N/A
* 类 名： V_MemberOrder_MemberOrder_Commission
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:07   N/A    初版
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
	public partial class V_MemberOrder_MemberOrder_Commission
	{
		public V_MemberOrder_MemberOrder_Commission()
		{}
		#region Model
		private int _idplus;
		private string _id;
		private int? _delstatus;
		private DateTime? _addtime;
		private int? _superiorsidplus;
		private int? _regionidplus;
		private int? _rolegrade;
		private int? _memberidplus;
		private int? _onmemberidplus;
		private int? _submitidplus;
		private DateTime? _collecttime;
		private int? _customerid;
		private string _payno;
		private int? _paystate;
		private decimal? _paymoney;
		private DateTime? _paytime;
		private int? _isvip;
		private int? _isorderdiscount;
		private decimal? _orderpreference;
		private decimal? _ordermoney;
		private string _orderno;
		private int? _ordertype;
		private int? _orderstate;
		private string _receivename;
		private string _receivephone;
		private string _receiveprovince;
		private string _receivecity;
		private string _receivearea;
		private string _receiveaddress;
		private int? _isexpress;
		private decimal? _postagemoney;
		private int? _expressidplus;
		private string _expressno;
		private int? _sendidplus;
		private DateTime? _sendtime;
		private int? _canclecheckidplus;
		private DateTime? _cancletime;
		private string _canclereason;
		private string _gradesequence;
		private string _gradesequencevalue;
		private string _systemremark;
		private string _remark;
		private int? _iscansend;
		private int? _addressid;
		private decimal? _fullreducemoney;
		private decimal? _activitycouponmoney;
		private string _membercouponid;
		private int? _commentstate;
		private DateTime _receivetime;
		private decimal _rebatbalance;
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
		public int? SuperiorsIDPlus
		{
			set{ _superiorsidplus=value;}
			get{return _superiorsidplus;}
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
		public int? RoleGrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
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
		public int? OnMemberIDPlus
		{
			set{ _onmemberidplus=value;}
			get{return _onmemberidplus;}
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
		public DateTime? CollectTime
		{
			set{ _collecttime=value;}
			get{return _collecttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CustomerId
		{
			set{ _customerid=value;}
			get{return _customerid;}
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
		public int? IsVIP
		{
			set{ _isvip=value;}
			get{return _isvip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsOrderDiscount
		{
			set{ _isorderdiscount=value;}
			get{return _isorderdiscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OrderPreference
		{
			set{ _orderpreference=value;}
			get{return _orderpreference;}
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
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
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
		public int? OrderState
		{
			set{ _orderstate=value;}
			get{return _orderstate;}
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
		public string ReceiveProvince
		{
			set{ _receiveprovince=value;}
			get{return _receiveprovince;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveCity
		{
			set{ _receivecity=value;}
			get{return _receivecity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveArea
		{
			set{ _receivearea=value;}
			get{return _receivearea;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveAddress
		{
			set{ _receiveaddress=value;}
			get{return _receiveaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsExpress
		{
			set{ _isexpress=value;}
			get{return _isexpress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PostageMoney
		{
			set{ _postagemoney=value;}
			get{return _postagemoney;}
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
		public string ExpressNo
		{
			set{ _expressno=value;}
			get{return _expressno;}
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
		public DateTime? SendTime
		{
			set{ _sendtime=value;}
			get{return _sendtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CancleCheckIDPlus
		{
			set{ _canclecheckidplus=value;}
			get{return _canclecheckidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CancleTime
		{
			set{ _cancletime=value;}
			get{return _cancletime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CancleReason
		{
			set{ _canclereason=value;}
			get{return _canclereason;}
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
		public string SystemRemark
		{
			set{ _systemremark=value;}
			get{return _systemremark;}
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
		public int? IsCanSend
		{
			set{ _iscansend=value;}
			get{return _iscansend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AddressId
		{
			set{ _addressid=value;}
			get{return _addressid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FullReduceMoney
		{
			set{ _fullreducemoney=value;}
			get{return _fullreducemoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ActivityCouponMoney
		{
			set{ _activitycouponmoney=value;}
			get{return _activitycouponmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MemberCouponId
		{
			set{ _membercouponid=value;}
			get{return _membercouponid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CommentState
		{
			set{ _commentstate=value;}
			get{return _commentstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ReceiveTime
		{
			set{ _receivetime=value;}
			get{return _receivetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal RebatBalance
		{
			set{ _rebatbalance=value;}
			get{return _rebatbalance;}
		}
		#endregion Model

	}
}

