/**  版本信息模板在安装目录下，可自行修改。
* V_Rebate_Type.cs
*
* 功 能： N/A
* 类 名： V_Rebate_Type
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:22   N/A    初版
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
	public partial class V_Rebate_Type
	{
		public V_Rebate_Type()
		{}
		#region Model
		private string _typename;
		private int? _rebatetype;
		private int? _rolegrade;
		private int? _roletypegrade;
		private decimal? _rate;
		/// <summary>
		/// 
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RebateType
		{
			set{ _rebatetype=value;}
			get{return _rebatetype;}
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
		public int? RoleTypeGrade
		{
			set{ _roletypegrade=value;}
			get{return _roletypegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Rate
		{
			set{ _rate=value;}
			get{return _rate;}
		}
		#endregion Model

	}
}

