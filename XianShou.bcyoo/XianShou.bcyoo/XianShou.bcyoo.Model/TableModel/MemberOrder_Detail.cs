/**  版本信息模板在安装目录下，可自行修改。
* MemberOrder_Detail.cs
*
* 功 能： N/A
* 类 名： MemberOrder_Detail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:28   N/A    初版
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
	/// 订单详情表
	/// </summary>
	[Serializable]
	public partial class MemberOrder_Detail
	{
		public MemberOrder_Detail()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private string _orderno;
		private string _productsku;
		private string _productdesc;
		private decimal? _productprice;
		private int? _productcount;
		private string _productname;
		private int? _specidplus;
		private int? _brandid;
		private int? _dealtype;
		private string _spec;
		private int? _spikeid;
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
		/// 订单号
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 产品类型
		/// </summary>
		public string ProductSku
		{
			set{ _productsku=value;}
			get{return _productsku;}
		}
		/// <summary>
		/// 产品规格(转由SpecIDPlus来表示规格)
		/// </summary>
		public string ProductDesc
		{
			set{ _productdesc=value;}
			get{return _productdesc;}
		}
		/// <summary>
		/// 产品价格
		/// </summary>
		public decimal? ProductPrice
		{
			set{ _productprice=value;}
			get{return _productprice;}
		}
		/// <summary>
		/// 产品数量
		/// </summary>
		public int? ProductCount
		{
			set{ _productcount=value;}
			get{return _productcount;}
		}
		/// <summary>
		/// 产品名称
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 产品规格IDPlus
		/// </summary>
		public int? SpecIDPlus
		{
			set{ _specidplus=value;}
			get{return _specidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BrandId
		{
			set{ _brandid=value;}
			get{return _brandid;}
		}
		/// <summary>
		/// 交易类型 1:正常购买 2:换购 3:买赠
		/// </summary>
		public int? DealType
		{
			set{ _dealtype=value;}
			get{return _dealtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Spec
		{
			set{ _spec=value;}
			get{return _spec;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SpikeId
		{
			set{ _spikeid=value;}
			get{return _spikeid;}
		}
		#endregion Model

	}
}

