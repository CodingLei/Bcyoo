using System.Web.Mvc;
using XianShou.bcyoo.Model.Enum;

namespace XianShou.bcyoo.Admin.Models
{
    /// <summary>
    /// 从后端往前台
    /// </summary>
    public static class PageIntersectHelper
    {
        /// <summary>
        /// 消息提示框
        /// </summary>
        /// <param name="controller">控制器当前对象</param>
        /// <param name="message">消息内容，支持HTML格式</param>
        /// <param name="iconEnum">消息图标，指定消息框显示的图标</param>
        /// <param name="callback">消息窗口关闭时执行的js回调函数</param>
        /// <returns></returns>
        public static ActionResult Alert(this Controller controller, string message, MessageIconEnum iconEnum = MessageIconEnum.Alert, string callback = null)
        {
            return new JavaScriptResult
                {
                    Script = string.Format("$.alert('{0}',{1},{2})"
                                           , FilterIrregularString(message) ?? string.Empty
                                           , iconEnum.ToString("d")
                                           , !string.IsNullOrWhiteSpace(callback) ? callback : "null")
                };
        }

        /// <summary>
        /// 右下角浮动消息窗口
        /// </summary>
        /// <param name="controller">控制器当前对象</param>
        /// <param name="content">窗口内容，支持HTML格式</param>
        /// <param name="width">设置窗口的宽度</param>
        /// <param name="height">设置窗口的高度</param>
        /// <param name="title">窗口的标题文本</param>
        /// <param name="id">设定对话框唯一标识，防止重复弹出</param>
        /// <param name="iconEnum">消息图标，0=无 1=提示 2=成功 3=失败 4=确认，默认0</param>
        /// <returns></returns>
        public static ActionResult Notice(this Controller controller, string content, int? width = null, int? height = null, string title = null, string id = null, MessageIconEnum iconEnum = MessageIconEnum.None)
        {
            string script = string.Format("$.notice('{0}'", FilterIrregularString(content) ?? string.Empty);
            script += (width.HasValue ? "," + width.Value : string.Empty);
            script += (height.HasValue ? "," + height.Value : string.Empty);
            script += (!string.IsNullOrEmpty(title) ? "," + title : string.Empty);
            script += (!string.IsNullOrEmpty(id) ? "," + title : string.Empty);
            script += (!iconEnum.Equals(0) ? "," + iconEnum.ToString("d") : string.Empty);
            script += ");";
            return new JavaScriptResult {Script = script};
        }

        /// <summary>
        /// 窗口页向父页面回写数据方法
        /// </summary>
        /// <param name="data">需要回写的数据，后台调用只支持字符</param>
        /// <param name="isCloseDialog">是否关闭对话框</param>
        /// <returns></returns>
        public static ActionResult ReturnDialogResult(string data = null, bool isCloseDialog = true)
        {
            return new JavaScriptResult
                {
                    Script = string.Format("$.returnDialogResult('{0}',{1})"
                                           , FilterIrregularString(data) ?? string.Empty
                                           , isCloseDialog.ToString().ToLower())
                };
        }

        /// <summary>
        /// 关闭对话框，兼容lhgdialog和js自带对话框
        /// </summary>
        /// <returns></returns>
        public static ActionResult CloseDialog()
        {
            return new JavaScriptResult { Script = "$.closeDialog()" };
        }

        /// <summary>
        /// 过滤不规则字符，主要是单引号
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private static string FilterIrregularString(string content)
        {
            if (content != null)
            {
                content = content.Replace("\'", "#[Gular]").Replace("'", "\'").Replace("#[Gular]", "\'");
            }
            return content;
        }
    }
}