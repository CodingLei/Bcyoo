/**  版本信息模板在安装目录下，可自行修改。
* V_Order.cs
*
* 功 能： N/A
* 类 名： V_Order
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:17:09   N/A    初版
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
	public partial class V_Order
	{
		public V_Order()
		{}
		#region Model
		private int _idplus;
		private DateTime? _addtime;
		private string _id;
		private int? _delstatus;
		private string _orderno;
		private int? _memberidplus;
		private int? _employeeidplus;
		private int? _customeridplus;
		private int? _recordtype;
		private string _name;
		private string _weixinid;
		private string _rolename;
		private string _employeename;
		private string _phone;
		private string _nickname;
		private string _mobile;
		private int? _ordertype;
		private int? _orderstate;
		private string _canclereason;
		private string _expressno;
		private string _receivename;
		private string _receivephone;
		private string _expressname;
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
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
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
		public int? DelStatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EmployeeIDPlus
		{
			set{ _employeeidplus=value;}
			get{return _employeeidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CustomerIDPlus
		{
			set{ _customeridplus=value;}
			get{return _customeridplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RecordType
		{
			set{ _recordtype=value;}
			get{return _recordtype;}
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
		public string WeixinId
		{
			set{ _weixinid=value;}
			get{return _weixinid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmployeeName
		{
			set{ _employeename=value;}
			get{return _employeename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
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
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrderType
		{
			set{ _ordertype=value;}
			get{return _ordertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrderState
		{
			set{ _orderstate=value;}
			get{return _orderstate;}
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
		public string ExpressNo
		{
			set{ _expressno=value;}
			get{return _expressno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveName
		{
			set{ _receivename=value;}
			get{return _receivename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceivePhone
		{
			set{ _receivephone=value;}
			get{return _receivephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExpressName
		{
			set{ _expressname=value;}
			get{return _expressname;}
		}
		#endregion Model

	}
}

