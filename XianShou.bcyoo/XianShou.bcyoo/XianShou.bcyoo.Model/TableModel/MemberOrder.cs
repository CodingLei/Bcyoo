/**  版本信息模板在安装目录下，可自行修改。
* MemberOrder.cs
*
* 功 能： N/A
* 类 名： MemberOrder
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:27   N/A    初版
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
	/// 订单表
	/// </summary>
	[Serializable]
	public partial class MemberOrder
	{
		public MemberOrder()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _superiorsidplus;
		private int? _regionidplus;
		private int? _rolegrade;
		private int? _memberidplus;
		private int? _onmemberidplus;
		private int? _submitidplus;
		private DateTime? _collecttime= DateTime.Now;
		private int? _customerid=0;
		private string _payno;
		private int? _paystate=0;
		private decimal? _paymoney;
		private DateTime? _paytime;
		private int? _isvip;
		private int? _isorderdiscount;
		private decimal? _orderpreference;
		private decimal? _ordermoney;
		private string _orderno;
		private int? _ordertype=0;
		private int? _orderstate=0;
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
		private int? _iscansend=0;
		private int? _addressid=0;
		private decimal? _fullreducemoney=0M;
		private decimal? _activitycouponmoney=0M;
		private string _membercouponid= "0";
		private int? _commentstate=0;
		private DateTime _receivetime= Convert.ToDateTime("2000-01-01 00:00:00.000");
		private int? _activityfullid;
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
		/// 添加时间
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 上级IDPlus
		/// </summary>
		public int? SuperiorsIDPlus
		{
			set{ _superiorsidplus=value;}
			get{return _superiorsidplus;}
		}
		/// <summary>
		/// 大区IDPlus
		/// </summary>
		public int? RegionIDPlus
		{
			set{ _regionidplus=value;}
			get{return _regionidplus;}
		}
		/// <summary>
		/// 角色等级IDPlus，与Member_Role里面Grade对应
		/// </summary>
		public int? RoleGrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
		}
		/// <summary>
		/// 下单人IDPlus
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 订单所在人
		/// </summary>
		public int? OnMemberIDPlus
		{
			set{ _onmemberidplus=value;}
			get{return _onmemberidplus;}
		}
		/// <summary>
		/// 递交人
		/// </summary>
		public int? SubmitIDPlus
		{
			set{ _submitidplus=value;}
			get{return _submitidplus;}
		}
		/// <summary>
		/// 汇总时间
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
		/// 订单状态
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
		/// 订单金额
		/// </summary>
		public decimal? OrderMoney
		{
			set{ _ordermoney=value;}
			get{return _ordermoney;}
		}
		/// <summary>
		/// 订单号
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 订单类型
		/// </summary>
		public int? OrderType
		{
			set{ _ordertype=value;}
			get{return _ordertype;}
		}
		/// <summary>
		/// 订单状态
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
		/// 邮费
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
		/// 物流单号
		/// </summary>
		public string ExpressNo
		{
			set{ _expressno=value;}
			get{return _expressno;}
		}
		/// <summary>
		/// 发货人
		/// </summary>
		public int? SendIDPlus
		{
			set{ _sendidplus=value;}
			get{return _sendidplus;}
		}
		/// <summary>
		/// 发货时间
		/// </summary>
		public DateTime? SendTime
		{
			set{ _sendtime=value;}
			get{return _sendtime;}
		}
		/// <summary>
		/// 取消人IDPlus
		/// </summary>
		public int? CancleCheckIDPlus
		{
			set{ _canclecheckidplus=value;}
			get{return _canclecheckidplus;}
		}
		/// <summary>
		/// 取消时间
		/// </summary>
		public DateTime? CancleTime
		{
			set{ _cancletime=value;}
			get{return _cancletime;}
		}
		/// <summary>
		/// 取消原因
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
		/// 系统备注
		/// </summary>
		public string SystemRemark
		{
			set{ _systemremark=value;}
			get{return _systemremark;}
		}
		/// <summary>
		/// 订单备注
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
		public int? ActivityFullId
		{
			set{ _activityfullid=value;}
			get{return _activityfullid;}
		}
		#endregion Model

	}
}

