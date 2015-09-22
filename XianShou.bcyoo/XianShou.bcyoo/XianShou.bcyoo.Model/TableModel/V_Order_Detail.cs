/**  版本信息模板在安装目录下，可自行修改。
* V_Order_Detail.cs
*
* 功 能： N/A
* 类 名： V_Order_Detail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:10   N/A    初版
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
	public partial class V_Order_Detail
	{
		public V_Order_Detail()
		{}
		#region Model
		private string _name;
		private string _phone;
		private string _province;
		private string _city;
		private string _area;
		private string _address;
		private int? _rolegrade;
		private int? _ordertype;
		private string _receivename;
		private string _receiveprovince;
		private string _receiveaddress;
		private string _receivecity;
		private string _receivearea;
		private string _receivephone;
		private string _orderno;
		private decimal? _ordermoney;
		private int? _orderstate;
		private DateTime? _addtime;
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string city
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string area
		{
			set{ _area=value;}
			get{return _area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? rolegrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ordertype
		{
			set{ _ordertype=value;}
			get{return _ordertype;}
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
		public string ReceiveProvince
		{
			set{ _receiveprovince=value;}
			get{return _receiveprovince;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveAddress
		{
			set{ _receiveaddress=value;}
			get{return _receiveaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveCity
		{
			set{ _receivecity=value;}
			get{return _receivecity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveArea
		{
			set{ _receivearea=value;}
			get{return _receivearea;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceivePhone
		{
			set{ _receivephone=value;}
			get{return _receivephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orderno
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ordermoney
		{
			set{ _ordermoney=value;}
			get{return _ordermoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? orderstate
		{
			set{ _orderstate=value;}
			get{return _orderstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

