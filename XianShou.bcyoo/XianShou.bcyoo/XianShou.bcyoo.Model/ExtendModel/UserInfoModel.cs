using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XianShou.bcyoo.Model.ExtendModel
{
    [Serializable]
    public class UserInfoModel
    {
        /// <summary>
        /// 工号
        /// </summary>

        public string JobNumber { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }

        
        /// <summary>
        /// 是否记住密码
        /// </summary>
        public bool IsRemember { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public string AddTime { get; set; }

        /// <summary>
        /// 权限ID
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// 权限名称
        /// </summary>
        public string RoleName { get; set; }
    }

    /// <summary>
    /// 常用用户信息静态类
    /// </summary>
    public static class UserInfoHelper
    {
        static UserInfoHelper()
        {
            SystemUser = new UserInfoModel { RealName = "系统", JobNumber = string.Empty };
            PayNoticeUser = new UserInfoModel { RealName = "支付回写", JobNumber = string.Empty };
        }

        /// <summary>
        /// 系统用户
        /// </summary>
        public static UserInfoModel SystemUser { get; private set; }

        /// <summary>
        /// 支付回写用户
        /// </summary>
        public static UserInfoModel PayNoticeUser { get; private set; }

        /// <summary>
        /// 客户用户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static UserInfoModel CustomerUser(string name = "客户")
        {
            if (string.IsNullOrWhiteSpace(name)) name = "客户";
            return new UserInfoModel { RealName = name, JobNumber = string.Empty };
        }
    }
}
