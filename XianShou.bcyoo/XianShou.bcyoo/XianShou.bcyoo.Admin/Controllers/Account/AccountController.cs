using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XianShou.bcyoo.Admin.Business.Business;

namespace XianShou.bcyoo.Admin.Controllers.Account
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult LoginOn()
        {
            HttpCookie userCookie = new HttpCookie("BCYOOUserInfo");
            userCookie.Expires = DateTime.Now;
            this.Response.Cookies.Add(userCookie);

            return View();
        }

        [HttpPost]
        public ActionResult LoginSubmit()
        {
            string username = Request["UserName"];
            string password = Request["PassWord"];

            return Json(new LoginBusiness().LoginSubmit(username, password));
        }

    }
}
