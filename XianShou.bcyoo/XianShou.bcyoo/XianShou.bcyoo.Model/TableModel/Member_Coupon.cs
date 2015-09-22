/**  版本信息模板在安装目录下，可自行修改。
* Member_Coupon.cs
*
* 功 能： N/A
* 类 名： Member_Coupon
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:20   N/A    初版
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
	/// 会员优惠券记录
	/// </summary>
	[Serializable]
	public partial class Member_Coupon
	{
		public Member_Coupon()
		{}
		#region Model
		private int _idplus;
		private DateTime? _addtime= DateTime.Now;
		private bool _delstatus= false;
		private int? _activitycouponidplus;
		private int? _memberidplus;
		private string _orderno;
		private int? _membercouponstate=0;
		private string _id= "newid";
		private int? _customeridplus;
		private int _operationidplus=0;
		private bool _ispresented= false;
		private int? _initcustomeridplus;
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
		/// 优惠券ID
		/// </summary>
		public int? ActivityCouponIDPlus
		{
			set{ _activitycouponidplus=value;}
			get{return _activitycouponidplus;}
		}
		/// <summary>
		/// 客户ID
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 订单编号
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 0未使用 1已使用 2不可使用(订单确认前不可使用)
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
		/// 是否被赠送
		/// </summary>
		public bool IsPresented
		{
			set{ _ispresented=value;}
			get{return _ispresented;}
		}
		/// <summary>
		/// 赠送人
		/// </summary>
		public int? InitCustomerIDPlus
		{
			set{ _initcustomeridplus=value;}
			get{return _initcustomeridplus;}
		}
		#endregion Model

	}
}

