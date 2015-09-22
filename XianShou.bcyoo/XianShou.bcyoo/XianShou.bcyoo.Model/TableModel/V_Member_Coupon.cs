/**  版本信息模板在安装目录下，可自行修改。
* V_Member_Coupon.cs
*
* 功 能： N/A
* 类 名： V_Member_Coupon
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:53   N/A    初版
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
	public partial class V_Member_Coupon
	{
		public V_Member_Coupon()
		{}
		#region Model
		private int _idplus;
		private DateTime? _addtime;
		private bool _delstatus;
		private int? _activitycouponidplus;
		private int? _memberidplus;
		private string _orderno;
		private int? _membercouponstate;
		private string _id;
		private int? _customeridplus;
		private int _operationidplus;
		private string _couponname;
		private string _code;
		private decimal? _fullmoney;
		private decimal? _couponmoney;
		private DateTime? _begintime;
		private DateTime? _endtime;
		private string _skus;
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
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ActivityCouponIDPlus
		{
			set{ _activitycouponidplus=value;}
			get{return _activitycouponidplus;}
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
		public int? MemberCouponState
		{
			set{ _membercouponstate=value;}
			get{return _membercouponstate;}
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
		public int? CustomerIDPlus
		{
			set{ _customeridplus=value;}
			get{return _customeridplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OperationIDPlus
		{
			set{ _operationidplus=value;}
			get{return _operationidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CouponName
		{
			set{ _couponname=value;}
			get{return _couponname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FullMoney
		{
			set{ _fullmoney=value;}
			get{return _fullmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CouponMoney
		{
			set{ _couponmoney=value;}
			get{return _couponmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BeginTime
		{
			set{ _begintime=value;}
			get{return _begintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Skus
		{
			set{ _skus=value;}
			get{return _skus;}
		}
		#endregion Model

	}
}

