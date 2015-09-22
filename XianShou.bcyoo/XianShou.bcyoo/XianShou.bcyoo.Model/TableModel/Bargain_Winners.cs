/**  版本信息模板在安装目录下，可自行修改。
* Bargain_Winners.cs
*
* 功 能： N/A
* 类 名： Bargain_Winners
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:10   N/A    初版
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
	/// 地区
	/// </summary>
	[Serializable]
	public partial class Bargain_Winners
	{
		public Bargain_Winners()
		{}
		#region Model
		private int? _idplus;
		private string _id;
		private int? _delstatus;
		private DateTime? _addtime;
		private string _memberopenid;
		private string _membername;
		private int? _bargainidplus;
		private int? _activityidplus;
		private int? _type;
		/// <summary>
		/// 
		/// </summary>
		public int? IDPlus
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
		public int? DelStatus
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
		public string MemberOpenId
		{
			set{ _memberopenid=value;}
			get{return _memberopenid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MemberName
		{
			set{ _membername=value;}
			get{return _membername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BargainIdplus
		{
			set{ _bargainidplus=value;}
			get{return _bargainidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ActivityIdplus
		{
			set{ _activityidplus=value;}
			get{return _activityidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		#endregion Model

	}
}

