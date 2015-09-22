/**  版本信息模板在安装目录下，可自行修改。
* V_MemberOrder_Detail_Product.cs
*
* 功 能： N/A
* 类 名： V_MemberOrder_Detail_Product
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:06   N/A    初版
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
	public partial class V_MemberOrder_Detail_Product
	{
		public V_MemberOrder_Detail_Product()
		{}
		#region Model
		private int _idplus;
		private int? _delstatus;
		private DateTime? _addtime;
		private int? _customerid;
		private int? _memberidplus;
		private string _payno;
		private int? _paystate;
		private decimal? _paymoney;
		private DateTime? _paytime;
		private decimal? _ordermoney;
		private string _orderno;
		private int? _ordertype;
		private int? _orderstate;
		private string _receivename;
		private int? _expressidplus;
		private string _expressno;
		private string _sopenid;
		private string _nickname;
		private string _mobile;
		private string _mopenid;
		private string _shopno;
		private string _shopname;
		private string _headurl;
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
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
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
		public string SOpenID
		{
			set{ _sopenid=value;}
			get{return _sopenid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MOpenID
		{
			set{ _mopenid=value;}
			get{return _mopenid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShopNo
		{
			set{ _shopno=value;}
			get{return _shopno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShopName
		{
			set{ _shopname=value;}
			get{return _shopname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeadUrl
		{
			set{ _headurl=value;}
			get{return _headurl;}
		}
		#endregion Model

	}
}

