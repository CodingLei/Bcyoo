/**  版本信息模板在安装目录下，可自行修改。
* Info_PageTemplete.cs
*
* 功 能： N/A
* 类 名： Info_PageTemplete
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
	public partial class Info_PageTemplete
	{
		public Info_PageTemplete()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private string _title;
		private string _sharetitle;
		private string _sharedesc;
		private string _sharepic;
		private string _linkurl;
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
		/// 添加日期
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 分享名称
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 标题
		/// </summary>
		public string ShareTitle
		{
			set{ _sharetitle=value;}
			get{return _sharetitle;}
		}
		/// <summary>
		/// 分享内容
		/// </summary>
		public string ShareDesc
		{
			set{ _sharedesc=value;}
			get{return _sharedesc;}
		}
		/// <summary>
		/// 分享图片链接
		/// </summary>
		public string SharePic
		{
			set{ _sharepic=value;}
			get{return _sharepic;}
		}
		/// <summary>
		/// 跳转链接
		/// </summary>
		public string LinkUrl
		{
			set{ _linkurl=value;}
			get{return _linkurl;}
		}
		#endregion Model

	}
}

