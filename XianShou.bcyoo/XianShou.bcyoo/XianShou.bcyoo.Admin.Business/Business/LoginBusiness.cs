using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XianShou.bcyoo.Common.Helper;
using XianShou.bcyoo.Model.ExtendModel;
using ServiceStack.OrmLite;
using XianShou.bcyoo.Model.TableModel;
using System.Web;

namespace XianShou.bcyoo.Admin.Business.Business
{
    public class LoginBusiness
    {
        public ReturnInfoModel LoginSubmit(string username, string password)
        {
            var userInfo = DBHelper.Db.Select<Employee>(string.Format("select * from Employee with(nolock) where  IDPlus ={0} and LoginPassword='{1}' and DelStatus=0", ConvertHelper.ConvertToInt(username, 0), SecurityHelper.SetMD5(password)));
            if (userInfo == null || userInfo.Count == 0)
                return ReturnInfo.Failure("用户名或密码不正确！");

            HttpCookie userCookie = HttpContext.Current.Response.Cookies["BCYOOUserInfo"];
            if (userCookie != null)
            {
                HttpContext.Current.Response.Cookies.Remove("BCYOOUserInfo");
            }
            userCookie = new HttpCookie("BCYOOUserInfo");
            userCookie.Values["UserName"] = userInfo.FirstOrDefault().EmployeeName;
            userCookie.Values["UserId"] = userInfo.FirstOrDefault().IDPlus.ToString();
            userCookie.Values["RoleId"] = userInfo.FirstOrDefault().RoleId;
            userCookie.Values["RoleName"] = userInfo.FirstOrDefault().RoleValue;
            userCookie.Values["AddTime"] = userInfo.FirstOrDefault().AddTime.ToString();
            userCookie.Values["PassWord"] = SecurityHelper.SetMD5(password);

            userCookie.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(userCookie);


            return ReturnInfo.Success();
        }
    }
}
