/**  版本信息模板在安装目录下，可自行修改。
* Activity_Spike.cs
*
* 功 能： N/A
* 类 名： Activity_Spike
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:09   N/A    初版
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
	/// 满赠优惠细表
	/// </summary>
	[Serializable]
	public partial class Activity_Spike
	{
		public Activity_Spike()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private DateTime? _addtime;
		private bool _delstatus= false;
		private int? _activityfullid;
		private string _productsku;
		private decimal? _price;
		private int? _stock;
		private int? _specid;
		private int? _spikestock;
		private int? _limit;
		private int? _rebatetype;
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
		/// 
		/// </summary>
		public int? ActivityFullId
		{
			set{ _activityfullid=value;}
			get{return _activityfullid;}
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
		public int? Stock
		{
			set{ _stock=value;}
			get{return _stock;}
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
		public int? Limit
		{
			set{ _limit=value;}
			get{return _limit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RebateType
		{
			set{ _rebatetype=value;}
			get{return _rebatetype;}
		}
		#endregion Model

	}
}

