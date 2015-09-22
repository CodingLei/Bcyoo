/**  版本信息模板在安装目录下，可自行修改。
* V_CheckCenter.cs
*
* 功 能： N/A
* 类 名： V_CheckCenter
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:48   N/A    初版
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
	public partial class V_CheckCenter
	{
		public V_CheckCenter()
		{}
		#region Model
		private long? _rownum;
		private int? _memberidplus;
		private int? _superiorsidplus;
		private decimal? _backbalance;
		private decimal? _rechargebalance;
		private decimal? _submitorderbalance;
		private decimal? _collectorderbalance;
		private decimal? _deductbalance;
		private decimal? _cancelorderbalance;
		private decimal? _cancelcollectbalance;
		private string _name;
		private decimal? _balance;
		private string _phone;
		private int? _applystate;
		private string _rolename;
		private decimal? _markreducebalance;
		private decimal? _creditlimitbalance;
		private int? _nowsuperiorsidplus;
		private int? _rolegrade;
		private decimal? _goodsbalance;
		private string _supername;
		private decimal? _lowcurrentallbalance;
		/// <summary>
		/// 
		/// </summary>
		public long? RowNum
		{
			set{ _rownum=value;}
			get{return _rownum;}
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
		public int? SuperiorsIDPlus
		{
			set{ _superiorsidplus=value;}
			get{return _superiorsidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BackBalance
		{
			set{ _backbalance=value;}
			get{return _backbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RechargeBalance
		{
			set{ _rechargebalance=value;}
			get{return _rechargebalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? submitOrderBalance
		{
			set{ _submitorderbalance=value;}
			get{return _submitorderbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CollectOrderBalance
		{
			set{ _collectorderbalance=value;}
			get{return _collectorderbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DeductBalance
		{
			set{ _deductbalance=value;}
			get{return _deductbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CancelOrderBalance
		{
			set{ _cancelorderbalance=value;}
			get{return _cancelorderbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CancelCollectBalance
		{
			set{ _cancelcollectbalance=value;}
			get{return _cancelcollectbalance;}
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
		public decimal? Balance
		{
			set{ _balance=value;}
			get{return _balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ApplyState
		{
			set{ _applystate=value;}
			get{return _applystate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MarkReduceBalance
		{
			set{ _markreducebalance=value;}
			get{return _markreducebalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CreditLimitBalance
		{
			set{ _creditlimitbalance=value;}
			get{return _creditlimitbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NowSuperiorsIDPlus
		{
			set{ _nowsuperiorsidplus=value;}
			get{return _nowsuperiorsidplus;}
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
		public decimal? GoodsBalance
		{
			set{ _goodsbalance=value;}
			get{return _goodsbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SuperName
		{
			set{ _supername=value;}
			get{return _supername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LowCurrentAllBalance
		{
			set{ _lowcurrentallbalance=value;}
			get{return _lowcurrentallbalance;}
		}
		#endregion Model

	}
}

