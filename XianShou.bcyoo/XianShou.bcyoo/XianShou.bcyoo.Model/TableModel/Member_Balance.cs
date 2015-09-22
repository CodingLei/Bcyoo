/**  版本信息模板在安装目录下，可自行修改。
* Member_Balance.cs
*
* 功 能： N/A
* 类 名： Member_Balance
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
	public partial class Member_Balance
	{
		public Member_Balance()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _flag;
		private decimal? _balancecount;
		private decimal? _lave;
		private int? _state=0;
		private int? _memberidplus;
		private int? _rolegrade;
		private int? _regionidplus;
		private int? _superiorsidplus;
		private int? _checkmemberidplus=0;
		private string _orderno="";
		private string _gradesequence;
		private string _remark;
		private int? _checkemployeeidplus=0;
		/// <summary>
		/// 主键
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
		/// 逻辑删除标识
		/// </summary>
		public int? Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 0是减1是增
		/// </summary>
		public int? Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public decimal? BalanceCount
		{
			set{ _balancecount=value;}
			get{return _balancecount;}
		}
		/// <summary>
		/// 剩余
		/// </summary>
		public decimal? Lave
		{
			set{ _lave=value;}
			get{return _lave;}
		}
		/// <summary>
		/// 0未审核 1已审核
		/// </summary>
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 金额变动代理商IDPlus
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
		/// 大区IDPlus
		/// </summary>
		public int? RegionIDPlus
		{
			set{ _regionidplus=value;}
			get{return _regionidplus;}
		}
		/// <summary>
		/// 上级IDPlus
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
		/// 订单IDPlus
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
		public int? CheckEmployeeIDPlus
		{
			set{ _checkemployeeidplus=value;}
			get{return _checkemployeeidplus;}
		}
		#endregion Model

	}
}

