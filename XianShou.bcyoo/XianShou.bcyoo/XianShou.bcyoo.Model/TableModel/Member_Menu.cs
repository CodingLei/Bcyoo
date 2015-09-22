/**  版本信息模板在安装目录下，可自行修改。
* Member_Menu.cs
*
* 功 能： N/A
* 类 名： Member_Menu
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:22   N/A    初版
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
	/// 代理商页面显示菜单表
	/// </summary>
	[Serializable]
	public partial class Member_Menu
	{
		public Member_Menu()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int _parentidplus=0;
		private string _name;
		private string _url;
		private string _icon;
		private int? _displayorder=0;
		private string _remark;
		private int? _wapuseflag=0;
		private int? _dailiuseflag;
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
		/// 父级菜单IDPlus
		/// </summary>
		public int ParentIDPlus
		{
			set{ _parentidplus=value;}
			get{return _parentidplus;}
		}
		/// <summary>
		/// 页面/菜单名字
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 页面URL
		/// </summary>
		public string Url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 图标
		/// </summary>
		public string Icon
		{
			set{ _icon=value;}
			get{return _icon;}
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
		/// <summary>
		/// 是否前台显示
		/// </summary>
		public int? WapUseFlag
		{
			set{ _wapuseflag=value;}
			get{return _wapuseflag;}
		}
		/// <summary>
		/// 是否后台显示
		/// </summary>
		public int? DailiUseFlag
		{
			set{ _dailiuseflag=value;}
			get{return _dailiuseflag;}
		}
		#endregion Model

	}
}

