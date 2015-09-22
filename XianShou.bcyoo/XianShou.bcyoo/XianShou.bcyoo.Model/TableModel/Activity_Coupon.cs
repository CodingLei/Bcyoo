/**  版本信息模板在安装目录下，可自行修改。
* Activity_Coupon.cs
*
* 功 能： N/A
* 类 名： Activity_Coupon
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:08   N/A    初版
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
	/// 优惠券
	/// </summary>
	[Serializable]
	public partial class Activity_Coupon
	{
		public Activity_Coupon()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private DateTime? _addtime= DateTime.Now;
		private bool _delstatus= false;
		private string _couponname;
		private string _code;
		private decimal? _fullmoney;
		private decimal? _couponmoney;
		private DateTime? _begintime;
		private DateTime? _endtime;
		private int? _leavecount;
		private string _skus;
		private bool _isall;
		private int _couponcount=0;
		private bool _ispresented= false;
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
		/// 优惠券名称
		/// </summary>
		public string CouponName
		{
			set{ _couponname=value;}
			get{return _couponname;}
		}
		/// <summary>
		/// 优惠券编码
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 满购金额
		/// </summary>
		public decimal? FullMoney
		{
			set{ _fullmoney=value;}
			get{return _fullmoney;}
		}
		/// <summary>
		/// 优惠券金额
		/// </summary>
		public decimal? CouponMoney
		{
			set{ _couponmoney=value;}
			get{return _couponmoney;}
		}
		/// <summary>
		/// 优惠券开始时间
		/// </summary>
		public DateTime? BeginTime
		{
			set{ _begintime=value;}
			get{return _begintime;}
		}
		/// <summary>
		/// 优惠券有效时间
		/// </summary>
		public DateTime? EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LeaveCount
		{
			set{ _leavecount=value;}
			get{return _leavecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Skus
		{
			set{ _skus=value;}
			get{return _skus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsAll
		{
			set{ _isall=value;}
			get{return _isall;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CouponCount
		{
			set{ _couponcount=value;}
			get{return _couponcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsPresented
		{
			set{ _ispresented=value;}
			get{return _ispresented;}
		}
		#endregion Model

	}
}

