/**  版本信息模板在安装目录下，可自行修改。
* v_BargainActivitiesProduct.cs
*
* 功 能： N/A
* 类 名： v_BargainActivitiesProduct
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:47   N/A    初版
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
	public partial class v_BargainActivitiesProduct
	{
		public v_BargainActivitiesProduct()
		{}
		#region Model
		private int _idplus;
		private string _id;
		private int? _delstatus;
		private DateTime? _addtime;
		private int _productidplus;
		private int _maxtime;
		private int _maxamount;
		private string _url;
		private int? _winrate;
		private int? _minamount;
		private string _title;
		private string _description;
		private string _sharepicpath;
		private string _productname;
		private string _sku;
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
		/// <summary>
		/// 
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sku
		{
			set{ _sku=value;}
			get{return _sku;}
		}
		#endregion Model

	}
}

