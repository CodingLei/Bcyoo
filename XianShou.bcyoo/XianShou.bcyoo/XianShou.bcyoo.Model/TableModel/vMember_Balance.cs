/**  版本信息模板在安装目录下，可自行修改。
* vMember_Balance.cs
*
* 功 能： N/A
* 类 名： vMember_Balance
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:26   N/A    初版
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
	public partial class vMember_Balance
	{
		public vMember_Balance()
		{}
		#region Model
		private int _idplus;
		private string _id;
		private DateTime? _addtime;
		private int? _delstatus;
		private decimal? _balancecount;
		private decimal? _lave;
		private int? _flag;
		private int? _state;
		private int? _memberidplus;
		private int? _rolegrade;
		private int? _regionidplus;
		private int? _superiorsidplus;
		private int? _checkmemberidplus;
		private string _orderno;
		private string _gradesequence;
		private string _remark;
		private int? _checkemployeeidplus;
		private string _name;
		private decimal? _balance;
		private string _rolename;
		private string _phone;
		private string _weixinid;
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
		public decimal? BalanceCount
		{
			set{ _balancecount=value;}
			get{return _balancecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Lave
		{
			set{ _lave=value;}
			get{return _lave;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
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
		public int? RoleGrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
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
		public int? SuperiorsIDPlus
		{
			set{ _superiorsidplus=value;}
			get{return _superiorsidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CheckMemberIDPlus
		{
			set{ _checkmemberidplus=value;}
			get{return _checkmemberidplus;}
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
		public string GradeSequence
		{
			set{ _gradesequence=value;}
			get{return _gradesequence;}
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
		public int? CheckEmployeeIDPlus
		{
			set{ _checkemployeeidplus=value;}
			get{return _checkemployeeidplus;}
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
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
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
		#endregion Model

	}
}

