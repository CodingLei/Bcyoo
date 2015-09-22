/**  版本信息模板在安装目录下，可自行修改。
* V_ActivityFull_Spike.cs
*
* 功 能： N/A
* 类 名： V_ActivityFull_Spike
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:45   N/A    初版
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
	public partial class V_ActivityFull_Spike
	{
		public V_ActivityFull_Spike()
		{}
		#region Model
		private int _idplus;
		private DateTime? _addtime;
		private bool _delstatus;
		private string _name;
		private decimal? _fullmoney;
		private int? _activitycouponid;
		private decimal? _reducemoney;
		private DateTime? _begintime;
		private DateTime? _endtime;
		private string _skus;
		private bool _isall;
		private bool _ishp;
		private string _id;
		private int? _activitytype;
		private int? _sort;
		private string _subtitle;
		private string _url;
		private string _productsku;
		private decimal? _price;
		private int? _limit;
		private int? _specid;
		private int? _spikestock;
		private int? _stock;
		private int? _rebatetype;
		private string _specvalue;
		private string _productname;
		private string _typename;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		/// 
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
		/// <summary>
		/// 
		/// </summary>
		public string ProductSku
		{
			set{ _productsku=value;}
			get{return _productsku;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Limit
		{
			set{ _limit=value;}
			get{return _limit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SpecId
		{
			set{ _specid=value;}
			get{return _specid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SpikeStock
		{
			set{ _spikestock=value;}
			get{return _spikestock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Stock
		{
			set{ _stock=value;}
			get{return _stock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RebateType
		{
			set{ _rebatetype=value;}
			get{return _rebatetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SpecValue
		{
			set{ _specvalue=value;}
			get{return _specvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		#endregion Model

	}
}

