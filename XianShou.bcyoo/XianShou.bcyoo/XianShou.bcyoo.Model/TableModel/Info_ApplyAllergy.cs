/**  版本信息模板在安装目录下，可自行修改。
* Info_ApplyAllergy.cs
*
* 功 能： N/A
* 类 名： Info_ApplyAllergy
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
	/// 过敏反馈申请表
	/// </summary>
	[Serializable]
	public partial class Info_ApplyAllergy
	{
		public Info_ApplyAllergy()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private int? _delstatus=0;
		private DateTime? _addtime= DateTime.Now;
		private int? _memberidplus;
		private string _name;
		private string _phone;
		private string _age;
		private string _agentform;
		private string _isfirstornotofen;
		private string _isfirstuseosm;
		private string _ischange;
		private string _series;
		private string _isbaseexplain;
		private string _ismix;
		private int? _state;
		private string _isallergyhistory;
		private string _isallergytime;
		private string _description;
		private string _picture;
		/// <summary>
		/// 主键
		/// </summary>
		public int IDPlus
		{
			set{ _idplus=value;}
			get{return _idplus;}
		}
		/// <summary>
		/// 唯一标识IDPlus
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
		/// 反馈人IDPlus，与Member表对应
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 反馈的姓名，可能是顾客的名字
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 反馈的手机号
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 反馈的年龄
		/// </summary>
		public string Age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// 从那个代理商购买的产品
		/// </summary>
		public string AgentForm
		{
			set{ _agentform=value;}
			get{return _agentform;}
		}
		/// <summary>
		/// 是第一次使用还是不经常使用
		/// </summary>
		public string IsFirstOrNotOfen
		{
			set{ _isfirstornotofen=value;}
			get{return _isfirstornotofen;}
		}
		/// <summary>
		/// 是否第一次使用OSM产品
		/// </summary>
		public string IsFirstUseOsm
		{
			set{ _isfirstuseosm=value;}
			get{return _isfirstuseosm;}
		}
		/// <summary>
		/// 是否由其他产品转为OSM
		/// </summary>
		public string IsChange
		{
			set{ _ischange=value;}
			get{return _ischange;}
		}
		/// <summary>
		/// 使用哪个系列的产品
		/// </summary>
		public string Series
		{
			set{ _series=value;}
			get{return _series;}
		}
		/// <summary>
		/// 是否根据说明书使用
		/// </summary>
		public string IsBaseExplain
		{
			set{ _isbaseexplain=value;}
			get{return _isbaseexplain;}
		}
		/// <summary>
		/// 是否和其他产品混合使用
		/// </summary>
		public string IsMix
		{
			set{ _ismix=value;}
			get{return _ismix;}
		}
		/// <summary>
		/// 处理状态
		/// </summary>
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 是否有过过敏史
		/// </summary>
		public string IsAllergyHistory
		{
			set{ _isallergyhistory=value;}
			get{return _isallergyhistory;}
		}
		/// <summary>
		/// 使用时，是否处于过敏期
		/// </summary>
		public string IsAllergyTime
		{
			set{ _isallergytime=value;}
			get{return _isallergytime;}
		}
		/// <summary>
		/// 具体描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 图片链接
		/// </summary>
		public string Picture
		{
			set{ _picture=value;}
			get{return _picture;}
		}
		#endregion Model

	}
}

