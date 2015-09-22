/**  版本信息模板在安装目录下，可自行修改。
* Member_CommissionBalance.cs
*
* 功 能： N/A
* 类 名： Member_CommissionBalance
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:20   N/A    初版
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
	/// 代理金额变动表
	/// </summary>
	[Serializable]
	public partial class Member_CommissionBalance
	{
		public Member_CommissionBalance()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _memberidplus;
		private decimal? _holdmoney=0M;
		private decimal? _availablemoney=0M;
		private decimal? _unavailablemoney=0M;
		private decimal? _withdrawmoney=0M;
		private int? _balancetype;
		private string _remark;
		private int? _commissionidplus;
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
		public DateTime? Addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 代理ID
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 待结算金额
		/// </summary>
		public decimal? HoldMoney
		{
			set{ _holdmoney=value;}
			get{return _holdmoney;}
		}
		/// <summary>
		/// 可提现金额
		/// </summary>
		public decimal? AvailableMoney
		{
			set{ _availablemoney=value;}
			get{return _availablemoney;}
		}
		/// <summary>
		/// 提现中金额
		/// </summary>
		public decimal? UnavailableMoney
		{
			set{ _unavailablemoney=value;}
			get{return _unavailablemoney;}
		}
		/// <summary>
		/// 已提现金额
		/// </summary>
		public decimal? WithdrawMoney
		{
			set{ _withdrawmoney=value;}
			get{return _withdrawmoney;}
		}
		/// <summary>
		/// 记录类型
		/// </summary>
		public int? BalanceType
		{
			set{ _balancetype=value;}
			get{return _balancetype;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CommissionIDPlus
		{
			set{ _commissionidplus=value;}
			get{return _commissionidplus;}
		}
		#endregion Model

	}
}

