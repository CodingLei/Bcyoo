/**  版本信息模板在安装目录下，可自行修改。
* V_Member_CommissionBalance.cs
*
* 功 能： N/A
* 类 名： V_Member_CommissionBalance
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:53   N/A    初版
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
	public partial class V_Member_CommissionBalance
	{
		public V_Member_CommissionBalance()
		{}
		#region Model
		private int? _balancetype;
		private decimal? _holdmoney;
		private decimal? _availablemoney;
		private decimal? _unavailablemoney;
		private decimal? _withdrawmoney;
		private DateTime? _addtime;
		/// <summary>
		/// 
		/// </summary>
		public int? BalanceType
		{
			set{ _balancetype=value;}
			get{return _balancetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? HoldMoney
		{
			set{ _holdmoney=value;}
			get{return _holdmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AvailableMoney
		{
			set{ _availablemoney=value;}
			get{return _availablemoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UnavailableMoney
		{
			set{ _unavailablemoney=value;}
			get{return _unavailablemoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WithdrawMoney
		{
			set{ _withdrawmoney=value;}
			get{return _withdrawmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

