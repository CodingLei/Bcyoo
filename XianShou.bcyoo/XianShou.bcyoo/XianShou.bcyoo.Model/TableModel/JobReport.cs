/**  版本信息模板在安装目录下，可自行修改。
* JobReport.cs
*
* 功 能： N/A
* 类 名： JobReport
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:16   N/A    初版
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
	/// 图片流动分享图片表
	/// </summary>
	[Serializable]
	public partial class JobReport
	{
		public JobReport()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private DateTime? _addtime= DateTime.Now;
		private int? _version=0;
		private string _jobname;
		private int? _memberidplus=0;
		private int? _rolegrade=0;
		private int? _rolegradetype;
		private decimal? _balance=0M;
		private int? _commissiontype;
		private int? _commissionidplus;
		private int? _jobcompleted=0;
		private DateTime? _jobtime= DateTime.Now;
		private string _remark;
		private string _descrip;
		/// <summary>
		/// 
		/// </summary>
		public int IDPlus
		{
			set{ _idplus=value;}
			get{return _idplus;}
		}
		/// <summary>
		/// 唯一标识
		/// </summary>
		public string Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 添加时间(申请时间)
		/// </summary>
		public DateTime? Addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Version
		{
			set{ _version=value;}
			get{return _version;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JobName
		{
			set{ _jobname=value;}
			get{return _jobname;}
		}
		/// <summary>
		/// 所属大区代理
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 角色ID
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
		/// 待结算金额
		/// </summary>
		public decimal? Balance
		{
			set{ _balance=value;}
			get{return _balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CommissionType
		{
			set{ _commissiontype=value;}
			get{return _commissiontype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CommissionIDPlus
		{
			set{ _commissionidplus=value;}
			get{return _commissionidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? JobCompleted
		{
			set{ _jobcompleted=value;}
			get{return _jobcompleted;}
		}
		/// <summary>
		/// 添加时间(申请时间)
		/// </summary>
		public DateTime? Jobtime
		{
			set{ _jobtime=value;}
			get{return _jobtime;}
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
		public string Descrip
		{
			set{ _descrip=value;}
			get{return _descrip;}
		}
		#endregion Model

	}
}

