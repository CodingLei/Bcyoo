/**  版本信息模板在安装目录下，可自行修改。
* Activity_Full.cs
*
* 功 能： N/A
* 类 名： Activity_Full
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
	/// 满赠优惠券
	/// </summary>
	[Serializable]
	public partial class Activity_Full
	{
		public Activity_Full()
		{}
		#region Model
		private int _idplus;
		private DateTime? _addtime= DateTime.Now;
		private bool _delstatus= false;
		private string _name;
		private decimal? _fullmoney;
		private int? _activitycouponid;
		private decimal? _reducemoney;
		private DateTime? _begintime;
		private DateTime? _endtime;
		private string _skus;
		private bool _isall;
		private bool _ishp;
		private string _id= "newid";
		private int? _activitytype;
		private int? _sort;
		private string _subtitle;
		private string _url;
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
		/// 优惠券名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 购满金额
		/// </summary>
		public decimal? FullMoney
		{
			set{ _fullmoney=value;}
			get{return _fullmoney;}
		}
		/// <summary>
		/// 优惠券ID
		/// </summary>
		public int? ActivityCouponId
		{
			set{ _activitycouponid=value;}
			get{return _activitycouponid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ReduceMoney
		{
			set{ _reducemoney=value;}
			get{return _reducemoney;}
		}
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime? BeginTime
		{
			set{ _begintime=value;}
			get{return _begintime;}
		}
		/// <summary>
		/// 结束时间
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
		public bool IsHP
		{
			set{ _ishp=value;}
			get{return _ishp;}
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
		/// 1.满减2满赠3满赠优惠券4特价
		/// </summary>
		public int? ActivityType
		{
			set{ _activitytype=value;}
			get{return _activitytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sort
		{
			set{ _sort=value;}
			get{return _sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SubTitle
		{
			set{ _subtitle=value;}
			get{return _subtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Url
		{
			set{ _url=value;}
			get{return _url;}
		}
		#endregion Model

	}
}

