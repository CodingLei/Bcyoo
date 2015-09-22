/**  版本信息模板在安装目录下，可自行修改。
* Product.cs
*
* 功 能： N/A
* 类 名： Product
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:30   N/A    初版
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
	/// 产品表
	/// </summary>
	[Serializable]
	public partial class Product
	{
		public Product()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
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
		private int? _waitsendstock=0;
		private int? _favoritecount=0;
		private int? _sellcount=0;
		private string _barcode="";
		private int? _rebatetype=0;
		private int? _producttype=0;
		private string _longimgurl;
		private string _adimgurl;
		private string _subtitile;
		private int? _categoryidplus;
		private string _giftsku;
		private decimal? _activtyprice;
		private DateTime? _spikebegintime;
		private DateTime? _spikeendtime;
		private int? _spikecount;
		private decimal? _spikeprice;
		private decimal? _seconddiscount;
		private int _displayorder=0;
		private int? _activityrebatetype=0;
		private int? _isindex=0;
		private int? _sellratio=0;
		private int? _favoriteratio=0;
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
		public DateTime? Addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 产品名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 产品标识Sku
		/// </summary>
		public string Sku
		{
			set{ _sku=value;}
			get{return _sku;}
		}
		/// <summary>
		/// 微信价格
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 市场价
		/// </summary>
		public decimal? MarketPrice
		{
			set{ _marketprice=value;}
			get{return _marketprice;}
		}
		/// <summary>
		/// 规格
		/// </summary>
		public string SpecUnit
		{
			set{ _specunit=value;}
			get{return _specunit;}
		}
		/// <summary>
		/// 产品图片
		/// </summary>
		public string ImgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		/// <summary>
		/// 库存
		/// </summary>
		public int? Stock
		{
			set{ _stock=value;}
			get{return _stock;}
		}
		/// <summary>
		/// 是否显示
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
		/// 赠品信息
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
		/// 简短的描述 通常作为产品名的说明 在网页中同产品名同时出现
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
		/// 详细
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
		public string SubTitile
		{
			set{ _subtitile=value;}
			get{return _subtitile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CategoryIDPlus
		{
			set{ _categoryidplus=value;}
			get{return _categoryidplus;}
		}
		/// <summary>
		/// [SKU,数量;SKU,数量]
		/// </summary>
		public string GiftSku
		{
			set{ _giftsku=value;}
			get{return _giftsku;}
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
		/// 秒杀开始时间
		/// </summary>
		public DateTime? SpikeBeginTime
		{
			set{ _spikebegintime=value;}
			get{return _spikebegintime;}
		}
		/// <summary>
		/// 秒杀结束时间
		/// </summary>
		public DateTime? SpikeEndTime
		{
			set{ _spikeendtime=value;}
			get{return _spikeendtime;}
		}
		/// <summary>
		/// 秒杀的个数
		/// </summary>
		public int? SpikeCount
		{
			set{ _spikecount=value;}
			get{return _spikecount;}
		}
		/// <summary>
		/// 秒杀价格
		/// </summary>
		public decimal? SpikePrice
		{
			set{ _spikeprice=value;}
			get{return _spikeprice;}
		}
		/// <summary>
		/// 第二件折扣
		/// </summary>
		public decimal? SecondDiscount
		{
			set{ _seconddiscount=value;}
			get{return _seconddiscount;}
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
		public int? ActivityRebateType
		{
			set{ _activityrebatetype=value;}
			get{return _activityrebatetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsIndex
		{
			set{ _isindex=value;}
			get{return _isindex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SellRatio
		{
			set{ _sellratio=value;}
			get{return _sellratio;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FavoriteRatio
		{
			set{ _favoriteratio=value;}
			get{return _favoriteratio;}
		}
		#endregion Model

	}
}

