/**  版本信息模板在安装目录下，可自行修改。
* Activity_FullGiftDetail.cs
*
* 功 能： N/A
* 类 名： Activity_FullGiftDetail
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
	/// 满赠优惠细表
	/// </summary>
	[Serializable]
	public partial class Activity_FullGiftDetail
	{
		public Activity_FullGiftDetail()
		{}
		#region Model
		private int _activityfullgiftdetailid;
		private DateTime? _addtime= DateTime.Now;
		private bool _delstatus= false;
		private int? _activityfullid;
		private string _productsku;
		private int? _productcount;
		private int? _specid;
		private string _id= "newid";
		/// <summary>
		/// 
		/// </summary>
		public int ActivityFullGiftDetailId
		{
			set{ _activityfullgiftdetailid=value;}
			get{return _activityfullgiftdetailid;}
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
		public bool Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 满赠活动ID
		/// </summary>
		public int? ActivityFullId
		{
			set{ _activityfullid=value;}
			get{return _activityfullid;}
		}
		/// <summary>
		/// 产品sku
		/// </summary>
		public string ProductSku
		{
			set{ _productsku=value;}
			get{return _productsku;}
		}
		/// <summary>
		/// 赠送产品数量
		/// </summary>
		public int? ProductCount
		{
			set{ _productcount=value;}
			get{return _productcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SpecId
		{
			set{ _specid=value;}
			get{return _specid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		#endregion Model

	}
}

