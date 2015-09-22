using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XianShou.bcyoo.Admin.Controllers.Home
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/

        public ActionResult HomeIndex()
        {
            return View();
        }

    }
}
