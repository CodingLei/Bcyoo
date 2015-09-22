/**  版本信息模板在安装目录下，可自行修改。
* Member_Role.cs
*
* 功 能： N/A
* 类 名： Member_Role
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:25   N/A    初版
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
	public partial class Member_Role
	{
		public Member_Role()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private string _rolename;
		private int? _rolegrade=6;
		private decimal? _firstpay;
		private decimal? _firstorder;
		private int? _limitagentcount;
		private string _menu;
		private int? _displayorder=0;
		private string _remark;
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
		public int? DelStatus
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
		/// 等级名
		/// </summary>
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 等级标识
		/// </summary>
		public int? RoleGrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
		}
		/// <summary>
		/// 门槛价
		/// </summary>
		public decimal? FirstPay
		{
			set{ _firstpay=value;}
			get{return _firstpay;}
		}
		/// <summary>
		/// 授权订单限制金额
		/// </summary>
		public decimal? FirstOrder
		{
			set{ _firstorder=value;}
			get{return _firstorder;}
		}
		/// <summary>
		/// 下级代理限制人数
		/// </summary>
		public int? LimitAgentCount
		{
			set{ _limitagentcount=value;}
			get{return _limitagentcount;}
		}
		/// <summary>
		/// 等级权限
		/// </summary>
		public string Menu
		{
			set{ _menu=value;}
			get{return _menu;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int? DisPlayOrder
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

