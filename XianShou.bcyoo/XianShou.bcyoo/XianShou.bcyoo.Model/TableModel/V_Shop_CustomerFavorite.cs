/**  版本信息模板在安装目录下，可自行修改。
* V_Shop_CustomerFavorite.cs
*
* 功 能： N/A
* 类 名： V_Shop_CustomerFavorite
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:23   N/A    初版
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
	public partial class V_Shop_CustomerFavorite
	{
		public V_Shop_CustomerFavorite()
		{}
		#region Model
		private int _favoriteid;
		private int? _delstatus;
		private DateTime? _addtime;
		private int? _customerid;
		private int? _favoritetypeid;
		private string _shopno;
		private string _productsku;
		private string _openid;
		private string _nickname;
		private string _headimgurl;
		private string _imgurl;
		private decimal? _price;
		private string _name;
		private int? _favoritecount;
		private int? _sellcount;
		private string _shopname;
		/// <summary>
		/// 
		/// </summary>
		public int FavoriteId
		{
			set{ _favoriteid=value;}
			get{return _favoriteid;}
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
		public int? CustomerId
		{
			set{ _customerid=value;}
			get{return _customerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FavoriteTypeId
		{
			set{ _favoritetypeid=value;}
			get{return _favoritetypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShopNo
		{
			set{ _shopno=value;}
			get{return _shopno;}
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
		public string OpenId
		{
			set{ _openid=value;}
			get{return _openid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeadImgUrl
		{
			set{ _headimgurl=value;}
			get{return _headimgurl;}
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		public string ShopName
		{
			set{ _shopname=value;}
			get{return _shopname;}
		}
		#endregion Model

	}
}

