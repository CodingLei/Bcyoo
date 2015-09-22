using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XianShou.bcyoo.Admin.Business.Business;
using XianShou.bcyoo.Common.Helper;
using XianShou.bcyoo.Model.SearchModel;
using XianShou.bcyoo.Model.TableModel;
using ServiceStack.OrmLite;

namespace XianShou.bcyoo.Admin.Controllers.Demo
{
    public class DemoController : BaseController
    {
        private readonly DemoBusiness service = null;

        public DemoController()
        {
            service = new DemoBusiness();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Demo()
        {
            return View();
        }

        /// <summary>
        /// 查询Demo1页面
        /// </summary>
        /// <returns></returns>
        public ActionResult SearchDemo1()
        {

            return View();
        }

        /// <summary>
        /// Demo查询方法
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult ResultDemo1(DemoSearchModel search)
        {
            return Json(service.GetDemoResult(search));
        }

        public ActionResult DemoSave()
        {
            int id = ConvertHelper.ConvertToInt(Request["id"], 0);
            var modelList = DBHelper.Db.Select<Product_Brand>(" select * from Product_Brand with(nolock)  where IDPlus=" + id);
            Product_Brand model = new Product_Brand();
            if (modelList != null && modelList.Count > 0)
                model = modelList.FirstOrDefault();
            return View(model);
        }

        /// <summary>
        /// 新增方法
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DemoSave(Product_Brand model)
        {
            return Json(service.SaveDemo(model));
        }

        public ActionResult SearchDemo2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ResultDemo2(DemoSearchModel search, int id = 0)
        {
            search.PageSize = 10;
            search.PageIndex = (id == 0 ? 1 : id);
            var model = service.GetDemoResult(search);
            ViewData["TotalCount"] = model.TotalCount;
            return PartialView("DemoResultView", model.ProductBrandList);
        }


        public ActionResult WebAPIDemo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WebAPIPost()
        {
            var model = service.TestWebAPI(Request["Ids"]);
            ViewData["TotalCount"] = model.Count;
            return PartialView("DemoResultView", model);
        }

    }
}
