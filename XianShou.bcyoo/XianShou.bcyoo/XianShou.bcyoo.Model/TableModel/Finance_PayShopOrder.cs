/**  版本信息模板在安装目录下，可自行修改。
* Finance_PayShopOrder.cs
*
* 功 能： N/A
* 类 名： Finance_PayShopOrder
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:12   N/A    初版
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
	/// 职位权限表
	/// </summary>
	[Serializable]
	public partial class Finance_PayShopOrder
	{
		public Finance_PayShopOrder()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private DateTime? _addtime= DateTime.Now;
		private int? _delstatus=0;
		private int? _paytype;
		private string _orderno;
		private string _payno;
		private decimal? _paymoney;
		private int? _financestate;
		private string _banktype;
		private int? _operateid;
		private int? _clientid;
		private string _remark;
		private DateTime? _authtime;
		/// <summary>
		/// 
		/// </summary>
		public int IdPlus
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
		public int? Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
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
		public string PayNo
		{
			set{ _payno=value;}
			get{return _payno;}
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
		public int? FinanceState
		{
			set{ _financestate=value;}
			get{return _financestate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BankType
		{
			set{ _banktype=value;}
			get{return _banktype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperateId
		{
			set{ _operateid=value;}
			get{return _operateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ClientId
		{
			set{ _clientid=value;}
			get{return _clientid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AuthTime
		{
			set{ _authtime=value;}
			get{return _authtime;}
		}
		#endregion Model

	}
}

