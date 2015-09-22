/**  版本信息模板在安装目录下，可自行修改。
* Product_Grade.cs
*
* 功 能： N/A
* 类 名： Product_Grade
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:33   N/A    初版
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
	/// 等级产品限额表
	/// </summary>
	[Serializable]
	public partial class Product_Grade
	{
		public Product_Grade()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private DateTime? _addtime= DateTime.Now;
		private int? _delstatus=0;
		private string _productsku;
		private int? _rolegrade;
		private int? _daycount=-1;
		private int? _weekcount=-1;
		private int? _monthcount=-1;
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
		/// 添加日期
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
		/// 产品标识Sku
		/// </summary>
		public string ProductSku
		{
			set{ _productsku=value;}
			get{return _productsku;}
		}
		/// <summary>
		/// 等级IDPlus
		/// </summary>
		public int? RoleGrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
		}
		/// <summary>
		/// 日限额
		/// </summary>
		public int? DayCount
		{
			set{ _daycount=value;}
			get{return _daycount;}
		}
		/// <summary>
		/// 周限额
		/// </summary>
		public int? WeekCount
		{
			set{ _weekcount=value;}
			get{return _weekcount;}
		}
		/// <summary>
		/// 月限额
		/// </summary>
		public int? MonthCount
		{
			set{ _monthcount=value;}
			get{return _monthcount;}
		}
		#endregion Model

	}
}

