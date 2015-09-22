/**  版本信息模板在安装目录下，可自行修改。
* V_Product_Rebate.cs
*
* 功 能： N/A
* 类 名： V_Product_Rebate
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:17   N/A    初版
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
	public partial class V_Product_Rebate
	{
		public V_Product_Rebate()
		{}
		#region Model
		private int _idplus;
		private string _id;
		private int? _delstatus;
		private DateTime? _addtime;
		private string _name;
		private string _sku;
		private decimal? _price;
		private decimal? _marketprice;
		private string _specunit;
		private string _imgurl;
		private int? _stock;
		private int? _isdisplay;
		private int? _istop;
		private int? _ishot;
		private int? _isrecommend;
		private string _giftinfo;
		private int? _brandid;
		private string _description;
		private string _attributes;
		private string _detail;
		private int? _waitsendstock;
		private int? _favoritecount;
		private int? _sellcount;
		private string _barcode;
		private int? _rebatetype;
		private int? _producttype;
		private decimal? _activtyprice;
		private string _longimgurl;
		private string _adimgurl;
		private string _typename;
		private string _brandname;
		private string _categoryname;
		private int _displayorder;
		private decimal? _seconddiscount;
		private decimal? _spikeprice;
		private int? _spikecount;
		private DateTime? _spikeendtime;
		private DateTime? _spikebegintime;
		private int? _categoryid;
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
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MarketPrice
		{
			set{ _marketprice=value;}
			get{return _marketprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SpecUnit
		{
			set{ _specunit=value;}
			get{return _specunit;}
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
		public int? Stock
		{
			set{ _stock=value;}
			get{return _stock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsDisplay
		{
			set{ _isdisplay=value;}
			get{return _isdisplay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsTop
		{
			set{ _istop=value;}
			get{return _istop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsHot
		{
			set{ _ishot=value;}
			get{return _ishot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsRecommend
		{
			set{ _isrecommend=value;}
			get{return _isrecommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GiftInfo
		{
			set{ _giftinfo=value;}
			get{return _giftinfo;}
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
		public string Attributes
		{
			set{ _attributes=value;}
			get{return _attributes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Detail
		{
			set{ _detail=value;}
			get{return _detail;}
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
		public int? FavoriteCount
		{
			set{ _favoritecount=value;}
			get{return _favoritecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SellCount
		{
			set{ _sellcount=value;}
			get{return _sellcount;}
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
		public int? RebateType
		{
			set{ _rebatetype=value;}
			get{return _rebatetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProductType
		{
			set{ _producttype=value;}
			get{return _producttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ActivtyPrice
		{
			set{ _activtyprice=value;}
			get{return _activtyprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LongImgUrl
		{
			set{ _longimgurl=value;}
			get{return _longimgurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADImgUrl
		{
			set{ _adimgurl=value;}
			get{return _adimgurl;}
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
		public string BrandName
		{
			set{ _brandname=value;}
			get{return _brandname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CategoryName
		{
			set{ _categoryname=value;}
			get{return _categoryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DisplayOrder
		{
			set{ _displayorder=value;}
			get{return _displayorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SecondDiscount
		{
			set{ _seconddiscount=value;}
			get{return _seconddiscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SpikePrice
		{
			set{ _spikeprice=value;}
			get{return _spikeprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SpikeCount
		{
			set{ _spikecount=value;}
			get{return _spikecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SpikeEndTime
		{
			set{ _spikeendtime=value;}
			get{return _spikeendtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SpikeBeginTime
		{
			set{ _spikebegintime=value;}
			get{return _spikebegintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CategoryId
		{
			set{ _categoryid=value;}
			get{return _categoryid;}
		}
		#endregion Model

	}
}

