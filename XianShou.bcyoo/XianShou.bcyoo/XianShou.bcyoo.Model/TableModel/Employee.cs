/**  版本信息模板在安装目录下，可自行修改。
* Employee.cs
*
* 功 能： N/A
* 类 名： Employee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:11   N/A    初版
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
	/// 员工表
	/// </summary>
	[Serializable]
	public partial class Employee
	{
		public Employee()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private string _loginpassword;
		private string _employeename;
		private string _roleid;
		private string _rolevalue= "2";
		private string _phone;
		private string _ip;
		private string _email;
		private int? _departmentidplus;
		private int? _regionidplus=0;
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
		public int? DelStatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 登录密码
		/// </summary>
		public string LoginPassword
		{
			set{ _loginpassword=value;}
			get{return _loginpassword;}
		}
		/// <summary>
		/// 员工姓名
		/// </summary>
		public string EmployeeName
		{
			set{ _employeename=value;}
			get{return _employeename;}
		}
		/// <summary>
		/// 员工职位ID
		/// </summary>
		public string RoleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 员工职位
		/// </summary>
		public string RoleValue
		{
			set{ _rolevalue=value;}
			get{return _rolevalue;}
		}
		/// <summary>
		/// 员工手机号
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// IP地址
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 邮件
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 部门IDPlus
		/// </summary>
		public int? DepartmentIDPlus
		{
			set{ _departmentidplus=value;}
			get{return _departmentidplus;}
		}
		/// <summary>
		/// 大区IDPlus
		/// </summary>
		public int? RegionIDPlus
		{
			set{ _regionidplus=value;}
			get{return _regionidplus;}
		}
		#endregion Model

	}
}

