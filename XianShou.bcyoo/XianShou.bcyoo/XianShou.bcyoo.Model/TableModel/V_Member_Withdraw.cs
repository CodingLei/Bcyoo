/**  版本信息模板在安装目录下，可自行修改。
* V_Member_Withdraw.cs
*
* 功 能： N/A
* 类 名： V_Member_Withdraw
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:59   N/A    初版
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
	public partial class V_Member_Withdraw
	{
		public V_Member_Withdraw()
		{}
		#region Model
		private int _idplus;
		private DateTime? _addtime;
		private int? _delstatus;
		private int? _memberidplus;
		private decimal? _balance;
		private int? _withdrawstate;
		private string _commissionidpluses;
		private DateTime _checktime;
		private int _checkidplus;
		private int? _bankaccounttype;
		private string _bankaccount;
		private string _bankaccountname;
		private string _bankname;
		private string _remark;
		private string _name;
		private string _phone;
		private string _weixinid;
		private int? _regionidplus;
		private string _rolename;
		private string _checkname;
		private int? _isexport;
		private DateTime? _exporttime;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		public string WeixinId
		{
			set{ _weixinid=value;}
			get{return _weixinid;}
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
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckName
		{
			set{ _checkname=value;}
			get{return _checkname;}
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

