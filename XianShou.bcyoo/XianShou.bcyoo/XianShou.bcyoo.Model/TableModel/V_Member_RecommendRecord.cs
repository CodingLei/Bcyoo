/**  版本信息模板在安装目录下，可自行修改。
* V_Member_RecommendRecord.cs
*
* 功 能： N/A
* 类 名： V_Member_RecommendRecord
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:56   N/A    初版
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
	public partial class V_Member_RecommendRecord
	{
		public V_Member_RecommendRecord()
		{}
		#region Model
		private int _idplus;
		private DateTime? _addtime;
		private string _id;
		private int? _delstatus;
		private int? _memberidplus;
		private int? _rolegrade;
		private int? _rolegradetype;
		private int? _superiorsidplus;
		private int? _regionidplus;
		private int? _recommendmemberidplus;
		private int? _recommendregionidplus;
		private int? _recommendrolegrade;
		private int? _recommendrolegradetype;
		private int? _recommendsuperiorsidplus;
		private int? _checkstate;
		private DateTime? _checktime;
		private string _name;
		private string _rolename;
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
		public int? RoleGradeType
		{
			set{ _rolegradetype=value;}
			get{return _rolegradetype;}
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
		public int? RecommendMemberIDPlus
		{
			set{ _recommendmemberidplus=value;}
			get{return _recommendmemberidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RecommendRegionIDPlus
		{
			set{ _recommendregionidplus=value;}
			get{return _recommendregionidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RecommendRoleGrade
		{
			set{ _recommendrolegrade=value;}
			get{return _recommendrolegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RecommendRoleGradeType
		{
			set{ _recommendrolegradetype=value;}
			get{return _recommendrolegradetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RecommendSuperiorsIDPlus
		{
			set{ _recommendsuperiorsidplus=value;}
			get{return _recommendsuperiorsidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CheckState
		{
			set{ _checkstate=value;}
			get{return _checkstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CheckTime
		{
			set{ _checktime=value;}
			get{return _checktime;}
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
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		#endregion Model

	}
}

