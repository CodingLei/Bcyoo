// =================================================================== 
// 项目说明
//====================================================================
// 。@Copy Right 2006-2008
// 文件： DataAccessFactory.cs
// 项目名称：Demo
// 创建时间：2007-9-5
// 负责人：
// ===================================================================
using System;
using System.Text;
using System.Collections.Specialized;
using System.Collections;

namespace XianShou.bcyoo.Common.Helper
{
	///<summary>
	///提供模板分页类
	///</summary>
	public class Pager
	{
		private int currentPage = 1;
		private int pageSize;
		private int pageCount;
		private int recordCount;
        private int sepNum;
		#region Property
		public int CurrentPage
		{
			get { return currentPage; }
			set { currentPage = value; }
		}

		public int PageSize
		{
			get { return pageSize; }
			set { pageSize = value; }
		}

		public int PageCount
		{
			get { return pageCount; }
			set { pageCount = value; }
		}

		public int RecordCount
		{
			get { return recordCount; }
			set { recordCount = value; }
		}

		public int FirstPage
		{
			get { return 1; }
		}

		public int PreviousPage
		{
			get { return this.GetPreviousPage(); }
		}

		public int NextPage
		{
			get { return this.GetNextPage(); }
		}

		public int LastPage
		{
			get { return this.pageCount; }
		}
        public ArrayList ShowNum
        {
            get { return this.PageNum(); }
        }
        public int SeqNum
        {
            set { sepNum = value; }
            get { return sepNum; }
        }

		#endregion

		public Pager(int pageSize, int recordCount) : this(1, pageSize, recordCount) { }

		public Pager(int currentPage, int pageSize, int recordCount)
		{
			this.currentPage = currentPage;
			this.pageSize = pageSize;
			this.recordCount = recordCount;
			this.Init();
		}
        public Pager(int currentPage, int pageSize, int recordCount, int sep)
        {
            this.currentPage = currentPage;
            this.pageSize = pageSize;
            this.recordCount = recordCount;
            this.sepNum = sep;
            this.Init();
        }
		private void Init()
		{
			if(this.pageSize > 0 && this.recordCount > 0)
			{
				this.pageCount = (int)Math.Ceiling((double)this.recordCount / this.PageSize);

				if(this.currentPage > this.pageCount)
				{
					this.currentPage = this.pageCount;
				}

				if(this.currentPage < 1)
				{
					this.currentPage = 1;
				}
			}
		}

        private ArrayList PageNum()
        {
            ArrayList list = new ArrayList();
            int i;
            if (this.PageCount > this.SeqNum)
            {
                if (this.currentPage > (this.SeqNum / 2))
                {
                    if (this.currentPage > (this.PageCount - (this.SeqNum / 2)))
                    {
                        for (i = this.PageCount - this.SeqNum; i <= this.PageCount; i++)
                        {
                            list.Add(i);
                        }
                    }
                    else
                    {
                        for (i = this.currentPage - (this.SeqNum / 2); i <= (this.currentPage + (this.SeqNum / 2)); i++)
                        {
                            list.Add(i);
                        }
                    }

                }
                else
                {
                    for (i = 1; i <= this.SeqNum; i++)
                    {
                        list.Add(i);
                    }
                  
                }
            }
            else
            {
                for (i = 1; i <= this.PageCount; i++)
                {
                    list.Add(i);
                }
            }
            return list;
        }

		private int GetPreviousPage()
		{
				return this.currentPage > 1 ? this.currentPage - 1 : 1;
		}

		private int GetNextPage()
		{
			return this.currentPage < this.pageCount ? this.currentPage + 1 : this.currentPage;
		}

        #region  pagination：分页方法
        /// </summary>
        /// <param name="total">总记录数</param>
        /// <param name="per">每页记录数</param>
        /// <param name="page">当前页数</param>
        /// <param name="query_string">Url参数</param>
        public static string pagination(int total, int per, int page, string query_string)
        {
            int allpage = 0;
            int next = 0;
            int pre = 0;
            int startcount = 0;
            int endcount = 0;
            string pagestr = "";

            if (page < 1) { page = 1; }
            //计算总页数
            if (per != 0)
            {
                allpage = (total / per);
                allpage = ((total % per) != 0 ? allpage + 1 : allpage);
                allpage = (allpage == 0 ? 1 : allpage);
            }
            next = page + 1;
            pre = page - 1;
            startcount = (page + 5) > allpage ? allpage - 9 : page - 4;//中间页起始序号
            //中间页终止序号
            endcount = page < 5 ? 10 : page + 5;
            if (startcount < 1) { startcount = 1; } //为了避免输出的时候产生负数，设置如果小于1就从序号1开始
            if (allpage < endcount) { endcount = allpage; }//页码+5的可能性就会产生最终输出序号大于总页码，那么就要将其控制在页码数之内
            //pagestr = "共" + allpage + "页&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";

            pagestr += page > 1 ? "<a href=\"" + query_string + "page=1\">首页</a>&nbsp;&nbsp;<a href=\"" + query_string + "page=" + pre + "\">上一页</a>" : "首页 上一页";
            //中间页处理，这个增加时间复杂度，减小空间复杂度
            for (int i = startcount; i <= endcount; i++)
            {
                pagestr += page == i ? "&nbsp;&nbsp;<font color=\"#ff0000\">" + i + "</font>" : "&nbsp;&nbsp;<a href=\"" + query_string + "page=" + i + "\">" + i + "</a>";
            }
            pagestr += page != allpage ? "&nbsp;&nbsp;<a href=\"" + query_string + "page=" + next + "\">下一页</a>&nbsp;&nbsp;<a href=\"" + query_string + "page=" + allpage + "\">末页</a>" : " 下一页 末页";

            return pagestr;


        }
        #endregion
	}
}
