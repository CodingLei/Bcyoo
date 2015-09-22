/**  版本信息模板在安装目录下，可自行修改。
* V_Product_Rebate_Configure_Rebate_Type.cs
*
* 功 能： N/A
* 类 名： V_Product_Rebate_Configure_Rebate_Type
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:18   N/A    初版
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
	public partial class V_Product_Rebate_Configure_Rebate_Type
	{
		public V_Product_Rebate_Configure_Rebate_Type()
		{}
		#region Model
		private int _idplus;
		private int? _delstatus;
		private DateTime? _addtime;
		private string _name;
		private string _sku;
		private string _imgurl;
		private decimal? _price;
		private int? _rebatetype;
		private int? _rolegrade;
		private int? _roletypegrade;
		private decimal? _rate;
		private string _typename;
		private decimal? _bigrate;
		private decimal? _zjrate;
		private decimal? _dsrate;
		private decimal? _shoprebate;
		private decimal? _bigshoprebate;
		private decimal? _zjrebate;
		private decimal? _dsrebate;
		/// <summary>
		/// 
		/// </summary>
		public int IDPlus
		{
			set{ _idplus=value;}
			get{return _idplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sku
		{
			set{ _sku=value;}
			get{return _sku;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RebateType
		{
			set{ _rebatetype=value;}
			get{return _rebatetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleGrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleTypeGrade
		{
			set{ _roletypegrade=value;}
			get{return _roletypegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Rate
		{
			set{ _rate=value;}
			get{return _rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BigRate
		{
			set{ _bigrate=value;}
			get{return _bigrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ZJRate
		{
			set{ _zjrate=value;}
			get{return _zjrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DSRate
		{
			set{ _dsrate=value;}
			get{return _dsrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SHopRebate
		{
			set{ _shoprebate=value;}
			get{return _shoprebate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BigShopRebate
		{
			set{ _bigshoprebate=value;}
			get{return _bigshoprebate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ZJRebate
		{
			set{ _zjrebate=value;}
			get{return _zjrebate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DSRebate
		{
			set{ _dsrebate=value;}
			get{return _dsrebate;}
		}
		#endregion Model

	}
}

