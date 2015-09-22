/**  版本信息模板在安装目录下，可自行修改。
* Product_StockNew.cs
*
* 功 能： N/A
* 类 名： Product_StockNew
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:35   N/A    初版
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
	public partial class Product_StockNew
	{
		public Product_StockNew()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _stocktype;
		private string _productsku;
		private string _orderno;
		private int? _changestocknum;
		private int? _afterstocknum;
		private int? _changewaitsendstocknum;
		private int? _afterwaitsendstocknum;
		private int? _operationidplus;
		private int? _operationusertype;
		private string _remark;
		private int? _specid;
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
		public string Id
		{
			set{ _id=value;}
			get{return _id;}
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
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StockType
		{
			set{ _stocktype=value;}
			get{return _stocktype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductSku
		{
			set{ _productsku=value;}
			get{return _productsku;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ChangeStockNum
		{
			set{ _changestocknum=value;}
			get{return _changestocknum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AfterStockNum
		{
			set{ _afterstocknum=value;}
			get{return _afterstocknum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ChangeWaitSendStockNum
		{
			set{ _changewaitsendstocknum=value;}
			get{return _changewaitsendstocknum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AfterWaitSendStockNum
		{
			set{ _afterwaitsendstocknum=value;}
			get{return _afterwaitsendstocknum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperationIDPlus
		{
			set{ _operationidplus=value;}
			get{return _operationidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperationUserType
		{
			set{ _operationusertype=value;}
			get{return _operationusertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SpecId
		{
			set{ _specid=value;}
			get{return _specid;}
		}
		#endregion Model

	}
}

