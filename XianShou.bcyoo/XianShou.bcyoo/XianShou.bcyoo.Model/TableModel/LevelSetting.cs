/**  版本信息模板在安装目录下，可自行修改。
* LevelSetting.cs
*
* 功 能： N/A
* 类 名： LevelSetting
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/9/6 16:16:16   N/A    初版
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
	/// 图片流动分享图片表
	/// </summary>
	[Serializable]
	public partial class LevelSetting
	{
		public LevelSetting()
		{}
		#region Model
		private int _idplus;
		private int _delstatus=0;
		private DateTime _addtime;
		private string _area;
		private string _firstweight;
		private string _contiweight;
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
		public int Delstatus
		{
			set{ _delstatus=value;}
			get{return _delstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Area
		{
			set{ _area=value;}
			get{return _area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FirstWeight
		{
			set{ _firstweight=value;}
			get{return _firstweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ContiWeight
		{
			set{ _contiweight=value;}
			get{return _contiweight;}
		}
		#endregion Model

	}
}

