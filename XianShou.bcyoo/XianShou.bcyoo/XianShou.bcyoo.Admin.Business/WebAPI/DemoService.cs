using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XianShou.bcyoo.Common.Helper;
using XianShou.bcyoo.Model.TableModel;
using ServiceStack.OrmLite;
using XianShou.bcyoo.Model.ExtendModel;

namespace XianShou.bcyoo.Admin.Business.WebAPI
{
    public class DemoService
    {
        public List<Product_Brand> GetBrandList(string ids)
        {
            if (string.IsNullOrWhiteSpace(ids)) return null;

            var model = DBHelper.Db.Select<Product_Brand>(" select * from Product_Brand with(nolock)  where IDPlus in (" + ids.TrimEnd(',') + ") ");
            return model;
        }

        public ReturnInfoModel AddDemo(Product_Category model)
        {
            if (model == null) return ReturnInfo.Failure("传入参数错误");

            bool result = DBHelper.Db.Insert<Product_Category>(model) > 0;
            if (!result)
                return ReturnInfo.Failure("添加失败");
            return ReturnInfo.Success();
        }

        public ReturnInfoModel UpdateDemo(Product_Category model)
        {
            if (model == null) return ReturnInfo.Failure("传入参数错误");

            bool result = DBHelper.Db.Update<Product_Category>(model) > 0;
            if (!result)
                return ReturnInfo.Failure("修改失败");
            return ReturnInfo.Success();
        }
    }
}
