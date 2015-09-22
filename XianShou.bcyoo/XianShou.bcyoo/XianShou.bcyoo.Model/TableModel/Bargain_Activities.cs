/**  版本信息模板在安装目录下，可自行修改。
* Bargain_Activities.cs
*
* 功 能： N/A
* 类 名： Bargain_Activities
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:09   N/A    初版
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
	/// 地区
	/// </summary>
	[Serializable]
	public partial class Bargain_Activities
	{
		public Bargain_Activities()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int _productidplus;
		private int _maxtime;
		private int _maxamount;
		private string _url;
		private int? _winrate;
		private int? _minamount;
		private string _title;
		private string _description;
		private string _sharepicpath;
		/// <summary>
		/// 
		/// </summary>
		public int Idplus
		{
			set{ _idplus=value;}
			get{return _idplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DelStatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ProductIdplus
		{
			set{ _productidplus=value;}
			get{return _productidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MaxTime
		{
			set{ _maxtime=value;}
			get{return _maxtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MaxAmount
		{
			set{ _maxamount=value;}
			get{return _maxamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WinRate
		{
			set{ _winrate=value;}
			get{return _winrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MinAmount
		{
			set{ _minamount=value;}
			get{return _minamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SharePicPath
		{
			set{ _sharepicpath=value;}
			get{return _sharepicpath;}
		}
		#endregion Model

	}
}

