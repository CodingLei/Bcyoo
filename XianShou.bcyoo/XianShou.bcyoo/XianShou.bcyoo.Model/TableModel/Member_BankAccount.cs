/**  版本信息模板在安装目录下，可自行修改。
* Member_BankAccount.cs
*
* 功 能： N/A
* 类 名： Member_BankAccount
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:19   N/A    初版
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
	public partial class Member_BankAccount
	{
		public Member_BankAccount()
		{}
		#region Model
		private int _idplus;
		private DateTime? _addtime= DateTime.Now;
		private bool _delstatus= false;
		private int? _memberid;
		private int? _accounttype;
		private string _account;
		private string _accountname;
		private string _bankname;
		private string _branchnetwork="";
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
		public bool Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MemberId
		{
			set{ _memberid=value;}
			get{return _memberid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AccountType
		{
			set{ _accounttype=value;}
			get{return _accounttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Account
		{
			set{ _account=value;}
			get{return _account;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AccountName
		{
			set{ _accountname=value;}
			get{return _accountname;}
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
		/// 开户行网点
		/// </summary>
		public string BranchNetwork
		{
			set{ _branchnetwork=value;}
			get{return _branchnetwork;}
		}
		#endregion Model

	}
}

