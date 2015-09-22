/**  版本信息模板在安装目录下，可自行修改。
* Info_DayDate.cs
*
* 功 能： N/A
* 类 名： Info_DayDate
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:15   N/A    初版
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
	/// 培训信息表
	/// </summary>
	[Serializable]
	public partial class Info_DayDate
	{
		public Info_DayDate()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private DateTime? _addtime= DateTime.Now;
		private int? _delstatus=0;
		private int? _datetype;
		private int? _memberidplus;
		private string _title;
		private int? _authstate=0;
		private string _link;
		private DateTime? _begintime;
		private DateTime? _endtime;
		private string _speaker;
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
		/// 添加时间
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
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
		/// 
		/// </summary>
		public int? DateType
		{
			set{ _datetype=value;}
			get{return _datetype;}
		}
		/// <summary>
		/// 添加人IDPlus
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 培训题目
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 审核状态0未审核 1审核
		/// </summary>
		public int? AuthState
		{
			set{ _authstate=value;}
			get{return _authstate;}
		}
		/// <summary>
		/// 培训海报链接
		/// </summary>
		public string Link
		{
			set{ _link=value;}
			get{return _link;}
		}
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime? BeginTime
		{
			set{ _begintime=value;}
			get{return _begintime;}
		}
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime? EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 培训讲师
		/// </summary>
		public string Speaker
		{
			set{ _speaker=value;}
			get{return _speaker;}
		}
		#endregion Model

	}
}

