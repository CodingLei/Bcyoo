/**  版本信息模板在安装目录下，可自行修改。
* Common_Code.cs
*
* 功 能： N/A
* 类 名： Common_Code
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:10   N/A    初版
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
	/// 地区表
	/// </summary>
	[Serializable]
	public partial class Common_Code
	{
		public Common_Code()
		{}
		#region Model
		private string _code_name;
		private string _code_mem;
		private string _code_mod;
		private int? _code_max;
		private int? _code_max_lim;
		private int? _day=19;
		/// <summary>
		/// 
		/// </summary>
		public string CODE_NAME
		{
			set{ _code_name=value;}
			get{return _code_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CODE_MEM
		{
			set{ _code_mem=value;}
			get{return _code_mem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CODE_MOD
		{
			set{ _code_mod=value;}
			get{return _code_mod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CODE_MAX
		{
			set{ _code_max=value;}
			get{return _code_max;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CODE_MAX_LIM
		{
			set{ _code_max_lim=value;}
			get{return _code_max_lim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DAY
		{
			set{ _day=value;}
			get{return _day;}
		}
		#endregion Model

	}
}

