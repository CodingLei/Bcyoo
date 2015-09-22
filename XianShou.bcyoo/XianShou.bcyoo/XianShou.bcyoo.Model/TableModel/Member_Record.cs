/**  版本信息模板在安装目录下，可自行修改。
* Member_Record.cs
*
* 功 能： N/A
* 类 名： Member_Record
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:24   N/A    初版
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
	/// 代理商页面显示菜单表
	/// </summary>
	[Serializable]
	public partial class Member_Record
	{
		public Member_Record()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _memberidplus;
		private int? _recordtype;
		private int? _originalstate;
		private int? _currentstate;
		private int? _originalrolegrade;
		private int? _currentrolegrade;
		private int? _originalregionidplus;
		private int? _currentregionidplus;
		private int? _originalsuperioridplus;
		private int? _currentsuperioridplus;
		private string _ip;
		private string _remark;
		private int? _originalrolegradetype=0;
		private int? _currentrolegradetype=0;
		private int? _operationidplus=0;
		private int? _operationusertype=0;
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
		public int? RecordType
		{
			set{ _recordtype=value;}
			get{return _recordtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OriginalState
		{
			set{ _originalstate=value;}
			get{return _originalstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CurrentState
		{
			set{ _currentstate=value;}
			get{return _currentstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OriginalRoleGrade
		{
			set{ _originalrolegrade=value;}
			get{return _originalrolegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CurrentRoleGrade
		{
			set{ _currentrolegrade=value;}
			get{return _currentrolegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OriginalRegionIDPlus
		{
			set{ _originalregionidplus=value;}
			get{return _originalregionidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CurrentRegionIDPlus
		{
			set{ _currentregionidplus=value;}
			get{return _currentregionidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OriginalSuperiorIDPlus
		{
			set{ _originalsuperioridplus=value;}
			get{return _originalsuperioridplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CurrentSuperiorIDPlus
		{
			set{ _currentsuperioridplus=value;}
			get{return _currentsuperioridplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
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
		public int? OriginalRoleGradeType
		{
			set{ _originalrolegradetype=value;}
			get{return _originalrolegradetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CurrentRoleGradeType
		{
			set{ _currentrolegradetype=value;}
			get{return _currentrolegradetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperationIDPlus
		{
			set{ _operationidplus=value;}
			get{return _operationidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperationUserType
		{
			set{ _operationusertype=value;}
			get{return _operationusertype;}
		}
		#endregion Model

	}
}

