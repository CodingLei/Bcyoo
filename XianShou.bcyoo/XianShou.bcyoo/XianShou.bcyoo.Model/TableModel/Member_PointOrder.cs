/**  版本信息模板在安装目录下，可自行修改。
* Member_PointOrder.cs
*
* 功 能： N/A
* 类 名： Member_PointOrder
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:22   N/A    初版
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
	/// 代理商页面显示菜单表
	/// </summary>
	[Serializable]
	public partial class Member_PointOrder
	{
		public Member_PointOrder()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _memberidplus;
		private int? _regionidplus;
		private int? _superiorsidplus;
		private int? _rolegrade;
		private int? _rolegradetype;
		private string _orderno;
		private int? _orderstate;
		private int? _pointnum;
		private string _receivename;
		private string _receivephone;
		private string _receiveprovince;
		private string _receivecity;
		private string _receivearea;
		private string _receiveaddress;
		private int? _sendidplus;
		private DateTime? _sendtime;
		private string _productsku;
		private string _productdesc;
		private string _productname;
		private int? _specidplus;
		private int? _brandid;
		private string _remark;
		private DateTime _receivetime= Convert.ToDateTime("2000-01-01 00:00:00.000");
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
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
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
		public int? RegionIDPlus
		{
			set{ _regionidplus=value;}
			get{return _regionidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SuperiorsIDPlus
		{
			set{ _superiorsidplus=value;}
			get{return _superiorsidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleGrade
		{
			set{ _rolegrade=value;}
			get{return _rolegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleGradeType
		{
			set{ _rolegradetype=value;}
			get{return _rolegradetype;}
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
		public int? OrderState
		{
			set{ _orderstate=value;}
			get{return _orderstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PointNum
		{
			set{ _pointnum=value;}
			get{return _pointnum;}
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
		public string ReceiveProvince
		{
			set{ _receiveprovince=value;}
			get{return _receiveprovince;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveCity
		{
			set{ _receivecity=value;}
			get{return _receivecity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveArea
		{
			set{ _receivearea=value;}
			get{return _receivearea;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiveAddress
		{
			set{ _receiveaddress=value;}
			get{return _receiveaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SendIDPlus
		{
			set{ _sendidplus=value;}
			get{return _sendidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SendTime
		{
			set{ _sendtime=value;}
			get{return _sendtime;}
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
		public string ProductDesc
		{
			set{ _productdesc=value;}
			get{return _productdesc;}
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
		public int? SpecIDPlus
		{
			set{ _specidplus=value;}
			get{return _specidplus;}
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
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ReceiveTime
		{
			set{ _receivetime=value;}
			get{return _receivetime;}
		}
		#endregion Model

	}
}

