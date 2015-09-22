using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XianShou.bcyoo.Admin.Business.WebAPI;
using XianShou.bcyoo.Model.TableModel;

namespace XianShou.bcyoo.WebAPI.Controllers.Demo
{
    [Authorize(Users="shaohaibo")]
    public class DemoController : ApiController
    {
        private readonly DemoService service = null;

        public DemoController()
        {
            service = new DemoService();
        }

        [HttpPost]
        [ActionName("GetBrand")]
        public string GetBrandList([FromBody] string ids)
        {
            return JsonConvert.SerializeObject(service.GetBrandList(ids));
        }

        [HttpPost]
        public string AddDemo([FromBody] Product_Category model)
        {
            return JsonConvert.SerializeObject(service.AddDemo(model));
        }

        [HttpPut]
        public string UpdateDemo(Product_Category model)
        {
            return JsonConvert.SerializeObject(service.UpdateDemo(model));
        }
    }
}