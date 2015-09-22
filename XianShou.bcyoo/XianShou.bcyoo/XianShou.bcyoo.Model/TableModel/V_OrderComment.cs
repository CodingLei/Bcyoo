/**  版本信息模板在安装目录下，可自行修改。
* V_OrderComment.cs
*
* 功 能： N/A
* 类 名： V_OrderComment
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:10   N/A    初版
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
	public partial class V_OrderComment
	{
		public V_OrderComment()
		{}
		#region Model
		private string _productno;
		private int _commentidplus;
		private string _productsku;
		private DateTime? _dptime;
		private string _dpcontent;
		private string _dpsource;
		private int? _dpstar;
		private int? _checkstate;
		private int? _delstatus;
		private DateTime? _checktime;
		private int? _checkemployeeid;
		private string _checkemployeename;
		private string _checkfailereason;
		private string _productname;
		private int? _productcount;
		private decimal? _productprice;
		private string _nickname;
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
		public int CommentIDPlus
		{
			set{ _commentidplus=value;}
			get{return _commentidplus;}
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
		public DateTime? DPTime
		{
			set{ _dptime=value;}
			get{return _dptime;}
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
		public int? CheckState
		{
			set{ _checkstate=value;}
			get{return _checkstate;}
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
		public DateTime? CheckTime
		{
			set{ _checktime=value;}
			get{return _checktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CheckEmployeeId
		{
			set{ _checkemployeeid=value;}
			get{return _checkemployeeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckEmployeeName
		{
			set{ _checkemployeename=value;}
			get{return _checkemployeename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckFaileReason
		{
			set{ _checkfailereason=value;}
			get{return _checkfailereason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProductCount
		{
			set{ _productcount=value;}
			get{return _productcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ProductPrice
		{
			set{ _productprice=value;}
			get{return _productprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		#endregion Model

	}
}

