/**  版本信息模板在安装目录下，可自行修改。
* V_MemberOrder_Detail_CustomerId.cs
*
* 功 能： N/A
* 类 名： V_MemberOrder_Detail_CustomerId
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:05   N/A    初版
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
	public partial class V_MemberOrder_Detail_CustomerId
	{
		public V_MemberOrder_Detail_CustomerId()
		{}
		#region Model
		private int _idplus;
		private string _id;
		private int? _delstatus;
		private DateTime? _addtime;
		private string _orderno;
		private string _productsku;
		private string _productdesc;
		private decimal? _productprice;
		private int? _productcount;
		private string _productname;
		private int? _specidplus;
		private int? _brandid;
		private int? _dealtype;
		private string _spec;
		private int? _spikeid;
		private int? _customerid;
		private int? _orderstate;
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
		public string ProductSku
		{
			set{ _productsku=value;}
			get{return _productsku;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductDesc
		{
			set{ _productdesc=value;}
			get{return _productdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ProductPrice
		{
			set{ _productprice=value;}
			get{return _productprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProductCount
		{
			set{ _productcount=value;}
			get{return _productcount;}
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
		public int? SpecIDPlus
		{
			set{ _specidplus=value;}
			get{return _specidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BrandId
		{
			set{ _brandid=value;}
			get{return _brandid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DealType
		{
			set{ _dealtype=value;}
			get{return _dealtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Spec
		{
			set{ _spec=value;}
			get{return _spec;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SpikeId
		{
			set{ _spikeid=value;}
			get{return _spikeid;}
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
		public int? OrderState
		{
			set{ _orderstate=value;}
			get{return _orderstate;}
		}
		#endregion Model

	}
}

