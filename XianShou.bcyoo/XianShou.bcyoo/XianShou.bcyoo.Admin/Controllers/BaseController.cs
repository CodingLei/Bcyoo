
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using XianShou.bcyoo.Common.Helper;
using XianShou.bcyoo.Model.ExtendModel;
using System.Text;

namespace XianShou.bcyoo.Admin.Controllers
{
    /// <summary>
    /// 项目控制器基类，所有需要登录验证的页面都需要继承这个类
    /// </summary>
    public abstract class BaseController : Controller
    {


        /// <summary>
        /// 构造函数
        /// </summary> 
        protected BaseController()
        {
            ValidateRequest = false;
        }

        #region 当前用户信息

        /// <summary>
        /// 当前登录人信息
        /// </summary>
        public UserInfoModel CurrentUserInfo
        {
            get
            {
                HttpCookie cookie = this.Request.Cookies["BCYOOUserInfo"];
                if (cookie == null)
                {
                    return new UserInfoModel();
                }
                else
                {
                    return new UserInfoModel
                    {
                        UserId = ConvertHelper.ConvertToInt(cookie["UserId"]),
                        RealName = cookie["UserName"],
                        AddTime = cookie["AddTime"],
                        PassWord = cookie["PassWord"],
                        RoleId = ConvertHelper.ConvertToInt(cookie["RoleId"]),
                        RoleName = cookie["RoleName"]
                    };
                }
            }
        }

        #endregion

        #region 重写基类Controller

        /// <summary>
        /// 重写Controller的OnActionExecuting方法，拦截Action的执行，进行自定义处理
        /// </summary>
        /// <param name="filterContext">上下文</param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool isLoginPage = RouteData.Values["controller"].ToString().ToLower().Equals("account");
            //如果不是登录页，尚未登录，跳转到登录页面
            if (!isLoginPage && (CurrentUserInfo == null || CurrentUserInfo.UserId == 0))
            {
                filterContext.Result = Redirect(FormsAuthentication.LoginUrl + "?returnUrl=" +
                    HttpUtility.UrlEncode(Convert.ToString(filterContext.RequestContext.HttpContext.Request.Url)));
                return;
            }

            //登录的用户信息
            ViewBag.CurrentUser = CurrentUserInfo;
            //ViewBag.IsOnLine = AppSettingsHelper.GetBool("IsOnLine");

        }

        /// <summary>
        /// 重写Controller的OnException方法,用来记录执行过程中发生的未捕获的异常信息
        /// </summary>
        /// <param name="filterContext">上下文</param>
        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;

            #region 异常日志记录

            string controller = Convert.ToString(RouteData.Values["controller"]);
            string action = Convert.ToString(RouteData.Values["action"]);
            string errorMsg = filterContext.Exception.Message +
                              "\n" + filterContext.Exception.StackTrace + "\n" +
                              filterContext.Exception.Source;

            string errorTitle = string.Format("后台发生异常，Controller：{0}，Action：{1} ", controller, action);

            #endregion

            //显示错误页面
            filterContext.Controller.ViewData["ErrorMessage"] = errorMsg;
            filterContext.Result = View("Error");
        }

        #endregion

        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new ToJsonResult
            {
                Data = data,
                ContentEncoding = contentEncoding,
                ContentType = contentType,
                JsonRequestBehavior = behavior,
                FormateStr = "yyyy-MM-dd HH:mm:ss"
            };
        }


    }
}
