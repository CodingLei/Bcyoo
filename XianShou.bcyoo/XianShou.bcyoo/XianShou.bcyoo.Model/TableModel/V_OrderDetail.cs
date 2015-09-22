/**  版本信息模板在安装目录下，可自行修改。
* V_OrderDetail.cs
*
* 功 能： N/A
* 类 名： V_OrderDetail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:12   N/A    初版
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
	public partial class V_OrderDetail
	{
		public V_OrderDetail()
		{}
		#region Model
		private int _idplus;
		private DateTime? _addtime;
		private string _rolename;
		private string _name;
		private string _weixinid;
		private int? _orderstate;
		private decimal? _balancecount;
		private string _orderno;
		private string _canclereason;
		private int? _flag;
		private int? _memberidplus;
		/// <summary>
		/// 
		/// </summary>
		public int idplus
		{
			set{ _idplus=value;}
			get{return _idplus;}
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
		public string rolename
		{
			set{ _rolename=value;}
			get{return _rolename;}
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
		public string weixinid
		{
			set{ _weixinid=value;}
			get{return _weixinid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? orderstate
		{
			set{ _orderstate=value;}
			get{return _orderstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? balancecount
		{
			set{ _balancecount=value;}
			get{return _balancecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orderno
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CancleReason
		{
			set{ _canclereason=value;}
			get{return _canclereason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		#endregion Model

	}
}

