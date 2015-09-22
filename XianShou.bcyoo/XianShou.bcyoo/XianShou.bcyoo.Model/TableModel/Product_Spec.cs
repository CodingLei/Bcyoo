/**  版本信息模板在安装目录下，可自行修改。
* Product_Spec.cs
*
* 功 能： N/A
* 类 名： Product_Spec
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:34   N/A    初版
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
	/// 产品规格表
	/// </summary>
	[Serializable]
	public partial class Product_Spec
	{
		public Product_Spec()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private DateTime? _addtime= DateTime.Now;
		private int? _delstatus=0;
		private string _productsku;
		private string _specvalue;
		private int? _speccount;
		private int? _stock=0;
		private int? _waitsendstock=0;
		private string _barcode;
		private int? _securitystock=0;
		private int? _limitcount=0;
		private DateTime? _limitbegin= Convert.ToDateTime("2000-01-01 00:00:00.000");
		private DateTime? _limitend= Convert.ToDateTime("2000-01-01 00:00:00.000");
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
		/// 产品IDPlus
		/// </summary>
		public string ProductSku
		{
			set{ _productsku=value;}
			get{return _productsku;}
		}
		/// <summary>
		/// 规格
		/// </summary>
		public string SpecValue
		{
			set{ _specvalue=value;}
			get{return _specvalue;}
		}
		/// <summary>
		/// 对应数量(套)
		/// </summary>
		public int? SpecCount
		{
			set{ _speccount=value;}
			get{return _speccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Stock
		{
			set{ _stock=value;}
			get{return _stock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WaitSendStock
		{
			set{ _waitsendstock=value;}
			get{return _waitsendstock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BarCode
		{
			set{ _barcode=value;}
			get{return _barcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SecurityStock
		{
			set{ _securitystock=value;}
			get{return _securitystock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LimitCount
		{
			set{ _limitcount=value;}
			get{return _limitcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LimitBegin
		{
			set{ _limitbegin=value;}
			get{return _limitbegin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LimitEnd
		{
			set{ _limitend=value;}
			get{return _limitend;}
		}
		#endregion Model

	}
}

