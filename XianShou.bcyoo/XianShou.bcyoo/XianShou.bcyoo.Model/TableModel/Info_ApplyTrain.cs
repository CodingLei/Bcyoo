/**  版本信息模板在安装目录下，可自行修改。
* Info_ApplyTrain.cs
*
* 功 能： N/A
* 类 名： Info_ApplyTrain
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:13   N/A    初版
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
	/// 培训申请表
	/// </summary>
	[Serializable]
	public partial class Info_ApplyTrain
	{
		public Info_ApplyTrain()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _memberidplus;
		private string _teamname;
		private string _traintime;
		private string _directpeople;
		private string _trainrequire;
		private string _skill;
		private string _major;
		private string _applyarea;
		private string _trainaddress;
		private string _trainnum;
		private string _divisionline;
		private int? _state;
		private string _failreason;
		private string _remark;
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
		/// 添加时间(申请时间)
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 申请人IDPlus
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 团队名称(线下)
		/// </summary>
		public string TeamName
		{
			set{ _teamname=value;}
			get{return _teamname;}
		}
		/// <summary>
		/// 培训时间
		/// </summary>
		public string TrainTime
		{
			set{ _traintime=value;}
			get{return _traintime;}
		}
		/// <summary>
		/// 针对人群
		/// </summary>
		public string DirectPeople
		{
			set{ _directpeople=value;}
			get{return _directpeople;}
		}
		/// <summary>
		/// 培训要求
		/// </summary>
		public string TrainRequire
		{
			set{ _trainrequire=value;}
			get{return _trainrequire;}
		}
		/// <summary>
		/// 培训课程
		/// </summary>
		public string Skill
		{
			set{ _skill=value;}
			get{return _skill;}
		}
		/// <summary>
		/// 培训专业
		/// </summary>
		public string Major
		{
			set{ _major=value;}
			get{return _major;}
		}
		/// <summary>
		/// 培训区域
		/// </summary>
		public string ApplyArea
		{
			set{ _applyarea=value;}
			get{return _applyarea;}
		}
		/// <summary>
		/// 培训地址
		/// </summary>
		public string TrainAddress
		{
			set{ _trainaddress=value;}
			get{return _trainaddress;}
		}
		/// <summary>
		/// 培训人数
		/// </summary>
		public string TrainNum
		{
			set{ _trainnum=value;}
			get{return _trainnum;}
		}
		/// <summary>
		/// 线上/线下
		/// </summary>
		public string DivisionLine
		{
			set{ _divisionline=value;}
			get{return _divisionline;}
		}
		/// <summary>
		/// 申请状态
		/// </summary>
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 失败原因
		/// </summary>
		public string FailReason
		{
			set{ _failreason=value;}
			get{return _failreason;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

