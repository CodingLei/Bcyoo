/**  版本信息模板在安装目录下，可自行修改。
* V_MaterialDetail.cs
*
* 功 能： N/A
* 类 名： V_MaterialDetail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:50   N/A    初版
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
	public partial class V_MaterialDetail
	{
		public V_MaterialDetail()
		{}
		#region Model
		private int _idplus;
		private DateTime? _addtime;
		private string _materialdescription;
		private string _tag;
		private int? _minidplus;
		private int? _type;
		private string _pictureurl;
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
		public DateTime? addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MaterialDescription
		{
			set{ _materialdescription=value;}
			get{return _materialdescription;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tag
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? minidplus
		{
			set{ _minidplus=value;}
			get{return _minidplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pictureurl
		{
			set{ _pictureurl=value;}
			get{return _pictureurl;}
		}
		#endregion Model

	}
}

