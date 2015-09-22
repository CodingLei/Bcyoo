/**  版本信息模板在安装目录下，可自行修改。
* Bargain_Detail.cs
*
* 功 能： N/A
* 类 名： Bargain_Detail
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
	public partial class Bargain_Detail
	{
		public Bargain_Detail()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _bargainidplus;
		private int? _memberidplus;
		private decimal? _minuscount;
		private string _memberopenid;
		private string _membername;
		private string _memberheadurl;
		private string _desctext;
		private int? _activityidplus;
		/// <summary>
		/// 
		/// </summary>
		public int Idplus
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
		public int? BargainIdplus
		{
			set{ _bargainidplus=value;}
			get{return _bargainidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MemberIdplus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MinusCount
		{
			set{ _minuscount=value;}
			get{return _minuscount;}
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
		public string MemberHeadUrl
		{
			set{ _memberheadurl=value;}
			get{return _memberheadurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DescText
		{
			set{ _desctext=value;}
			get{return _desctext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ActivityIdplus
		{
			set{ _activityidplus=value;}
			get{return _activityidplus;}
		}
		#endregion Model

	}
}

