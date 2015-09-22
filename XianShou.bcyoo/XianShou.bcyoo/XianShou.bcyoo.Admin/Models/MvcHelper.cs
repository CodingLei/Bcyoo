
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using XianShou.bcyoo.Common.Helper;
using HtmlHelper = System.Web.Mvc.HtmlHelper;

namespace XianShou.bcyoo.Admin.Models
{
    /// <summary>
    /// 
    /// </summary>
    public static class MvcHelper
    {
        private static readonly string m_SecondCatlog = HttpContext.Current.Request.ApplicationPath;

        /// <summary>
        /// 获取系统虚拟目录名称
        /// </summary>
        /// <returns>MvcHtmlString</returns>
        public static MvcHtmlString SecondCatlog()
        {
            return new MvcHtmlString(m_SecondCatlog.Equals("/") ? string.Empty : m_SecondCatlog);
        }

        

        /// <summary>
        /// 保存，提交按钮帮助Helper
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper</param>
        /// <param name="btnText">按钮上显示的文本</param>
        /// <param name="htmlAttributes">自定义的属性和事件</param>
        /// <returns>MvcHtmlString</returns>
        public static MvcHtmlString SubmitButton(this HtmlHelper htmlHelper, string btnText, object htmlAttributes = null)
        {
            var tag = new TagBuilder("input");
            tag.MergeAttribute("type", "submit");
            tag.MergeAttribute("value", btnText);
            tag.MergeAttribute("class", "btn btn-primary");
            tag.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
            return MvcHtmlString.Create(tag.ToString(TagRenderMode.SelfClosing));
        }

        /// <summary>
        /// 普通按钮， Helper
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper</param>
        /// <param name="btnText">按钮上显示的文本</param>
        /// <param name="htmlAttributes">自定义的属性和事件</param>
        /// <param name="attachClass">附加css样式</param>
        /// <returns>MvcHtmlString</returns>
        public static MvcHtmlString Button(this HtmlHelper htmlHelper, string btnText, object htmlAttributes = null, string attachClass = "")
        {
            var tag = new TagBuilder("input");
            tag.MergeAttribute("type", "button");
            tag.MergeAttribute("value", btnText);
            tag.MergeAttribute("class", "btn " + attachClass);
            tag.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
            return MvcHtmlString.Create(tag.ToString(TagRenderMode.SelfClosing));
        }

        /// <summary>
        /// btn btn-primary 按钮帮助Helper
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper</param>
        /// <param name="btnText">按钮上显示的文本</param>
        /// <param name="htmlAttributes">自定义的属性和事件</param>
        /// <returns>MvcHtmlString</returns>
        public static MvcHtmlString PrimaryButton(this HtmlHelper htmlHelper, string btnText, object htmlAttributes = null)
        {
            var tag = new TagBuilder("input");
            tag.MergeAttribute("type", "button");
            tag.MergeAttribute("value", btnText);
            tag.MergeAttribute("class", "btn btn-primary");
            tag.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
            return MvcHtmlString.Create(tag.ToString(TagRenderMode.SelfClosing));
        }

        /// <summary>
        /// 系统中 新增按钮
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper</param>
        /// <param name="btnText">按钮上显示的文本</param>
        /// <param name="htmlAttributes">自定义的属性和事件</param>
        /// <returns>MvcHtmlString</returns>
        public static MvcHtmlString AddButton(this HtmlHelper htmlHelper, string btnText, object htmlAttributes = null)
        {
            var tag = new TagBuilder("a");
            tag.MergeAttribute("class", "btn");
            tag.InnerHtml = "<i class=\"icon-plus\"></i>" + btnText;
            tag.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
            return MvcHtmlString.Create(tag.ToString(TagRenderMode.Normal));
        }

        /// <summary>
        /// 系统中 新增按钮,可以带链接地址的，之前写的忘记链接，所以重载一个
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper</param>
        /// <param name="btnText">按钮上显示的文本</param>
        /// <param name="href">链接地址,不用加虚拟目录了，此方法会自动加上</param>
        /// <param name="htmlAttributes">自定义的属性和事件</param>
        /// <returns>MvcHtmlString</returns>
        public static MvcHtmlString AddButton(this HtmlHelper htmlHelper, string btnText, string href, object htmlAttributes = null)
        {
            var tag = new TagBuilder("a");
            tag.MergeAttribute("class", "btn");
            if (href != null && href.Trim().Length > 0)
            {
                tag.MergeAttribute("href", SecondCatlog() + href);
            }
            tag.InnerHtml = "<i class=\"icon-plus\"></i>" + btnText;
            tag.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
            return MvcHtmlString.Create(tag.ToString(TagRenderMode.Normal));
        }

        /// <summary>
        /// 绿色新增按钮
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper</param>
        /// <param name="btnText">按钮显示文本</param>
        /// <param name="href">链接地址， 不用加虚拟目录了，此方法会自动加上</param>
        /// <param name="istopright">是否位于页面右上方</param>
        /// <param name="htmlAttributes">其他自定义的一些属性</param>
        /// <returns>MvcHtmlString</returns>
        public static MvcHtmlString GreenAddButton(this HtmlHelper htmlHelper, string btnText, string href, bool istopright, object htmlAttributes = null)
        {
            var tag = new TagBuilder("a");
            tag.MergeAttribute("class", "add-content btn btn-success " + (istopright ? "pull-right" : ""));
            if (href != null && href.Trim().Length > 0)
            {
                tag.MergeAttribute("href", SecondCatlog() + href);
            }
            tag.InnerHtml = "<i class=\"icon-plus icon-white\"></i>" + btnText;
            tag.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
            return MvcHtmlString.Create(tag.ToString(TagRenderMode.Normal));
        }

        /// <summary>
        /// 图片Helper
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper</param>
        /// <param name="src">图片路径</param>
        /// <param name="width">图片宽度 px 不限制传入0</param>
        /// <param name="height">图片高度 px 不限制传入0</param>
        /// <param name="htmlAttributes">自定义的属性和事件</param>
        /// <returns>MvcHtmlString</returns>
        public static MvcHtmlString Image(this HtmlHelper htmlHelper, string src, int width = 0, int height = 0, object htmlAttributes = null)
        {
            var tag = new TagBuilder("img");
            tag.MergeAttribute("src", src);
            if (width > 0)
                tag.MergeAttribute("width", width.ToString());
            if (height > 0)
                tag.MergeAttribute("height", height.ToString());
            tag.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
            return MvcHtmlString.Create(tag.ToString(TagRenderMode.SelfClosing));
        }

        /// <summary>
        /// SuccessLabel 列表里label label-success 样式的span
        /// </summary>
        /// <param name="htmlHelper">HtmlHelper</param>
        /// <param name="labelText">label上显示的文本</param>
        /// <param name="htmlAttributes">自定义的属性和事件</param>
        /// <returns>MvcHtmlString</returns>
        public static MvcHtmlString SuccessLabel(this HtmlHelper htmlHelper, string labelText, object htmlAttributes = null)
        {
            var tag = new TagBuilder("<span>");
            tag.MergeAttribute("class", "label label-success");
            tag.SetInnerText(labelText);
            tag.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
            return MvcHtmlString.Create(tag.ToString(TagRenderMode.Normal));
        }

        /// <summary>
        /// 系统中的分页Helper
        /// </summary>
        /// <param name="helper">HtmlHelper</param>
        /// <param name="recordCount">总的记录数</param>
        /// <param name="onclickEvent">onclick时间函数</param>
        /// <param name="pageSize">每页显示的记录数</param>
        /// <returns>MvcHtmlString</returns>
        public static MvcHtmlString Pager(this HtmlHelper helper, int recordCount, int pageSize = 10, string onclickEvent = "")
        {
            //最多显示的页码数，默认10,10页之后的，点了10以后才显示
            int showPageNum = 5;

            int currentPageIndex = Convert.ToInt32(helper.ViewContext.RequestContext.RouteData.Values["id"]);

            //默认显示第一页
            if (currentPageIndex == 0)
            {
                currentPageIndex = 1;
            }

            //总共的页数
            int pageCount = (recordCount % pageSize == 0 ? recordCount / pageSize : recordCount / pageSize + 1);

            if (pageCount > 0 && pageCount < 10 && pageSize < 10)
            {
                showPageNum = pageCount;
            }

            string sign = Guid.NewGuid().ToString();

            StringBuilder url = new StringBuilder(
                new UrlHelper(helper.ViewContext.RequestContext).Action(
                    helper.ViewContext.RouteData.Values["action"].ToString(),
                    helper.ViewContext.RouteData.Values["controller"].ToString(),
                    new { id = sign })
                );

            url.Replace(sign, "{0}");

            //QueryString的处理
            List<string> queryString = new List<string>();
            NameValueCollection collection = HttpContext.Current.Request.QueryString;
            foreach (string key in collection.Keys)
            {
                if (key != null)
                {
                    if (!queryString.Contains(key))
                    {
                        queryString.Add(key + "=" + collection[key]);
                    }
                }
            }

            string querystr = String.Join("&", queryString.ToArray());

            if (!string.IsNullOrWhiteSpace(querystr))
            {
                url.Append("?" + querystr);
            }

            StringBuilder sb = new StringBuilder("<div >");
            sb.Append("<div style=\"float:right;margin-top:6px; margin-left:10px; margin-right:20px;\">");
            sb.AppendFormat("共<span class=\"required\">{0}</span>条记录&nbsp;&nbsp;", recordCount);
            sb.AppendFormat("每页<span class=\"green\">{0}</span>&nbsp;条&nbsp;", pageSize);
            sb.AppendFormat("共<span class=\"required\">{0}</span>页&nbsp;&nbsp;", pageCount);
            if (recordCount > 0)
            {
                sb.AppendFormat("当前第<span class=\"blue\">&nbsp;{0}&nbsp;</span>页", currentPageIndex);
            }

            sb.Append("</div><ul class=\"pager\">");

            if (currentPageIndex != 1)
            {
                string url1 = string.Format(url.ToString(), 1);
                sb.AppendFormat("<li><a href=\"{0}\" title=\"回到首页\" onclick='{1} return formPager(this);'>首页</a></li>", url1, onclickEvent);
            }
            if (currentPageIndex > 1)
            {
                string url1 = string.Format(url.ToString(), currentPageIndex - 1);
                sb.AppendFormat("<li><a href=\"{0}\" title=\"上一页\" onclick='{1} return formPager(this);'>«</a></li>", url1, onclickEvent);
            }

            #region 页码生成

            int k = currentPageIndex / showPageNum;
            int m = currentPageIndex % showPageNum;

            if (currentPageIndex / pageSize == pageCount / pageSize)
            {
                if (m == 0)
                {
                    k--;
                    m = showPageNum;
                }
                else
                {
                    m = pageCount % showPageNum;
                    if (pageCount > 0 && pageCount < 10 && pageSize < 10)
                    {
                        m = pageCount;
                    }
                }
            }
            else if (pageSize > 0 && pageSize < 10 && pageCount >= 10 && currentPageIndex / showPageNum == pageCount / showPageNum && currentPageIndex % showPageNum == 0)
            {
                m = showPageNum;
                k--;
            }
            else
                m = showPageNum;

            for (int i = k * showPageNum + 1; i <= k * showPageNum + m; i++)
            {
                if (i == currentPageIndex)
                {
                    sb.AppendFormat("<li class=\"active\"><a><b>{0}</b></a></li>", i);
                }
                else
                {
                    string url1 = string.Format(url.ToString(), i);
                    sb.AppendFormat("<li><a href=\"{0}\" title=\"转到第{1}页\" onclick='{2} return formPager(this);'>{1}</a></li>", url1, i, onclickEvent);
                }
            }

            #endregion

            if (currentPageIndex < pageCount)
            {
                string url1 = string.Format(url.ToString(), currentPageIndex + 1);
                sb.AppendFormat("<li><a href=\"{0}\" title=\"下一页\" onmouseover='return null;' onclick='{1} return formPager(this);'>»</a></li>", url1, onclickEvent);
            }

            if (currentPageIndex != pageCount && recordCount > 0)
            {
                string url1 = string.Format(url.ToString(), pageCount);
                sb.AppendFormat("<li><a href=\"{0}\" title=\"转到末页\" onclick='{1} return formPager(this);'>末页</a></li>", url1, onclickEvent);
            }

            sb.Append("</ul>");
            sb.Append("</div>");

            return new MvcHtmlString(sb.ToString());
        }

        /// <summary>
        /// angularjs分页
        /// </summary>
        /// <returns></returns>
        public static MvcHtmlString PagerIndex()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"<pagination id='pagehtml' total-items='bigTotalItems' ng-model='bigCurrentPage' ng-change='pageChanged()' max-size='maxSize' class='pager' boundary-links='true' items-per-page='itemsPerPage' num-pages='numPages'></pagination>");
            sb.Append(@"<pre>Page: {{bigCurrentPage}} / {{numPages}}</pre>");
            sb.Append(@"<script language='javascript' type='text/javascript'>
    $(function () {
        $('#pagehtml').removeClass().addClass('pager');
    });
    </script>");
            return new MvcHtmlString(sb.ToString());
        }

        /// <summary>
        /// 请求参数赋值给给定类型的实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetRequestDataToEntity<T>() where T : class
        {
            return GetRequestDataToEntity<T>(typeof(T));
        }

        /// <summary>
        /// 将Web请求参数赋值给给定类型的实体
        /// </summary>
        /// <param name="entityType">查询条件实体类型，继承BaseSearchModel</param>
        /// <returns></returns>
        public static T GetRequestDataToEntity<T>(Type entityType) where T : class
        {
            var entity = Activator.CreateInstance(entityType);
            var form = HttpContext.Current.Request.Form;
            var query = HttpContext.Current.Request.QueryString;
            var param = HttpContext.Current.Request.Params;
            foreach (var p in entityType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase))
            {
                if (form[p.Name] != null)
                {
                    p.SetValue(entity, GetPropertyValue(form[p.Name], p.PropertyType), null);
                    continue;
                }
                if (query[p.Name] != null)
                {
                    p.SetValue(entity, GetPropertyValue(query[p.Name], p.PropertyType), null);
                    continue;
                }
                if (param[p.Name] != null)
                {
                    p.SetValue(entity, GetPropertyValue(param[p.Name], p.PropertyType), null);
                }
            }
            return entity as T;
        }

        /// <summary>
        /// 获取属性值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertyType"></param>
        /// <returns></returns>
        private static object GetPropertyValue(string value, Type propertyType)
        {
            try
            {
                Type t = propertyType;
                if (t.Name == typeof(Nullable<>).Name)
                {
                    //可空值类型，要取形参
                    t = t.GetGenericArguments()[0];
                }

                return Convert.ChangeType(value.Trim(), t);
            }
            catch
            {
                //转换出错的话，返回类型的默认值
                return Activator.CreateInstance(propertyType);
            }
        }

        /// <summary>
        /// 异步加载调用的信息
        /// </summary>
        /// <param name="ajaxHelper"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        public static MvcHtmlString Message(this AjaxHelper ajaxHelper, string actionName)
        {
            return Message(ajaxHelper, actionName, null, null);
        }

        /// <summary>
        /// 异步加载调用的信息
        /// </summary>
        /// <param name="ajaxHelper"></param>
        /// <param name="actionName"></param>
        /// <param name="cotrollerName"></param>
        /// <returns></returns>
        public static MvcHtmlString Message(this AjaxHelper ajaxHelper, string actionName, string cotrollerName)
        {
            return Message(ajaxHelper, actionName, cotrollerName, null);
        }

        /// <summary>
        /// 异步加载调用的信息
        /// </summary>
        /// <param name="ajaxHelper"></param>
        /// <param name="actionName"></param>
        /// <param name="routeValues"></param>
        /// <returns></returns>
        public static MvcHtmlString Message(this AjaxHelper ajaxHelper, string actionName, object routeValues)
        {
            return Message(ajaxHelper, actionName, null, routeValues);
        }

        /// <summary>
        /// 异步加载调用的信息
        /// </summary>
        /// <param name="ajaxHelper"></param>
        /// <param name="actionName"></param>
        /// <param name="cotrollerName"></param>
        /// <param name="routeValues"></param>
        /// <returns></returns>
        public static MvcHtmlString Message(this AjaxHelper ajaxHelper, string actionName, string cotrollerName, object routeValues)
        {
            var url = new UrlHelper(ajaxHelper.ViewContext.RequestContext).Action(actionName, cotrollerName, routeValues);
            return new MvcHtmlString(string.Format("<span class=\"ajaxMessage\" ajax-action=\"{0}\">信息加载中...</span>", url));
        }
        
    }
}