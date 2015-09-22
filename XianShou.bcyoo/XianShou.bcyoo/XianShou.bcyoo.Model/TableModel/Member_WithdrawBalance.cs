/**  版本信息模板在安装目录下，可自行修改。
* Member_WithdrawBalance.cs
*
* 功 能： N/A
* 类 名： Member_WithdrawBalance
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:26   N/A    初版
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
	/// 代理等级表
	/// </summary>
	[Serializable]
	public partial class Member_WithdrawBalance
	{
		public Member_WithdrawBalance()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _memberidplus;
		private decimal? _balance;
		private int? _withdrawstate;
		private int? _bankaccounttype;
		private string _bankaccount;
		private string _bankaccountname;
		private string _bankname;
		private string _remark;
		private string _commissionidpluses;
		private DateTime _checktime= Convert.ToDateTime("2000-01-01 00:00:00.000");
		private int _checkidplus=0;
		private int? _isexport=0;
		private DateTime? _exporttime= Convert.ToDateTime("2000-01-01 00:00:00.000");
		private string _branchnetwork;
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
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
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
		public int? WithdrawState
		{
			set{ _withdrawstate=value;}
			get{return _withdrawstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BankAccountType
		{
			set{ _bankaccounttype=value;}
			get{return _bankaccounttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BankAccount
		{
			set{ _bankaccount=value;}
			get{return _bankaccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BankAccountName
		{
			set{ _bankaccountname=value;}
			get{return _bankaccountname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BankName
		{
			set{ _bankname=value;}
			get{return _bankname;}
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
		public string CommissionIDPluses
		{
			set{ _commissionidpluses=value;}
			get{return _commissionidpluses;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CheckTime
		{
			set{ _checktime=value;}
			get{return _checktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CheckIDPlus
		{
			set{ _checkidplus=value;}
			get{return _checkidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsExport
		{
			set{ _isexport=value;}
			get{return _isexport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ExportTime
		{
			set{ _exporttime=value;}
			get{return _exporttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BranchNetwork
		{
			set{ _branchnetwork=value;}
			get{return _branchnetwork;}
		}
		#endregion Model

	}
}

