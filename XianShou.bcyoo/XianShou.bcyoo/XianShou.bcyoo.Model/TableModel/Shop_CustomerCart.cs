/**  版本信息模板在安装目录下，可自行修改。
* Shop_CustomerCart.cs
*
* 功 能： N/A
* 类 名： Shop_CustomerCart
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:41   N/A    初版
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
	public partial class Shop_CustomerCart
	{
		public Shop_CustomerCart()
		{}
		#region Model
		private int _cartid;
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _customerid;
		private int? _shopid;
		private string _openid;
		private string _skus;
		private string _nums;
		private string _products;
		private string _dealtypes;
		/// <summary>
		/// 
		/// </summary>
		public int CartId
		{
			set{ _cartid=value;}
			get{return _cartid;}
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
		public int? CustomerId
		{
			set{ _customerid=value;}
			get{return _customerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ShopId
		{
			set{ _shopid=value;}
			get{return _shopid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OpenId
		{
			set{ _openid=value;}
			get{return _openid;}
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
		public string Nums
		{
			set{ _nums=value;}
			get{return _nums;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Products
		{
			set{ _products=value;}
			get{return _products;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DealTypes
		{
			set{ _dealtypes=value;}
			get{return _dealtypes;}
		}
		#endregion Model

	}
}

