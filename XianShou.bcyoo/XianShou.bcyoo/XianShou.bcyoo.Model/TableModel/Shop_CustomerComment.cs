/**  版本信息模板在安装目录下，可自行修改。
* Shop_CustomerComment.cs
*
* 功 能： N/A
* 类 名： Shop_CustomerComment
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:42   N/A    初版
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
	public partial class Shop_CustomerComment
	{
		public Shop_CustomerComment()
		{}
		#region Model
		private int _commentidplus;
		private string _productno;
		private string _productsku;
		private DateTime? _dptime= DateTime.Now;
		private string _dpcontent;
		private string _dpsource;
		private int? _dpstar;
		private int? _customerid;
		private int? _checkstate=1;
		private int? _delstatus=0;
		private string _nikname;
		private string _checkfailereason;
		private DateTime? _checktime;
		private int? _checkemployeeid;
		private string _checkemployeename;
		private int? _relationidplus;
		/// <summary>
		/// 主键
		/// </summary>
		public int CommentIDPlus
		{
			set{ _commentidplus=value;}
			get{return _commentidplus;}
		}
		/// <summary>
		/// 订单号
		/// </summary>
		public string ProductNo
		{
			set{ _productno=value;}
			get{return _productno;}
		}
		/// <summary>
		/// 产品SKU
		/// </summary>
		public string ProductSku
		{
			set{ _productsku=value;}
			get{return _productsku;}
		}
		/// <summary>
		/// 点评时间
		/// </summary>
		public DateTime? DPTime
		{
			set{ _dptime=value;}
			get{return _dptime;}
		}
		/// <summary>
		/// 点评内容
		/// </summary>
		public string DPContent
		{
			set{ _dpcontent=value;}
			get{return _dpcontent;}
		}
		/// <summary>
		/// 点评来源
		/// </summary>
		public string DPSource
		{
			set{ _dpsource=value;}
			get{return _dpsource;}
		}
		/// <summary>
		/// 点评星级
		/// </summary>
		public int? DPStar
		{
			set{ _dpstar=value;}
			get{return _dpstar;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int? CustomerId
		{
			set{ _customerid=value;}
			get{return _customerid;}
		}
		/// <summary>
		/// 审核状态（0未审核，1审核，2审核不通过） 
		/// </summary>
		public int? CheckState
		{
			set{ _checkstate=value;}
			get{return _checkstate;}
		}
		/// <summary>
		/// 0未删除，1删除
		/// </summary>
		public int? Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NikName
		{
			set{ _nikname=value;}
			get{return _nikname;}
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
		public int? RelationIdPlus
		{
			set{ _relationidplus=value;}
			get{return _relationidplus;}
		}
		#endregion Model

	}
}

