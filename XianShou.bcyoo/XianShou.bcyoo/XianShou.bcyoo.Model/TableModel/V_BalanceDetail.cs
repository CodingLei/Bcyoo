/**  版本信息模板在安装目录下，可自行修改。
* V_BalanceDetail.cs
*
* 功 能： N/A
* 类 名： V_BalanceDetail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:46   N/A    初版
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
	public partial class V_BalanceDetail
	{
		public V_BalanceDetail()
		{}
		#region Model
		private string _imgurl;
		private string _remark;
		private int? _memberidplus;
		private int? _flag;
		private int? _state;
		private decimal? _balancecount;
		private DateTime? _addtime;
		private string _productname;
		private int _idplus;
		private int? _productcount;
		private string _productdesc;
		private int? _superiorsidplus;
		private string _orderno;
		private DateTime? _cancletime;
		private int? _canclecheckidplus;
		private int? _ordermemberidplus;
		private int? _orderrole;
		private DateTime? _ordertime;
		private int? _orderstate;
		private string _name;
		private int? _rolegrade;
		private string _province;
		private string _city;
		private string _address;
		private string _sname;
		private string _cname;
		private int? _croleidplus;
		private string _rolename;
		private string _ordername;
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
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? memberidplus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? state
		{
			set{ _state=value;}
			get{return _state;}
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
		public DateTime? addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string productName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
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
		public int? productcount
		{
			set{ _productcount=value;}
			get{return _productcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string productdesc
		{
			set{ _productdesc=value;}
			get{return _productdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? superiorsidplus
		{
			set{ _superiorsidplus=value;}
			get{return _superiorsidplus;}
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
		public DateTime? cancletime
		{
			set{ _cancletime=value;}
			get{return _cancletime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CancleCheckIDPlus
		{
			set{ _canclecheckidplus=value;}
			get{return _canclecheckidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ordermemberidplus
		{
			set{ _ordermemberidplus=value;}
			get{return _ordermemberidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? orderrole
		{
			set{ _orderrole=value;}
			get{return _orderrole;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ordertime
		{
			set{ _ordertime=value;}
			get{return _ordertime;}
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? rolegrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string city
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sname
		{
			set{ _sname=value;}
			get{return _sname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Cname
		{
			set{ _cname=value;}
			get{return _cname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Croleidplus
		{
			set{ _croleidplus=value;}
			get{return _croleidplus;}
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
		public string ordername
		{
			set{ _ordername=value;}
			get{return _ordername;}
		}
		#endregion Model

	}
}

