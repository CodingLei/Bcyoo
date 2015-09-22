/**  版本信息模板在安装目录下，可自行修改。
* ProductReturn.cs
*
* 功 能： N/A
* 类 名： ProductReturn
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:36   N/A    初版
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
	/// 产品上传素材表
	/// </summary>
	[Serializable]
	public partial class ProductReturn
	{
		public ProductReturn()
		{}
		#region Model
		private int _idplus;
		private int _delstatus=0;
		private DateTime _addtime;
		private string _shopname="";
		private string _orderno="";
		private string _productskus="";
		private int _tiptype;
		private int _tipstate;
		private decimal _orderpay;
		private decimal _returnmoney;
		private string _returnmember="";
		private string _memberphone="";
		private string _expressno="";
		private int _isfreight=0;
		private decimal _expressbill;
		private string _returnreason="";
		private string _imageupload="";
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
		public int Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
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
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductSkus
		{
			set{ _productskus=value;}
			get{return _productskus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TipType
		{
			set{ _tiptype=value;}
			get{return _tiptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TipState
		{
			set{ _tipstate=value;}
			get{return _tipstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal OrderPay
		{
			set{ _orderpay=value;}
			get{return _orderpay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal ReturnMoney
		{
			set{ _returnmoney=value;}
			get{return _returnmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReturnMember
		{
			set{ _returnmember=value;}
			get{return _returnmember;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MemberPhone
		{
			set{ _memberphone=value;}
			get{return _memberphone;}
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
		public int IsFreight
		{
			set{ _isfreight=value;}
			get{return _isfreight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal ExpressBill
		{
			set{ _expressbill=value;}
			get{return _expressbill;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReturnReason
		{
			set{ _returnreason=value;}
			get{return _returnreason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImageUpload
		{
			set{ _imageupload=value;}
			get{return _imageupload;}
		}
		#endregion Model

	}
}

