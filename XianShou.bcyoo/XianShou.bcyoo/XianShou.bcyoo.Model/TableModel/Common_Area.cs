/**  版本信息模板在安装目录下，可自行修改。
* Common_Area.cs
*
* 功 能： N/A
* 类 名： Common_Area
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
	public partial class Common_Area
	{
		public Common_Area()
		{}
		#region Model
		private int _id;
		private string _name;
		private int? _parentid;
		private string _fullid;
		private int? _grade;
		private bool _underlingflag;
		private int? _sequence;
		private int? _code;
		private string _cityid;
		private string _provinceid;
		/// <summary>
		/// 主键
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 地区名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 父级IDPlus
		/// </summary>
		public int? ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FullID
		{
			set{ _fullid=value;}
			get{return _fullid;}
		}
		/// <summary>
		/// 地区等级
		/// </summary>
		public int? Grade
		{
			set{ _grade=value;}
			get{return _grade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool UnderlingFlag
		{
			set{ _underlingflag=value;}
			get{return _underlingflag;}
		}
		/// <summary>
		/// 顺序
		/// </summary>
		public int? Sequence
		{
			set{ _sequence=value;}
			get{return _sequence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cityId
		{
			set{ _cityid=value;}
			get{return _cityid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string provinceId
		{
			set{ _provinceid=value;}
			get{return _provinceid;}
		}
		#endregion Model

	}
}

