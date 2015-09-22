/**  版本信息模板在安装目录下，可自行修改。
* Product_UploadMaterial.cs
*
* 功 能： N/A
* 类 名： Product_UploadMaterial
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:36   N/A    初版
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
	/// 产品上传素材表
	/// </summary>
	[Serializable]
	public partial class Product_UploadMaterial
	{
		public Product_UploadMaterial()
		{}
		#region Model
		private int _idplus;
		private string _id= "newid";
		private DateTime? _addtime= DateTime.Now;
		private int? _delstatus=0;
		private int? _memberidplus;
		private string _content;
		private int? _materialtype;
		private int? _state=0;
		private int? _systemidplus;
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
		/// 代理商IDPlus
		/// </summary>
		public int? MemberIDPlus
		{
			set{ _memberidplus=value;}
			get{return _memberidplus;}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 素材类型
		/// </summary>
		public int? MaterialType
		{
			set{ _materialtype=value;}
			get{return _materialtype;}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 操作人IDPlus
		/// </summary>
		public int? SystemIDPlus
		{
			set{ _systemidplus=value;}
			get{return _systemidplus;}
		}
		#endregion Model

	}
}

