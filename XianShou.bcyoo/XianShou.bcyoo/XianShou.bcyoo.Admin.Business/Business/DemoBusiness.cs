using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XianShou.bcyoo.Model.SearchModel;
using ServiceStack.OrmLite;
using XianShou.bcyoo.Common.Helper;
using XianShou.bcyoo.Admin.DataAccess.DataAccess;
using XianShou.bcyoo.Model.ExtendModel;
using XianShou.bcyoo.Model.TableModel;
using Newtonsoft.Json;

namespace XianShou.bcyoo.Admin.Business.Business
{
    public class DemoBusiness
    {
        public DemoSearchResultModel GetDemoResult(DemoSearchModel search)
        {
            return new DemoDataAccess().GetDemoResult(search);
        }

        public ReturnInfoModel SaveDemo(Product_Brand model)
        {
            ReturnInfoModel returninfo = new ReturnInfoModel();
            if (model.IDPlus > 0)
            {
                if (DBHelper.Db.Update<Product_Brand>(model) == 0)
                {
                    return ReturnInfo.Failure("修改失败");
                }
            }
            else
            {
                if (DBHelper.Db.Insert <Product_Brand>(model) > 0)
                {
                    return ReturnInfo.Failure("添加失败");
                }
            }
            return ReturnInfo.Success();
        }

        public List<Product_Brand> TestWebAPI(string ids)
        {
            string result = RequestHelper.SendPostHttpRequest("http://192.168.88.133:888/Api/Demo/GetBrandList", "application/json", JsonConvert.SerializeObject(ids));//"application/json"

            if (string.IsNullOrWhiteSpace(result) || result == "null") return null;

            return EntityUtil.ToList<Product_Brand>(JSONHelper.JsonToDataTable(result));
        }
    }
}
