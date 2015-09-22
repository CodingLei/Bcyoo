/**  版本信息模板在安装目录下，可自行修改。
* Picture.cs
*
* 功 能： N/A
* 类 名： Picture
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:29   N/A    初版
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
	/// 图片表
	/// </summary>
	[Serializable]
	public partial class Picture
	{
		public Picture()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private DateTime? _addtime= DateTime.Now;
		private int? _delstatus=0;
		private int? _picturetype;
		private string _pictureurl;
		private int? _relationidplus;
		private int? _displayorder=0;
		private string _picmicrourl;
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
		public int? Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 写在枚举里
		/// </summary>
		public int? PictureType
		{
			set{ _picturetype=value;}
			get{return _picturetype;}
		}
		/// <summary>
		/// 图片链接
		/// </summary>
		public string PictureUrl
		{
			set{ _pictureurl=value;}
			get{return _pictureurl;}
		}
		/// <summary>
		/// 外键链接
		/// </summary>
		public int? RelationIDPlus
		{
			set{ _relationidplus=value;}
			get{return _relationidplus;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int? DisplayOrder
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
		}
		/// <summary>
		/// 缩略图链接
		/// </summary>
		public string PicMicroUrl
		{
			set{ _picmicrourl=value;}
			get{return _picmicrourl;}
		}
		#endregion Model

	}
}

