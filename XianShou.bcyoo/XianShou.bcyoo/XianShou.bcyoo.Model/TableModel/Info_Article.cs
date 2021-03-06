﻿/**  版本信息模板在安装目录下，可自行修改。
* Info_Article.cs
*
* 功 能： N/A
* 类 名： Info_Article
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:13   N/A    初版
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
	/// 文章表
	/// </summary>
	[Serializable]
	public partial class Info_Article
	{
		public Info_Article()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private DateTime? _addtime= DateTime.Now;
		private int? _delstatus=0;
		private string _title;
		private string _content;
		private int? _articletype;
		private int? _isdisplay=0;
		private string _picurl;
		private int? _displayorder=0;
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
		/// 添加时间
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
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
		/// 文章标题
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 文章内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 文章类型，见枚举
		/// </summary>
		public int? ArticleType
		{
			set{ _articletype=value;}
			get{return _articletype;}
		}
		/// <summary>
		/// 是否显示
		/// </summary>
		public int? IsDisPlay
		{
			set{ _isdisplay=value;}
			get{return _isdisplay;}
		}
		/// <summary>
		/// 图片url
		/// </summary>
		public string Picurl
		{
			set{ _picurl=value;}
			get{return _picurl;}
		}
		/// <summary>
		/// 排序序列
		/// </summary>
		public int? DisPlayOrder
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
		}
		#endregion Model

	}
}

