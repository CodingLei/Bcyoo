﻿/**  版本信息模板在安装目录下，可自行修改。
* Member_Region.cs
*
* 功 能： N/A
* 类 名： Member_Region
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
	/// 代理大区表
	/// </summary>
	[Serializable]
	public partial class Member_Region
	{
		public Member_Region()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private string _regionteamname;
		private int? _memberidplus;
		private string _regioncode;
		private string _regioninfo;
		private string _regionlink;
		private int? _displayorder=0;
		private int? _isdisplay=1;
		private string _picpath;
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
		/// 大区名字
		/// </summary>
		public string RegionTeamName
		{
			set{ _regionteamname=value;}
			get{return _regionteamname;}
		}
		/// <summary>
		/// 对应代理IDplus
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 大区标识
		/// </summary>
		public string RegionCode
		{
			set{ _regioncode=value;}
			get{return _regioncode;}
		}
		/// <summary>
		/// 大区信息
		/// </summary>
		public string RegionInfo
		{
			set{ _regioninfo=value;}
			get{return _regioninfo;}
		}
		/// <summary>
		/// 大区链接
		/// </summary>
		public string RegionLink
		{
			set{ _regionlink=value;}
			get{return _regionlink;}
		}
		/// <summary>
		/// 显示次序
		/// </summary>
		public int? DisplayOrder
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
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
		/// 图片地址
		/// </summary>
		public string Picpath
		{
			set{ _picpath=value;}
			get{return _picpath;}
		}
		#endregion Model

	}
}

