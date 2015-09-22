/**  版本信息模板在安装目录下，可自行修改。
* Info_ArticleType.cs
*
* 功 能： N/A
* 类 名： Info_ArticleType
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:14   N/A    初版
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
	/// 文章类型表
	/// </summary>
	[Serializable]
	public partial class Info_ArticleType
	{
		public Info_ArticleType()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private string _typename;
		private int? _isdisplay=1;
		private int? _displayorder;
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
		/// 文章类型名称
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 是否显示
		/// </summary>
		public int? IsDisplay
		{
			set{ _isdisplay=value;}
			get{return _isdisplay;}
		}
		/// <summary>
		/// 排序序列
		/// </summary>
		public int? DisplayOrder
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
		}
		#endregion Model

	}
}

