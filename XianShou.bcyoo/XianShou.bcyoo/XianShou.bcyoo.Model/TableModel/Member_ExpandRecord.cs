/**  版本信息模板在安装目录下，可自行修改。
* Member_ExpandRecord.cs
*
* 功 能： N/A
* 类 名： Member_ExpandRecord
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
	/// 会员优惠券记录
	/// </summary>
	[Serializable]
	public partial class Member_ExpandRecord
	{
		public Member_ExpandRecord()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _memberidplus;
		private int? _regionidplus;
		private int? _superiorsidplus;
		private int? _rolegrade;
		private int? _rolegradetype;
		private int? _expandmemberidplus;
		private int? _expandregionidplus;
		private int? _expandsuperiorsidplus;
		private int? _expandrolegrade;
		private int? _expandrolegradetype;
		private int? _checkstate=0;
		private DateTime? _checktime= Convert.ToDateTime("2000-01-01 00:00:00.000");
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
		public int? ExpandMemberIDPlus
		{
			set{ _expandmemberidplus=value;}
			get{return _expandmemberidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpandRegionIDPlus
		{
			set{ _expandregionidplus=value;}
			get{return _expandregionidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpandSuperiorsIDPlus
		{
			set{ _expandsuperiorsidplus=value;}
			get{return _expandsuperiorsidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpandRoleGrade
		{
			set{ _expandrolegrade=value;}
			get{return _expandrolegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ExpandRoleGradeType
		{
			set{ _expandrolegradetype=value;}
			get{return _expandrolegradetype;}
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
		#endregion Model

	}
}

