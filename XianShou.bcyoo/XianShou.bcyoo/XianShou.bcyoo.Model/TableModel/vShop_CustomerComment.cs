/**  版本信息模板在安装目录下，可自行修改。
* vShop_CustomerComment.cs
*
* 功 能： N/A
* 类 名： vShop_CustomerComment
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:27   N/A    初版
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
	public partial class vShop_CustomerComment
	{
		public vShop_CustomerComment()
		{}
		#region Model
		private DateTime? _dptime;
		private string _dpsource;
		private int? _dpstar;
		private string _expr6;
		private string _headurl;
		private string _productsku;
		private int _commentidplus;
		private string _dpcontent;
		private int? _checkstate;
		private string _productno;
		private int? _relationidplus;
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DPTime
		{
			set{ _dptime=value;}
			get{return _dptime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DPSource
		{
			set{ _dpsource=value;}
			get{return _dpsource;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DPStar
		{
			set{ _dpstar=value;}
			get{return _dpstar;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Expr6
		{
			set{ _expr6=value;}
			get{return _expr6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeadUrl
		{
			set{ _headurl=value;}
			get{return _headurl;}
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
		public int CommentIDPlus
		{
			set{ _commentidplus=value;}
			get{return _commentidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DPContent
		{
			set{ _dpcontent=value;}
			get{return _dpcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CheckState
		{
			set{ _checkstate=value;}
			get{return _checkstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductNo
		{
			set{ _productno=value;}
			get{return _productno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RelationIdPlus
		{
			set{ _relationidplus=value;}
			get{return _relationidplus;}
		}
		#endregion Model

	}
}

