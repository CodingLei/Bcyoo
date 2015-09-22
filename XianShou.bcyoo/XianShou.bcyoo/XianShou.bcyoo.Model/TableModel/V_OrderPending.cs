/**  版本信息模板在安装目录下，可自行修改。
* V_OrderPending.cs
*
* 功 能： N/A
* 类 名： V_OrderPending
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:13   N/A    初版
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
	public partial class V_OrderPending
	{
		public V_OrderPending()
		{}
		#region Model
		private int _idplus;
		private string _id;
		private int? _delstatus;
		private DateTime? _addtime;
		private int? _orderstate;
		private string _orderno;
		private int? _ordertype;
		private decimal? _paymoney;
		private decimal? _ordermoney;
		private decimal? _postagemoney;
		private int? _memberidplus;
		private int? _onmemberidplus;
		private int? _submitidplus;
		private int? _superiorsidplus;
		private int? _regionidplus;
		private int? _rolegrade;
		private string _receivename;
		private string _receivephone;
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
		public int? OrderState
		{
			set{ _orderstate=value;}
			get{return _orderstate;}
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
		public decimal? PayMoney
		{
			set{ _paymoney=value;}
			get{return _paymoney;}
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
		public decimal? PostageMoney
		{
			set{ _postagemoney=value;}
			get{return _postagemoney;}
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
		public int? OnMemberIDPlus
		{
			set{ _onmemberidplus=value;}
			get{return _onmemberidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SubmitIDPlus
		{
			set{ _submitidplus=value;}
			get{return _submitidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SuperiorsIDPlus
		{
			set{ _superiorsidplus=value;}
			get{return _superiorsidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RegionIDPlus
		{
			set{ _regionidplus=value;}
			get{return _regionidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleGrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
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
		public string ReceivePhone
		{
			set{ _receivephone=value;}
			get{return _receivephone;}
		}
		#endregion Model

	}
}

